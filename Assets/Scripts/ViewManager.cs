using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject Chest;
    public GameObject Shop;
    public GameObject InstructionChest;

    public void ShowChest()
    {
       Shop.SetActive(false); 
       Chest.SetActive(true);
       InstructionChest.SetActive(true);

    }

    public void ShowShop()
    {
        Chest.SetActive(false);
        Shop.SetActive(true);
        InstructionChest.SetActive(false);
    }

}
