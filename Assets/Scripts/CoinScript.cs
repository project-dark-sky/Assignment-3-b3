using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public LogicScript logic;
    public AudioClip coinSound;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();//get the logicscript component from the logic object
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 3|| collision.gameObject.layer == 6)//making sure that the player object tuched the coin not other object
                                            //player1 is layer 3, player2 layer 6
        {
            Debug.Log("Coin Deleted");
            AudioSource.PlayClipAtPoint(coinSound,transform.position); //play sound at the coint position
            Destroy(gameObject);
            logic.addScore(1, collision.gameObject.layer);
        }


    }

}
