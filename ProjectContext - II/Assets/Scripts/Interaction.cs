using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject MeatScreen;
    public GameObject WheatScreen;
    public GameObject PanelScreen;
    public GameObject WaterScreen;
    public GameObject Interactable;

    private bool meatOn;
    private bool wheatOn;
    private bool panelOn;
    private bool waterOn;

    //Checks if you are in a panel
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Meat")) {
            Interactable.SetActive(true);
            meatOn = true;
        }

        if (other.tag == ("Wheat")) {
            Interactable.SetActive(true);
            wheatOn = true;
        }

        if (other.tag == ("Panel")) {
            Interactable.SetActive(true);
            panelOn = true;
        }

        if(other.tag == ("Water")) {
            Interactable.SetActive(true);
            waterOn = true;
        }
    }

    //Check if you have exited a panel
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Meat")) {
            Interactable.SetActive(false);
            MeatScreen.SetActive(false);
            meatOn = false;
        }

        if (other.tag == ("Wheat")) {
            Interactable.SetActive(false);
            WheatScreen.SetActive(false);
            wheatOn = false;
        }

        if (other.tag == ("Panel")) {
            Interactable.SetActive(false);
            PanelScreen.SetActive(false);
            panelOn = false;
        }

        if (other.tag == ("Water")) {
            Interactable.SetActive(false);
            WaterScreen.SetActive(false);
            waterOn = false;
        }
    }

    //Lets you open the screen of each resource menu
    private void Update()
    {
        if (meatOn) {
            if (Input.GetKey(KeyCode.E)) {
                MeatScreen.SetActive(true);
            }
        }

        if (wheatOn) {
            if (Input.GetKey(KeyCode.E)) {
                WheatScreen.SetActive(true);
            }
        }

        if (panelOn) {
            if (Input.GetKey(KeyCode.E)) {
                PanelScreen.SetActive(true);
            }
        }

        if (waterOn) {
            if (Input.GetKey(KeyCode.E)) {
                WaterScreen.SetActive(true);
            }
        }
    }

}
