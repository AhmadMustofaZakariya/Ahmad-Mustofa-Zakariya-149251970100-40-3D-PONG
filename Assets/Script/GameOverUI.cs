using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text LastPlayer;
    private void Start() 
    {  
       Debug.Log("Test Game Over UI");
       LastPlayer.text = "Congratulation " + GameData.LastPlayer + " Win"; 
    }
}

public static class GameData
{
    public static string LastPlayer;
}
