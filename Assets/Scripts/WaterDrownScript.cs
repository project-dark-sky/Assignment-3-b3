using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//This script represents a collidor of the water
public class WaterDrownScript : MonoBehaviour
{

    public LogicScript logic;
    const int playerOneLayer = 3;
    const int playerTwoLayer = 6;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();//get the logicscript component from the logic object
    }

    //when a player collide with the water
    private void OnCollisionEnter2D(Collision2D collision)
    {
   
        if (collision.gameObject.layer == playerOneLayer || collision.gameObject.layer == playerTwoLayer)//making sure that the player object tuched the coin not other object                                                                      //player1 is layer 3, player2 layer 6
    {
        //if he collide reset the score of specfic player
        logic.playerReset(collision.gameObject.layer);
       
    }

    
    }


}
