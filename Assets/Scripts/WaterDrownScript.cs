using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class WaterDrownScript : MonoBehaviour
{

    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();//get the logicscript component from the logic object
    }

    //when the bird collide with the middle object that we added we trigger this
    private void OnCollisionEnter2D(Collision2D collision)
    {

   
        if (collision.gameObject.layer == 3 || collision.gameObject.layer == 6)//making sure that the player object tuched the coin not other object                                                                      //player1 is layer 3, player2 layer 6
    {
    
        logic.playerReset(collision.gameObject.layer);
       

    }

     

    }


}
