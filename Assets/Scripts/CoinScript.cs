using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script represents the Coin Object 

public class CoinScript : MonoBehaviour
{

    public LogicScript logic;
    public AudioClip coinSound;
    const int playerOneLayer = 3;
    const int playerTwoLayer = 6;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();//get the logicscript component from the logic object
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //making sure that the player object tuched the coin not other object
        if (collision.gameObject.layer == playerOneLayer || collision.gameObject.layer == playerTwoLayer) { //making sure that the player object tuched the coin not other object
                                           
        
            Debug.Log("Coin Deleted");
            AudioSource.PlayClipAtPoint(coinSound,transform.position); //play sound at the coins position
            Destroy(gameObject); // delete the object after the collision
            logic.addScore(1, collision.gameObject.layer); // increse the score for specfic player
        }


    }

}
