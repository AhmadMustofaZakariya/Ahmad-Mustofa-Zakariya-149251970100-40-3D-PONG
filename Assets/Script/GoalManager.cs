using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public GameObject Gawang1, Gawang2, Gawang3, Gawang4;
    
    
    public void ActivateGoal1()
    {
        Gawang1.GetComponent<MeshRenderer>().enabled = true;
        Gawang1.GetComponent<Collider>().isTrigger = false;    
    }

    public void ActivateGoal2()
    {
        Gawang2.GetComponent<MeshRenderer>().enabled = true;
        Gawang2.GetComponent<Collider>().isTrigger = false;    
    }

    public void ActivateGoal3()
    {
        Gawang3.GetComponent<MeshRenderer>().enabled = true;
        Gawang3.GetComponent<Collider>().isTrigger = false;    
    }

    public void ActivateGoal4()
    {
        Gawang4.GetComponent<MeshRenderer>().enabled = true;
        Gawang4.GetComponent<Collider>().isTrigger = false;    
    }
}
