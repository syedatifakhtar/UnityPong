using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_input_controller : MonoBehaviour
{
    public GameObject leftBat;
    public GameObject rightBat;
    public GameObject ball;


    float batSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        if (Input.GetKey(KeyCode.W))
        {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, batSpeed, 0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -batSpeed, 0f);
        }
        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, batSpeed, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -batSpeed, 0f);
        }

    }
}
