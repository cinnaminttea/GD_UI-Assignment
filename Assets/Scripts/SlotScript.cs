using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlotScript : MonoBehaviour
{
    private BackpackController inventory;
    public int i;
    public TMP_Text amountText;
    public int amount;
    public TMP_Text ItemName;


    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<BackpackController>();
    }

    // Update is called once per frame
    void Update()
    {
        amountText.text = amount.ToString();

        if(amount > 1)
        {
            transform.GetChild(0).GetComponent<TMP_Text>().enabled = true;
        }
        else
        {
            transform.GetChild(0).GetComponent<TMP_Text>().enabled = false;
        }

        if(transform.childCount == 2)
        {
            inventory.isFull[i] = false;
        }
    }

    public void MoveItemToChest()
    {
        if (amount > 1)
        {
            amount -= 1;
            transform.GetComponentInChildren<Spawn>().SpawnInChest();
        }
        else
        {
            amount -= 1;
            GameObject.Destroy(transform.GetComponentInChildren<Spawn>().gameObject);
            transform.GetComponentInChildren<Spawn>().SpawnInChest();
        }
    }
}
