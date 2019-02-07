using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private int Amount_Months = 1;

    //Your total amount of resources
    public float cows;
    public float crops;
    public float energy;
    public float happy;
    public float water;

    public float co;
    public float TotalCo;

    //The amount of energy each resource would cost
    public float Energy_Cost_Cow; //for example 10 energy is the cost of 1 cow
    public float Water_Cost_Cow;

    public float Energy_Cost_Crops;
    public float Water_Cost_Crops;
    public float Cost_Water;
    public float Energy_Cost_Water; // The cost of energy is in water

    private float Energy_From_Cows;
    private float Energy_From_Crops;
    private float CO_From_Cows;
    private float CO_From_Crops;
    private float Happyness_From_Cows;
    private float Happyness_From_Crops;

    public float Energy_Per_Cow;
    public float Energy_Per_Crop;
    public float CO_Per_Cows;
    public float Happyness_Per_Cows;
    public float Happyness_Per_Crops;
    public float CO_Per_Crops;

    private float TotalEnergyGained;
    private float TotalCoGained;
    private float TotalHappynessGained;

    private bool lostGame;

    private bool CanBuy;
    private bool CanBuy2;

    private bool FirstEvent_OptionOne;
    private bool FirstEvent_OptionTwo;

    //The amount each resource costs
    public float Amount_Purchased_Cows;
    public float Amount_Purchased_Crops;

    //The amount each resource is consumed
    public float Amount_Purchased_Water;
    public float Amount_Water;
    public float Energy_Gained;

    //How much water you consume depending on the amount 
    public float Water_Consumption;

    

    //Displays the numbers on the screen
    public Text Total_Cows;
    public Text Total_Crops;
    public Text Total_Energy;
    public Text Total_Happy;
    public Text Total_Water;
    public Text Total_CO;

    public Text Display_Info_Cows;
    public Text Display_Info_Crops;
    public Text Display_Info_Water;
    private Text Display_Info_Energy;

    //Displays 
    public Text Display_Total_Energy;
    public Text Display_Total_Water;
    public Text Display_Gained_Energy;

    public Text Display_Days;

    public GameObject SchipPanel;
    public GameObject LoseScreen;
    public GameObject WinScreen;
    public GameObject FirstEvent;

    public Text Event1Intro;
    public Text Event1Text;

    //Everrything gained from resources
    public Text DisplayMonthlyResources;
    //public Text DisplayMonthlyEnergyGainedCows;
    //public Text DisplayMonthlyEnergyGainedCrops;
    //public Text DisplayMonthlyCoGainedCows;
    //public Text DisplayMonthlyCoGainedCrops;
    //public Text DisplayMonthlyHappynessGainedCows;
    //public Text DisplayMonthlyHappynessGainedCrops;


    private void Start()
    {
        //cows = 70;
        //crops = 70;
        //energy = 70;
        //happy = 70;

        //Cost_Cows = 30;
        //Cost_Crops = 20;

        //Amount_Purchased_Cows = 1;
        //Amount_Purchased_Crops = 2;

    }

    private void Update()
    {
        //Displays the title and the amount
        Total_Cows.text = "Cows: " + cows.ToString();
        Total_Crops.text = "Crops: " + crops.ToString();
        Total_Energy.text = "Energy: " + energy.ToString();
        Total_Happy.text = "Happy: " + happy.ToString();
        Total_Water.text = "Water: " + water.ToString();
        Total_CO.text = "Co2: " + TotalCoGained.ToString();

        //displays the buy text, depending on this I can change the amount and value of each cow
        Display_Info_Cows.text = "Buy " + Amount_Purchased_Cows + " cows for " + Energy_Cost_Cow + " energy and " + Water_Cost_Cow + " water";
        Display_Info_Crops.text = "Buy " + Amount_Purchased_Crops + " crops for " + Energy_Cost_Crops + " energy and " + Water_Cost_Crops + "water";
        Display_Info_Water.text = "Buy " + Amount_Purchased_Water + " water for "+ Energy_Cost_Water + " energy";

        DisplayMonthlyResources.text =" Energy gained from cows " + Energy_From_Cows + 
            " Energy gained from crops " + Energy_Cost_Crops + 
            " Co2 gained from cows: " + CO_From_Cows + "Co2 negated by crops: " + 
            CO_From_Crops + " Happyness gained from cows: " + 
            Happyness_From_Cows + " Happyness gained from crops: " + Happyness_From_Crops;

        Display_Total_Energy.text = "Total energy gained: " + TotalEnergyGained;
        Display_Total_Water.text = "Total co2 gained: " + TotalCoGained;
        Display_Gained_Energy.text = "Total Happyness gained: " + TotalHappynessGained;
        Display_Days.text = "Month " + Amount_Months;



        checkem(energy,water);
        checkAgain(water);
        CalculateCo(co, cows, crops);
        CalculateTotals();
        EventManager();
    
     }

    public void EventManager()
    {
        if(lostGame == false) {
            Event1Intro.text = "You arrived at an unfamiliar planet. Interested in what the new place has to offer, you talk with the inhabitants. They are of an species you have never encountered before, but they seem friendly. Only problem is… You don’t speak a single word of their language. With great effort and the use of hand signs you try to start up a conversation. About half an hour later, you still have no clue what they’re talking about. The only term you think you have understood correctly is “CO2”. They seem to do you a proposition. Will you agree to their unknown terms or end the negotiation? ";
            if (FirstEvent_OptionOne) {
                Event1Text.text = "You shake your head, meaning to decline their proposal. It’s too risky to agree to anything that you don’t understand the fine details off. To your surprise, the aliens do the opposite. A bunch of them hurry towards your spaceship and enter. Confused, you yell after them, but they don’t seem to respond. After the Aliens are done and leave the ship, they are carrying multiple capsules with your crops. The head of the alien tribe hands you a green gem as a small token of their gratitude. Later you find out that shaking your head in their language means means you consent. The damage is great and because of the sudden decrease in crops, your CO2 value grows with 25";
                TotalCo = TotalCo + 20;
            }

            if (FirstEvent_OptionTwo) {
                if (happy <= 50) {
                    Event1Text.text = "Convinced about their good intentions, you agree to their proposal. You follow a couple of aliens to your ship, where they start to improve on your crop building system. They enhance your technology by switching out some parts for better ones and optimise the conditions in the crop capsules. Unfortunately, your crew panics as soon as one of them sport the aliens on board.Under the assumption the aliens are up to something bad, your crew starts a riot and chaos ensues.They chase every last of the aliens off the ship and throw out the new equipment after them, before you’re forced to take off.Because of the loss of some of your highly valued crop capsules, less CO2 gets processed and the value rises with 10.";
                    TotalCo = TotalCo + 10;
                }
                else if (happy > 50) {
                    Event1Text.text = "Convinced about their good intentions, you agree to their proposal. You follow a couple of aliens to your ship, where they start to improve on your crop building system. They enhance your technology by switching out some parts for better ones and optimise the conditions in the crop capsules. Your crew trusts that you made the right decision and watches intently as the aliens work in the biological crop capsules. The deal turns out great and more CO2 gets processed, causing the value to drop with 15.";
                    TotalCo = TotalCo - 15;
                }
            }
        }
        
    }

    public void firstEvent_OptionOne()
    {
        FirstEvent_OptionOne = true;
    }

    public void firstEvent_OptionTwo()
    {
        FirstEvent_OptionTwo = true;
    }

    //The calculations that are done when you press buy
    public void BuyCows()
    {
        if(CanBuy) {
            cows = cows + Amount_Purchased_Cows;
            energy = energy - Energy_Cost_Cow;
            water = water - Water_Cost_Cow;
        }
    }

    public void BuyCrops()
    {
        if(CanBuy) {
            crops = crops + Amount_Purchased_Crops;
            energy = energy - Energy_Cost_Crops;
            water = water - Water_Cost_Crops;
        }
    }

    public void BuyWater()
    {
        if (CanBuy2) {
            energy = energy - Energy_Cost_Water;
            water = water + Amount_Purchased_Water;
        }
    }

    public void NextDay()
    {
        //SchipPanel.SetActive(true);
        Amount_Months = Amount_Months + 1;
        FirstEvent.SetActive(true);
        //ConsumeWater(cows, crops);
    }

    public void CalculateTotals()
    {
        Energy_From_Cows = cows * Energy_Per_Cow;
        Energy_From_Crops = crops * Energy_Per_Crop;
        
        CO_From_Cows = cows * CO_Per_Cows;
        CO_From_Crops = crops * CO_Per_Crops;
        
        Happyness_From_Cows = cows * Happyness_Per_Cows;
        Happyness_From_Crops = crops * Happyness_Per_Crops;

        TotalEnergyGained = Energy_From_Cows + Energy_From_Crops;
        TotalCoGained = CO_From_Cows + CO_From_Crops;
        TotalHappynessGained = Happyness_From_Cows + Happyness_From_Crops;
    }

    public void Next()
    {
        SchipPanel.SetActive(false);
        energy = energy + Energy_Gained;
        WinLoseCondition();
    }

    public void CalculateCo(float myCO, float myCows, float myCrops)
    {
        myCows = myCows / 100 * 10;
        myCrops = myCrops / 100 * 10;
        TotalCo = myCrops + myCows + myCO;
    }

    public void WinLoseCondition()
    {
        if(water <= 0 || energy <= 0 || happy <= 0 || TotalCoGained >=200) {
            lostGame = true;
            LoseScreen.SetActive(true);
        }

        if (Amount_Months >= 3) {
            WinScreen.SetActive(true);
        }
    }



    //Checks if you have enough energy to make a purchase
    public void checkem(float myenergy, float mywater)
    {
        if(myenergy - Energy_Cost_Cow >= 0 || myenergy - Energy_Cost_Crops >= 0 && mywater - Water_Cost_Cow >= 0 || mywater - Water_Cost_Crops >= 0) {
            CanBuy = true;
        }
        else {
            CanBuy = false; 
        }
    }

    public void checkAgain(float mywater)
    {
        if(mywater - Energy_Cost_Water >= 0) {
            CanBuy2 = true;
        }
        else {
            CanBuy2 = false;
        }
    }

    public void ConsumeWater(float myCows, float myCrops)
    {
        Amount_Water = myCows / 100 * 10;
        Amount_Purchased_Water = myCrops / 100 * 10;
        Energy_Gained = Energy_Gained + myCrops + myCows;
    }


}
