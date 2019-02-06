using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScreen : MonoBehaviour
{
    private Collider myCollider;
    public bool allow;

    public GameObject Screen;
    public GameObject Press;



    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player")) {
            Press.SetActive(true);
            allow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player")) {
            Press.SetActive(false);
            allow = false;
        }
    }

}
