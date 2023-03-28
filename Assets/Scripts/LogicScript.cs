using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//This script represents the logic on the UI
public class LogicScript : MonoBehaviour
{

    public int player1Score;
    public int player2Score;
    public Text player1Text;
    public Text player2Text;
    const int playerOneLayer = 3;
    const int playerTwoLayer = 6;




    //increase specfic player score by specfic score
    [ContextMenu("Increase Score")]  
    public void addScore(int scoreToadd,int playerLayer)
    {
        if(playerLayer == playerOneLayer) {
            player1Score += scoreToadd;
            player1Text.text = player1Score.ToString();

        }else if(playerLayer == playerTwoLayer) {
            player2Score += scoreToadd;
            player2Text.text = player2Score.ToString();
        }
    }


    //reset the player score that tuched the water
    [ContextMenu("Player Reset")]   
    public void playerReset(int playerLayer)
    {
        if (playerLayer == playerOneLayer)
        {
            player1Score = 0;
            player1Text.text = player1Score.ToString();

        }
        else if (playerLayer == playerTwoLayer)
        {
            player2Score = 0;
            player2Text.text = player2Score.ToString();
        }
    }

}
