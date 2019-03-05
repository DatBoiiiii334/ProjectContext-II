using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject Player;
    public Transform target;
	private Vector3 TargetPos;
	public float movespeed;
    public float ZoomSpeed;

    public bool On;


    public float zoomSensitivity = 15.0f;
    public float zoomSpeed = 5.0f;
    public float zoomMin = 5.0f;
    public float zoomMax = 80.0f;

    private float zoom;

    private void Start()
    {
        zoom = GetComponent<Camera>().fieldOfView;
    }

    // Update is called once per frame
    void Update () {
        //Camera smooth follow code
		TargetPos = new Vector3 (Player.transform.position.x , Player.transform.position.y + 10, Player.transform.position.z -10f);
		transform.position = Vector3.Lerp (transform.position,TargetPos,movespeed * Time.deltaTime);

        //Camera Zoomin
        ZoomIn();   //Do this function

        zoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity;
        zoom = Mathf.Clamp(zoom, zoomMin, zoomMax);

    }

    void LateUpdate()
    {
        GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * zoomSpeed);
    }

    void ZoomIn()
    {


        if (Input.GetAxis("Mouse ScrollWheel") > 0) {   //  30f
            //    GetComponent<Camera>().fieldOfView = ZoomSpeed;

            //GetComponent<Transform>().position = new Vector3(transform.position.x + 2f,transform.position.y - ZoomSpeed, transform.position.z);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) {   //  60f
            //GetComponent<Camera>().fieldOfView = ZoomSpeed ;
            
            //GetComponent<Transform>().position = new Vector3(transform.position.x - 2f, transform.position.y + ZoomSpeed, transform.position.z);
        }
        //if (Input.GetAxis("Mouse ScrollWheel") < 0 && On == true) {     //  90f
        //    GetComponent<Camera>().fieldOfView = ZoomSpeed;
        //}
    }
}
