using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{

    private Rigidbody myRigidbody;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    void Movement() {


        if (Input.GetKey(KeyCode.A)) {
            myRigidbody.velocity = new Vector3(0, 0, -speed);
        }


        if (Input.GetKey(KeyCode.D)) {
            myRigidbody.velocity = new Vector3(0, 0, speed);
        }


        if (Input.GetKey(KeyCode.W)) {
            myRigidbody.velocity = new Vector3(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S)) {
            myRigidbody.velocity = new Vector3(speed, 0, 0);
        }
    }

}
