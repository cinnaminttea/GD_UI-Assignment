using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    public GameObject itemPrefab;
    public string itemName;
    public int itemPrice;
    private GameObject chestParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SpawnInChest()
    {
        chestParent = GameObject.Find("Chest");

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 4), Random.Range(-3, 3), Random.Range(-1, -2));
        Instantiate(itemPrefab, chestParent.transform.position + randomSpawnPosition, transform.rotation);

    }
}
