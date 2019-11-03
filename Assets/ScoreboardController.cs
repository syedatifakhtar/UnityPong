using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreboardController : MonoBehaviour
{

    public static ScoreboardController instance;
    public Text player1Text;
    public Text player2Text;

    private int player1Score;
    private int player2Score;
    void Start()
    {
        player1Score = player2Score = 0;
        instance = this;
    }

    public void updatePlayer1Score()
    {
        if(player1Score > 3)
        {
            SceneManager.LoadScene(2);
        }
        player1Score++;
        player1Text.text = player1Score.ToString();
    }

    public void updatePlayer2Score()
    {
        if (player2Score > 3) { 
            SceneManager.LoadScene(3);
        }
        player2Score++;
        player2Text.text = player2Score.ToString();
    }

    void Update()
    {
        
    }
}
