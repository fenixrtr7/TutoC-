using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class ItemChallenge
{
    public string name;
    public int itemID;
    public int buff;
}

public class ChallengeLinq : MonoBehaviour
{
    public List<ItemChallenge> items;
    // Start is called before the first frame update
    void Start()
    {
        var existItem3 = items.Any(item => item.itemID == 3);
        Debug.Log("Result exist itemID 3: " + existItem3);

        ////////////////
        Debug.Log("Buff more 20");

        var result = items.Where( item => item.buff > 20);//.OrderByDescending(g => g).Reverse();
        foreach (var num in result)
        {
           Debug.Log("Item: " + num.name + "Item buff: " + num.buff); 
        }

        ///////////////////

        var avergae = items.Average(item => item.buff);
        Debug.Log("Avergae: " + avergae);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
