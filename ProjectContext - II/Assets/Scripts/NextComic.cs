using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextComic : MonoBehaviour
{
    public GameObject ImageOne;
    public GameObject ImageTwo;
    public GameObject ImageThree;

    public GameObject Two;
    public GameObject Three;


    public void NextTwo()
    {
        ImageOne.SetActive(false);
        ImageTwo.SetActive(true);
        Two.SetActive(false);
        Three.SetActive(true);
    }

    public void NextThree()
    {
        ImageOne.SetActive(false);
        ImageTwo.SetActive(false);
        ImageThree.SetActive(true);

    }
}
