using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject Chest;
    public GameObject Shop;

    public void ShowChest()
    {
       Shop.SetActive(false); 
       Chest.SetActive(true);
    }

    public void ShowShop()
    {
        Chest.SetActive(false);
        Shop.SetActive(true);
    }

}
