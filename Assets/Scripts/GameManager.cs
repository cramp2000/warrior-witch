using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int healthNum = 10;
    public int MAXHEALTH = 10;
    public Image heart1, heart2, heart3, heart4, heart5;
    Sprite FULLHEART, HALFHEART, NOHEART;

    public void UpdateHealth(int damageType){
        if(damageType == 1 && healthNum > 0){
            healthNum--;
        }
        if(damageType == -1 && healthNum < MAXHEALTH){
            healthNum++;
        }
        if(damageType == 2 && healthNum > 1){
            healthNum-=2;
        }else if(damageType == 2 && healthNum == 1){
            healthNum--;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        FULLHEART = Resources.Load<Sprite>("Images/FullHeart");
        HALFHEART = Resources.Load<Sprite>("Images/HalfHeart");
        NOHEART = Resources.Load<Sprite>("Images/EmptyHeart");
    }

    // Update is called once per frame
    void Update()
    {
        if(healthNum == 10){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = FULLHEART;
            heart4.sprite = FULLHEART;
            heart5.sprite = FULLHEART;
        }
        if(healthNum == 9){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = FULLHEART;
            heart4.sprite = FULLHEART;
            heart5.sprite = HALFHEART;
        }
        if(healthNum == 8){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = FULLHEART;
            heart4.sprite = FULLHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 7){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = FULLHEART;
            heart4.sprite = HALFHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 6){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = FULLHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 5){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = HALFHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 4){
            heart1.sprite = FULLHEART;
            heart2.sprite = FULLHEART;
            heart3.sprite = NOHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 3){
            heart1.sprite = FULLHEART;
            heart2.sprite = HALFHEART;
            heart3.sprite = NOHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 2){
            heart1.sprite = FULLHEART;
            heart2.sprite = NOHEART;
            heart3.sprite = NOHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 1){
            heart1.sprite = HALFHEART;
            heart2.sprite = NOHEART;
            heart3.sprite = NOHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
        }
        if(healthNum == 0){
            heart1.sprite = NOHEART;
            heart2.sprite = NOHEART;
            heart3.sprite = NOHEART;
            heart4.sprite = NOHEART;
            heart5.sprite = NOHEART;
            healthNum = 10;
            GameObject.FindObjectOfType<PlayerMove>().Respawn();
        }
    }
}
