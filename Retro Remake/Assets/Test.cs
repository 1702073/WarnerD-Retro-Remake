using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public int numberOfItems, score;                //ints are wwhole numbers
    public float health, weight, speed;             //flout are numvbers that can have decimals
    public string actualFavoriteStudent, characterName;            //letters or words
    public bool isEffectAct, isGrounded;            //true or false
    public Vector2 size, playerLocation;           //2 dementinal decimals

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Derek's favorite student is " + characterName);

        if (isGrounded)    //Will execute rhe code below IF THE STATMENT IN THE PARENTHESES IS CURRENTLY TRUE
        {
            Debug.Log("On the floor crying");
        }
        else //code will work if the if th code above doesnt activate
        {
            Debug.Log("Just kidding it's actually " + actualFavoriteStudent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
