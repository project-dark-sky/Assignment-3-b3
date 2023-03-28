using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int player1Score;
    public int player2Score;
    public Text player1Text;
    public Text player2Text;

    [ContextMenu("Increase Score")]   //to run this function from unity it self
    public void addScore(int scoreToadd,int playerLayer)
    {
        if(playerLayer == 3) {
            player1Score += scoreToadd;
            player1Text.text = player1Score.ToString();

        }else if(playerLayer == 6) {
            player2Score += scoreToadd;
            player2Text.text = player2Score.ToString();
        }
    }

    [ContextMenu("Player Reset")]   
    public void playerReset(int playerLayer)
    {

        if (playerLayer == 3)
        {
            player1Score = 0;
            player1Text.text = player1Score.ToString();

        }
        else if (playerLayer == 6)
        {
            player2Score = 0;
            player2Text.text = player2Score.ToString();
        }
    }

}
