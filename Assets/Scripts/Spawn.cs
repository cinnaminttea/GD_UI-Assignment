using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    public GameObject itemPrefab;
    public string itemName;
    public int itemPrice;
    private ChestController chest;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void SpawnInChest()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(-9, -1), Random.Range(-2, 4));
        Instantiate(itemPrefab, randomSpawnPosition, transform.rotation);
    }
}
