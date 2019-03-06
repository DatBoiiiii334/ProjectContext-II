using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantManager : MonoBehaviour
{
    //Amount for each plants
    public float Plant_A_Amount = 0f;
    public float Plant_B_Amount = 0f;
    public float Plant_C_Amount = 0f;
    public float Plant_D_Amount = 0f;

    public Text TitlePlant;
    public Text PlantText;

    //Text for each plant
    public Text PlantA_Text;
    public Text PlantB_Text;
    public Text PlantC_Text;
    public Text PlantD_Text;

    //List for each plant
    public GameObject PlantA_List;
    public GameObject PlantB_List;
    public GameObject PlantC_List;
    public GameObject PlantD_List;

    //Can be triggerd to repaired
    private bool Broken;

    //Your buttons
    private bool ButtonA;
    private bool ButtonB;
    private bool ButtonC;
    private bool ButtonD;

    public Manager _Manager;
    private float jigga =100;


    public void Start()
    {
        _Manager = gameObject.GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        PlantA_Text.text = "Amount: " + Plant_A_Amount;
        PlantB_Text.text = "Amount: " + Plant_B_Amount;
        PlantC_Text.text = "Amount: " + Plant_C_Amount;
        PlantD_Text.text = "Amount: " + Plant_D_Amount;  
    }

    public void Plant()
    {
        if (ButtonA) {
            Plant_A_Amount = Plant_A_Amount + 1;
            //_Manager.PlantA_Cost(jigga);
            _Manager.energy = _Manager.energy - 10f;
            _Manager.energy = _Manager.water - 10f;

        }
        if (ButtonB) {
            Plant_B_Amount = Plant_B_Amount + 1;
            _Manager.energy = _Manager.energy - 20f;
            _Manager.energy = _Manager.water - 20f;
        }
        if (ButtonC) {
            Plant_C_Amount = Plant_C_Amount + 1;
            _Manager.energy = _Manager.energy - 30f;
            _Manager.energy = _Manager.water - 30f;
        }

        if (ButtonD) {
            Plant_D_Amount = Plant_D_Amount + 1;
            _Manager.energy = _Manager.energy - 40f;
            _Manager.energy = _Manager.water - 40f;
        }
    }

    public void Destroy()
    {
        if (ButtonA) {
            if(Plant_A_Amount > 0) {
                Plant_A_Amount = Plant_A_Amount - 1;
            }
        }
        if (ButtonB) {
            if (Plant_B_Amount > 0) {
                Plant_B_Amount = Plant_B_Amount - 1;
            }
        }
        if (ButtonC) {
            if (Plant_C_Amount > 0) {
                Plant_C_Amount = Plant_C_Amount - 1;
            }
        }
        if (ButtonD) {
            if (Plant_D_Amount > 0) {
                Plant_D_Amount = Plant_D_Amount - 1;
            }
        }
    }



    public void ThePlantA()
    {
        ButtonA = true;
        ButtonB = false;
        ButtonC = false;
        ButtonD = false;
        PlantA_List.SetActive(true);
        TitlePlant.text = ("Plant A");
        PlantText.text = ("Normally, both your asses would be dead as fucking fried chicken, but you happen to pull this shit while I'm in a transitional period so I don't wanna kill you, I wanna help you. But I can't give you this case, it don't belong to me. Besides, I've already been through too much shit this morning over this case to hand it over to your dumb ass.");
        PlantB_List.SetActive(false);
        PlantC_List.SetActive(false);
        PlantD_List.SetActive(false);
        return;
    }

    public void ThePlantB()
    {
        ButtonB = true;
        ButtonC = false;
        ButtonD = false;
        ButtonA = false;
        PlantB_List.SetActive(true);
        TitlePlant.text = ("Plant B");
        PlantText.text = ("My money's in that office, right? If she start giving me some bullshit about it ain't there, and we got to go someplace else and get it, I'm gonna shoot you in the head then and there. Then I'm gonna shoot that bitch in the kneecaps, find out where my goddamn money is. She gonna tell me too. Hey, look at me when I'm talking to you, motherfucker. You listen: we go in there, and that nigga Winston or anybody else is in there, you the first motherfucker to get shot. You understand?");
        PlantC_List.SetActive(false);
        PlantD_List.SetActive(false);
        PlantA_List.SetActive(false);
        return;
    }

    public void ThePlantC()
    {
        ButtonC = true;
        ButtonD = false;
        ButtonA = false;
        ButtonB = false;
        PlantC_List.SetActive(true);
        TitlePlant.text = ("Plant C");
        PlantText.text = ("Do you see any Teletubbies in here? Do you see a slender plastic tag clipped to my shirt with my name printed on it? Do you see a little Asian child with a blank expression on his face sitting outside on a mechanical helicopter that shakes when you put quarters in it? No? Well, that's what you see at a toy store. And you must think you're in a toy store, because you're here shopping for an infant named Jeb.");
        PlantD_List.SetActive(false);
        PlantA_List.SetActive(false);
        PlantB_List.SetActive(false);
        return;
    }

    public void ThePlantD()
    {
        ButtonD = true;
        ButtonA = false;
        ButtonB = false;
        ButtonC = false;
        PlantD_List.SetActive(true);
        TitlePlant.text = ("Plant D");
        PlantText.text = ("Well, the way they make shows is, they make one show. That show's called a pilot. Then they show that show to the people who make shows, and on the strength of that one show they decide if they're going to make more shows. Some pilots get picked and become television programs. Some don't, become nothing. She starred in one of the ones that became nothing.");
        PlantA_List.SetActive(false);
        PlantB_List.SetActive(false);
        PlantC_List.SetActive(false);
        return;
    }

    public void Repair()
    {
        if (Broken) {
            Broken = false;
            return;
        }
    }
}
