using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.TryGetComponent<PlayerMove>(out var Player)){
            GameObject.FindObjectOfType<PlayerMove>().UpdateMovement();
            StartCoroutine(ExecuteAfterTime(.1f));
		}
    }
    IEnumerator ExecuteAfterTime(float time){
        yield return new WaitForSeconds(time);
        GameObject.FindObjectOfType<PlayerMove>().UpdateMovement();
        yield return new WaitForSeconds(time);
        GameObject.FindObjectOfType<PlayerMove>().UpdateMovement();
        yield return new WaitForSeconds(time);
        GameObject.FindObjectOfType<PlayerMove>().UpdateMovement();
    }
}
