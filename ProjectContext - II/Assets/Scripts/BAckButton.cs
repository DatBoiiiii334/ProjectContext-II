using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAckButton : MonoBehaviour
{
    public GameObject screen;
    //private bool Button;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        screen.SetActive(true);
    }

    public void Close()
    {
        screen.SetActive(false);
    }


    //Script for buttons to open and close


    //public void ButtonControl()
    //{
    //    if (Button == false) {
    //        if (Input.GetKeyDown(KeyCode.Escape)) {
    //            screen.SetActive(true);
    //            Button = true;
    //        }
    //    }
    //    else if (Button == true) {
    //        if (Input.GetKeyDown(KeyCode.Escape)) {
    //            screen.SetActive(false);
    //            Button = false;
    //        }
    //    }
    //    else { return; }
    //}
}
