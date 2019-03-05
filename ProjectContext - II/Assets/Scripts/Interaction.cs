using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private bool On;
    private bool myButton;

    //Place the displays you wish to view when tapping E
    public GameObject MyDisplay;
    public GameObject InteractButton;
    

    private void Update()
    {
        if (On) {   //Checks if you are in the trigger of the gameobject
            if (myButton == false) {   //Checks if your havent pressed the action button yet, if you havent then it will open your display
                if (Input.GetKeyDown(KeyCode.E)) {

                    MyDisplay.SetActive(true);
                    myButton = true;
                }
            }else if (myButton == true) {   //If you press the action button again it will close the display because it knows its already been opent
                if (Input.GetKeyDown(KeyCode.E)) {
                    MyDisplay.SetActive(false);
                    myButton = false;
                }
            }
        }
        else { return; }
    }

    //Checks if you are in the triggerbox of a panel
    void OnTriggerEnter(Collider other)
    {
        InteractButton.SetActive(true);
        if (other.tag == ("Player")) {
            On = true;  //If you are in the triggerbox then you are allowed to interact with the action button
            
        }
    }

    //Check if you have exited a panel
    private void OnTriggerExit(Collider other)
    {
        InteractButton.SetActive(false);
        On = false;     //If you leave the triggerbox you are no longer allowed to interact with the action button and it will close all windows automatically
        MyDisplay.SetActive(false);
        myButton = false;
    }
}
