using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 direction;
    public float velocity;
    public GroundSpawner groundSpawner;
    public static bool isFall;
    public float addVelocity;
    void Start()
    {
        direction = Vector3.forward;
        isFall = false;
    }

 
    void Update()
    {
        if (transform.position.y <= 0.5f)
        {
            isFall = true;
        }

        if (isFall == true)
        {
            Debug.Log("Düþtü");
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            velocity = velocity + addVelocity * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 move = direction * Time.deltaTime * velocity;
        transform.position += move;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            groundSpawner.groundSpawner();
            StartCoroutine(deleteGround(collision.gameObject));
        }
    }

    IEnumerator deleteGround(GameObject DeleteGround)
    {
        yield return new WaitForSeconds(3f);
        Destroy(DeleteGround);
    }

}
