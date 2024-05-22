using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemMove : MonoBehaviour
{
    private ChestController Chest;
    private BackpackController inventory;
    public GameObject item;
    public string itemName;

    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<BackpackController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == true && inventory.slots[i].transform.GetComponent<SlotScript>().amount < 2)
                {
                    //stack items
                    if (itemName == inventory.slots[i].transform.GetComponentInChildren<Spawn>().itemName)
                    {
                        Destroy(gameObject);
                        inventory.slots[i].GetComponent<SlotScript>().amount += 1;
                        break;
                    }
                    else if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(item, inventory.slots[i].transform, false);
                        inventory.slots[i].GetComponent<SlotScript>().amount += 1;
                        Destroy(gameObject);
                        break;
                    }
                }
            }
        }
    }
}
