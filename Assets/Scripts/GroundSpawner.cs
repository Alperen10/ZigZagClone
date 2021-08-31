using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject endGround;
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            groundSpawner();
           
        }
    }
    
    public void groundSpawner()
    {
        Vector3 direction;
        if (Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        endGround = Instantiate(endGround, endGround.transform.position + direction, endGround.transform.rotation);

    }
}
