using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public int moveSpeed = 5;

    int damageType;
    int canMove = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == 0){
        float horizontal = Input.GetAxisRaw("Horizontal");
		float veritcal = Input.GetAxis("Vertical");

		Vector2 moveDirection = new Vector2(horizontal, veritcal);

		transform.Translate(moveDirection * Time.deltaTime * moveSpeed);
        }
    }
    void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.name == "Spike"){
            Debug.Log("Ouch!");
            damageType = 1;
            GameObject.FindObjectOfType<GameManager>().UpdateHealth(damageType);
		}
        if(collider.gameObject.name == "HalfHeart"){
            Debug.Log("Ooh!");
            damageType = -1;
            GameObject.FindObjectOfType<GameManager>().UpdateHealth(damageType);
		}
        if(collider.gameObject.name == "Pit"){
            Debug.Log("AHH!");
            damageType = 2;
            GameObject.FindObjectOfType<GameManager>().UpdateHealth(damageType);
		}
     }
     public void UpdateMovement(){
         if(canMove == 0){
             canMove= 3;
             transform.localScale = new Vector2(.75f, .75f);
         }else if(canMove == 3){
             canMove = 2;
             transform.localScale = new Vector2(.5f, .5f);
         }else if(canMove == 2){
             canMove = 1;
             transform.localScale = new Vector2(.25f, .25f);
         }else if(canMove == 1){
             canMove = 0;
             transform.localScale = new Vector2(1f, 1f);
             transform.Translate(-1f, 0f, 0f);
         }
     }
     public void Respawn(){
         transform.localPosition = new Vector2(-6.5f, 0.5f);
     }
}
