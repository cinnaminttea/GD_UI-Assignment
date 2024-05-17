using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSlot : MonoBehaviour
{
    private BackpackController inventory;
    public Image itemImage;
    public TMP_Text itemName;
    public TMP_Text itemPrice;
    public TMP_Text itemAmount;

    public GameObject itemToBuy;
    public int _ItemAmount;
    public TMP_Text buyPriceText;
    public TMP_Text moneyText;
    public int money;


    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<BackpackController>();
        itemName.text = itemToBuy.GetComponent<Spawn>().itemName;
        itemImage.sprite = itemToBuy.GetComponent<SpriteRenderer>().sprite;
        buyPriceText.text = itemToBuy.GetComponentInChildren<Spawn>().itemPrice + "Dollars";
    }

    // Update is called once per frame
    void Update()
    {
        itemAmount.text = "Amount:" + _ItemAmount.ToString();
    }

    public void Buy()
    {
        for(int i  = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == true && inventory.slots[i].transform.GetComponent<SlotScript>().amount < 20 && money >= itemToBuy.GetComponentInChildren<Spawn>().itemPrice && _ItemAmount > 0)
            {
                if(itemName.text == inventory.slots[i].transform.GetComponentInChildren<Spawn>().itemName)
                {
                    _ItemAmount -= 1;
                    inventory.slots[i].GetComponent<SlotScript>().amount += 1;
                    money -= itemToBuy.GetComponentInChildren<Spawn>().itemPrice;
                    break;
                }
            }
            else if (inventory.isFull[i] == false && money >= itemToBuy.GetComponentInChildren<Spawn>().itemPrice && _ItemAmount > 0)
            {
                _ItemAmount += 1;
                //inventory.slots[i].GetComponent<SlotScript>().ItemName.text = itemName.text;
                inventory.isFull[i] = true;
                Instantiate(itemToBuy, inventory.slots[i].transform, false);
                inventory.slots[i].GetComponent<SlotScript>().amount += 1;
                break;
            }
        }
        
    }

    public void Sell()
    {

    }
}