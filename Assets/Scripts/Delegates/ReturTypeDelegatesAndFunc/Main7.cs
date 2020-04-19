using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main7 : MonoBehaviour
{
    public Action onGetName;
    public Func<string, int> CharacterLengthObject;
    public Func<int, int, int> onSum;
    // Start is called before the first frame update
    void Start()
    {
        onGetName = () => {
            Debug.Log("Name: " + gameObject.name);
            Debug.Log("It's a nice day out!");
        };

        onGetName();

        //////////////////
        // Name GameObject

        CharacterLengthObject = (name) => name.Length;

        Debug.Log("Name Object: " + CharacterLengthObject(gameObject.name));

        ////////////////////
        // Sum 2 values

        onSum = (a, b) => {
            Debug.Log("Whatever i want here");
            return a + b;
        };
        var total = onSum(20, 30);

        Debug.Log("Total: " + total);
    }
}
