using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScreen : MonoBehaviour
{
    private Collider myCollider;
    private bool allow;
    private bool On;

    public GameObject Screen;
    public GameObject Press;



    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        On = false;
    }

    // Update is called once per frame
    void Update()
    {
        pros();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player")) {
            Press.SetActive(true);
            pros();
            allow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player")) {
            Screen.SetActive(false);
            Press.SetActive(false);
            allow = false;
        }
    }

    void pros()
    {
        if (allow) {
            if (Input.GetKey(KeyCode.E) && On == true) {
                On = false;
                Screen.SetActive(false);
                Debug.Log("On");
            }
        }
    }
}
