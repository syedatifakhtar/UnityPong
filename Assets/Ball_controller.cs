using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball_controller : MonoBehaviour
{


    Rigidbody ballRB;
    float ballSpeed = 20f;
    float cameraBounds = 45f;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        StartCoroutine(LaunchBall());

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -cameraBounds)
        {

            ScoreboardController.instance.updatePlayer2Score();
            ballRB.velocity = Vector3.zero;
            StartCoroutine(LaunchBall());
        }
        if (transform.position.x > cameraBounds)
        {
            ScoreboardController.instance.updatePlayer1Score();
            ballRB.velocity = Vector3.zero;
            StartCoroutine(LaunchBall());
        }
    }

    IEnumerator LaunchBall()
    {
        Debug.Log("Launch Ball called!");
        Debug.Log(" Transform Position: " + transform.position);
        transform.position = new Vector3(0, 0, 1.0f);
        yield return new WaitForSeconds(2.5f);
        Vector3 launchDirection = new Vector3();
        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 3);
        if (xDirection == 0)
        {
            launchDirection.x = -ballSpeed;
        }
        else
        {
            launchDirection.x = ballSpeed;
        }
        if (yDirection == 0)
        {
            launchDirection.y = 0;
        }
        else if (yDirection == 1)
        {
            launchDirection.y = -ballSpeed;
        }
        else
        {
            launchDirection.y = ballSpeed;
        }


        ballRB.velocity = launchDirection;

    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject gameObject = collision.gameObject;
        Vector3 velocity = Vector3.zero;
        if (gameObject.name.Equals("TopBound"))
        {
            Debug.Log("Ball hit TopBound");
            velocity = new Vector3(ballRB.velocity.x, -ballSpeed, 0);
        }
        else if (gameObject.name.Equals("BottomBound"))
        {
            Debug.Log("Ball hit BottomBound");
            velocity = new Vector3(ballRB.velocity.x, ballSpeed, 0);
        }
        else if (gameObject.name.Equals("LeftBat"))
        {
            Debug.Log("Hit position with difference: " + (ballRB.transform.position.y - gameObject.transform.position.y));
            if (ballRB.transform.position.y - gameObject.transform.position.y > 2.0f)
            {

                velocity = new Vector3(ballSpeed, ballSpeed, 0);
            }
            else if (ballRB.transform.position.y - gameObject.transform.position.y < -2.0f)
            {
                velocity = new Vector3(ballSpeed, -ballSpeed, 0);
            }
            else
            {
                velocity = new Vector3(ballSpeed, 0, 0);
            }
            Debug.Log("Ball hit LeftBat");
        }
        else if (gameObject.name.Equals("RightBat"))
        {
            Debug.Log("Hit position with difference: " + (ballRB.transform.position.y - gameObject.transform.position.y));
            if (ballRB.transform.position.y - gameObject.transform.position.y > 2.0f)
            {
                velocity = new Vector3(-ballSpeed, ballSpeed, 0);
            }
            else if (ballRB.transform.position.y - gameObject.transform.position.y < -2.0f)
            {
                velocity = new Vector3(-ballSpeed, -ballSpeed, 0);
            }
            else
            {
                velocity = new Vector3(-ballSpeed, 0, 0);
            }
            Debug.Log("Ball hit LeftBat");
        }
        Debug.Log("The ball hit: " + collision.gameObject.name + " and olde velocity was : " +ballRB.velocity +   " ;and new velocity is: " + velocity.ToString());
        ballRB.velocity = velocity;
        
    }
}
