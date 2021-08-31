using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform ballLocation;
    Vector3 distinction;
    void Start()
    {
        distinction = transform.position - ballLocation.position;
    }


    void Update()
    {
        if (BallMove.isFall == false)
        {
            transform.position = ballLocation.position + distinction;
        }
    }
}
