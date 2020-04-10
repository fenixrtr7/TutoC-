using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> database = new List<Item>();
    // Dictionary
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    private void Start() {
        Item sword = new Item();
        sword.name = "sword";
        sword.id = 0;

        Item bread = new Item();
        bread.name = "bread";
        bread.id = 1;

        Item cape = new Item();
        cape.name = "cape";
        cape.id = 2;

        database.Add(sword);
        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        //var item = itemDictionary[0];

        // foreach (KeyValuePair<int, Item> item in itemDictionary)
        // {
        //     Debug.Log("Key: " + item.Key);
        //     Debug.Log("Value: " + item.Value.name);
        // }

        // KEYS
        // foreach (var key in itemDictionary.Keys)
        // {
        //     Debug.Log("Key: " + key);
        // }

        foreach (var item in itemDictionary.Values)
        {
            Debug.Log("Item name: " + item.name);
        }

        if (itemDictionary.ContainsKey(60))
        {
            Debug.Log("You found the key!");
            var randomItem = itemDictionary[60];
        }else{
            Debug.Log("the key doesnt exist!");
        }

        if (itemDictionary.ContainsKey(1))
        {
            Debug.Log("You found the key!");
            var randomItem = itemDictionary[1];
        }else{
            Debug.Log("the key doesnt exist!");
        }
    }
}
