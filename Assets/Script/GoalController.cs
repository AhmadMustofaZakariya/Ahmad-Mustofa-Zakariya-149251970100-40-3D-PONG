using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Gawang 1")
        {
            manager.AddPlayer1Score(1);
        } else if(other.gameObject.tag == "Gawang 2"){
            manager.AddPlayer2Score(1);
        } else if(other.gameObject.tag == "Gawang 3"){
            manager.AddPlayer3Score(1);
        } else if(other.gameObject.tag == "Gawang 4"){
            manager.AddPlayer4Score(1);
        }
        return;
    }
}
