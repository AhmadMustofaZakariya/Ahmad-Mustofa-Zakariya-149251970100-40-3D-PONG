using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scorePlayer1, scorePlayer2, scorePlayer3, scorePlayer4;
    public ScoreManager manager;
    private void Update() 
    {
        scorePlayer1.text = manager.player1Score.ToString();
        scorePlayer2.text = manager.player2Score.ToString();
        scorePlayer3.text = manager.player3Score.ToString();
        scorePlayer4.text = manager.player4Score.ToString();
    }
}
