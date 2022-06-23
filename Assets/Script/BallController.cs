using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody rig;
    public Collider ball;
    public Vector3[] spawnArea;
    public Collider Gawang1,Gawang2, Gawang3, Gawang4;
    public SpawnManager manager;
    public int maxSpeed;
    
    private void Start() 
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
        if (ball.transform.position == spawnArea[0])
        {
            ball.GetComponent<Rigidbody>().velocity = new Vector3 (Random.Range(-12f,-5f),0,Random.Range(-12f,-5f));
            Debug.Log("Test");
        } else if(ball.transform.position == spawnArea[1]){
            ball.GetComponent<Rigidbody>().velocity = new Vector3 (Random.Range(-12f,-5f),0,Random.Range(5f,12f));
            Debug.Log("Test");
        } else if(ball.transform.position == spawnArea[2]){
            ball.GetComponent<Rigidbody>().velocity = new Vector3 (Random.Range(5f,12f),0,Random.Range(5f,12f));
            Debug.Log("Test");
        } else if(ball.transform.position == spawnArea[3]){
            ball.GetComponent<Rigidbody>().velocity = new Vector3 (Random.Range(5f,12f),0,Random.Range(-12f,-5f));
            Debug.Log("Test");
        }
        return;
    }
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x , resetPosition.y , resetPosition.z);
    }

    private void OnCollisionEnter(Collision other) 
    {
         if(other.gameObject.tag == "Player1"||
           other.gameObject.tag == "Player2"||
           other.gameObject.tag == "Player3"||
           other.gameObject.tag == "Player4"||
           other.gameObject.tag == "SpawnBall"||
           other.gameObject.tag == "Gawang 1"||
           other.gameObject.tag == "Gawang 2"||
           other.gameObject.tag == "Gawang 3"||
           other.gameObject.tag == "Gawang 4")
           {
            if(rig.velocity.magnitude < maxSpeed)
            {
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
           }          
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other == Gawang1)
        {
            manager.removeBall(gameObject);
        }
        if(other == Gawang2)
        {
            manager.removeBall(gameObject);
        }
        if(other == Gawang3)
        {
            manager.removeBall(gameObject);
        }
        if(other == Gawang4)
        {
            manager.removeBall(gameObject);
        }
    }

    
}
