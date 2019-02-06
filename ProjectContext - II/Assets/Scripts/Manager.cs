using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //The amount of resources you start with
    public float cows;
    public float crops;
    public float energy;
    public float happy;
    public float water;

    //The amount each resource would cost
    public float Cost_Cows;
    public float Cost_Crops;

    //The amount each resource costs
    public float Amount_Cows;
    public float Amount_Crops;
    public float Amount_Energy;
    public float Amount_Happy;

    //How much water you consume depending on the amount 
    public float Water_Consumption;

    private bool CanBuy;

    //Displays the numbers on the screen
    public Text Total_Cows;
    public Text Total_Crops;
    public Text Total_Energy;
    public Text Total_Happy;

    public Text Display_Info_Cows;
    public Text Display_Info_Crops;
    private Text Display_Info_Energy;




    private void Start()
    {
        //cows = 70;
        //crops = 70;
        //energy = 70;
        //happy = 70;

        //Cost_Cows = 30;
        //Cost_Crops = 20;

        Amount_Cows = 10;
        Amount_Crops = 20;

    }

    private void Update()
    {
        //Displays the title and the amount
        Total_Cows.text = "Cows: " + cows.ToString();
        Total_Crops.text = "Crops: " + crops.ToString();
        Total_Energy.text = "Energy: " + energy.ToString();
        Total_Happy.text = "Happy: " + happy.ToString();

        //displays the buy text, depending on this I can change the amount and value of each cow
        Display_Info_Cows.text = "Buy " + Amount_Cows + " cows for " + Cost_Cows + " energy";
        Display_Info_Crops.text = "Buy " + Amount_Crops + " crops for " + Cost_Crops + " energy";

        checkem(energy);
    }


    //The calculations that are done when you press buy
    public void BuyCows()
    {
        if(CanBuy) {
            cows = cows + Amount_Cows;
            energy = energy - Cost_Cows;
        }
    }

    public void BuyCrops()
    {
        if(CanBuy) {
            crops = crops + Amount_Crops;
            energy = energy - Cost_Crops;
        }
    }

    //Checks if you have enough energy to make a purchase
    public void checkem(float myenergy)
    {
        if(myenergy - Cost_Cows >= 0 || myenergy - Cost_Crops >= 0) {
            CanBuy = true;
        }
        else {
            CanBuy = false; 
        }
    }



}
