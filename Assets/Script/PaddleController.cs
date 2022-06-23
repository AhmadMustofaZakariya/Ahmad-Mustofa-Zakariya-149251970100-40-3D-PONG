using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private Rigidbody rig;
    
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();
    }
    private Vector3 GetInput()
    {
        if(Input.GetKey(upKey))
        {
            return rig.velocity = Vector3.forward * speed;
        } else if (Input.GetKey(downKey)){
            return rig.velocity = Vector3.back * speed;
        } else if(Input.GetKey(leftKey)){
            return rig.velocity = Vector3.left * speed;
        } else if (Input.GetKey(rightKey)){
            return rig.velocity = Vector3.right * speed;
        }
        return rig.velocity = Vector3.zero;
    }
    
    public void inactivePlayer1()
    {
        if(gameObject.tag == "Player1")
        {
            gameObject.SetActive(false);
        }
    }

    public void inactivePlayer2()
    {
        if(gameObject.tag == "Player2")
        {
            gameObject.SetActive(false);
        }
    }

    public void inactivePlayer3()
    {
        if(gameObject.tag == "Player3")
        {
            gameObject.SetActive(false);
        }
    }

    public void inactivePlayer4()
    {
        if(gameObject.tag == "Player4")
        {
            gameObject.SetActive(false);
        }
    }
}
