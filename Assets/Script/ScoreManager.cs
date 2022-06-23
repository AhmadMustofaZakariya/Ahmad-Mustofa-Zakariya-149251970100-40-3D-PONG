using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int player1Score, player2Score, player3Score, player4Score;
    public int maxScore;
    public PaddleController paddleManager1,paddleManager2,paddleManager3,paddleManager4;
    public SpawnManager ballManager;
    public BallController ball;
    public GoalManager goalManager;
    public List<GameObject> paddleTamplate;
    
    public void AddPlayer1Score(int increment)
    {
        player1Score += increment;
        if(player1Score == maxScore)
        {
            paddleManager1.inactivePlayer1();
            goalManager.ActivateGoal1();
            paddleTamplate[0].SetActive(false);
            LastPlayer();
        }
    }

    public void AddPlayer2Score(int increment)
    {
        player2Score += increment;
        if(player2Score == maxScore)
        {
            paddleManager2.inactivePlayer2();
            goalManager.ActivateGoal2();
            paddleTamplate[1].SetActive(false);
            LastPlayer();
        }
    }

    public void AddPlayer3Score(int increment)
    {
        player3Score += increment;
        if(player3Score == maxScore)
        {
            paddleManager3.inactivePlayer3();
            goalManager.ActivateGoal3();
            paddleTamplate[2].SetActive(false);
            LastPlayer();
        }
    }

    public void AddPlayer4Score(int increment)
    {
        player4Score += increment;
        if(player4Score == maxScore)
        {
            paddleManager4.inactivePlayer4();
            goalManager.ActivateGoal4();
            paddleTamplate[3].SetActive(false);
            LastPlayer();
        }
    }

    public void LastPlayer()
    {
        int index = 0;
        int totalPlayer = 0;
        for (int i = 0; i < paddleTamplate.Count; i++)
        {
            if(paddleTamplate[i].activeInHierarchy)
            {
                index = i;
                totalPlayer += 1;
            }
        }
        if (totalPlayer == 1)
        {
            Debug.Log("Test Last Player");
            GameData.LastPlayer = "Player" + (index + 1);
            SceneManager.LoadScene("Game Over", LoadSceneMode.Additive);
        }
    }
}
