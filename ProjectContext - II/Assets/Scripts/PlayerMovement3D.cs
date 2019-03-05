using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{

    private Rigidbody myRigidbody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        //speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    private void FixedUpdate()
    {
        Movement();
    }

    //Movement script DO NOT TOUCH
    void Movement() {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //myRigidbody.transform.position += Movement * speed * Time.deltaTime;
        myRigidbody.MovePosition(transform.position += movement * speed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.A)) {  //Left
        //    myRigidbody.velocity = new Vector3(-speed, 0, 0);
        //}

        //if (Input.GetKey(KeyCode.D)) {  //Right
        //    myRigidbody.velocity = new Vector3(speed, 0, 0);
        //}


        //if (Input.GetKey(KeyCode.W)) {  //Up
        //    myRigidbody.velocity = new Vector3(0, 0, speed);
        //}

        //if (Input.GetKey(KeyCode.S)) {  //Down
        //    myRigidbody.velocity = new Vector3(0, 0, -speed);
        //}
    }


    //Portal script 
    private void OnTriggerEnter(Collider collision)
    {
        //Going trouh Right portal 
        if (collision.gameObject.tag == "Portal1") {
            transform.position = new Vector3(0.9f, 18.4f, 10.16f);
        }

        //Going trouh Left portal 2
        if (collision.gameObject.tag == "Portal2") {
            transform.position = new Vector3(0.81f, 0.63f, 7f);
        }


    }

}
