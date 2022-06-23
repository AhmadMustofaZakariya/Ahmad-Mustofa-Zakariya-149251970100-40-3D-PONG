using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int maxBall, spawnInterval;
    public GameObject ball;
    public Vector3[] spawnArea;
    public BallController manager;
    public List<GameObject> ballTamplate;
    private List<GameObject> ballList;
    private float timer;


    private void Start() 
    {
        ballList = new List<GameObject>();
        timer = 0;
    }

    private void Update() 
    {
        timer += Time.deltaTime;
        if(timer > spawnInterval)
        {
            randomSpawn();
            timer -= spawnInterval;
        }
    }
    
    public void randomSpawn()
    {
        if(ballList.Count >= maxBall)
        {
            return;
        }

        int randomIndex = Random.Range(0, ballTamplate.Count);
        GameObject ballPool = Instantiate(ballTamplate[randomIndex],spawnArea[Random.Range(0, spawnArea.Length)],Quaternion.identity);
        ballPool.SetActive(true);
        ballList.Add(ballPool);
    }

    public void removeBall(GameObject ballPool)
    {
        ballList.Remove(ballPool);
        Destroy(ballPool);
    }

}
