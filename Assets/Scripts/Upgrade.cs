using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrade : MonoBehaviour
{
  
    public TMP_Text itemAmount;
    public int _ItemAmount = 2;

    public TMP_Text moneyText;
    private int money;

    public GameObject SlotFive;
    public GameObject SlotSix;
    public GameObject SlotSeven;
    public GameObject SlotEight;
    public GameObject SlotNine;
    public GameObject SlotTen;
    public GameObject SlotEleven;
    public GameObject SlotTwelve;
    public GameObject upgradeOne;
    public GameObject upgradeTwo;

    void Update()
    {
        itemAmount.text = "Amount:" + _ItemAmount.ToString();
        moneyText.text = "$" + money.ToString();
    }

    public void FirstUpgrade()
    {
        Debug.Log("click");

        money -= 20;
        _ItemAmount -= 1;

        SlotFive.SetActive(true);
        SlotSix.SetActive(true);
        SlotSeven.SetActive(true);
        SlotEight.SetActive(true);

        upgradeOne.SetActive(false); 
        upgradeTwo.SetActive(true);
    }

    public void SecondUpgrade()
    {
        Debug.Log("click");

        money -= 20;
        _ItemAmount -= 1;

        upgradeOne.SetActive(false);
        upgradeTwo.SetActive(false);

        SlotNine.SetActive(true);
        SlotTen.SetActive(true);
        SlotEleven.SetActive(true);
        SlotTwelve.SetActive(true);
    }

}
