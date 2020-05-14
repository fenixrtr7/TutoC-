using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main6 : MonoBehaviour
{
    //public delegate int CharacterLenght(string text);
    //CharacterLenght cl;
    public Func<string, int> CharacterLength;
    public Func<int, int, int> SumTwoValues;
    public Action<int, int> Sum;

    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log(cl("Jon"));
        //////////////////////////////////
        // TOTAL character length
        //////////

        CharacterLength = (name) => name.Length;

        int count = CharacterLength("Jonathan");

        Debug.Log("Count: " + count);
        //////////////////////////////////////////
        // My sum TOTAL a + b
        //////////////

        SumTwoValues = (value1, value2) => value1 + value2;

        int totalValue = SumTwoValues(5, 6);

        Debug.Log("Total: " + totalValue);

        /////////////////
        // Exercise sum Total
        ////////

        Sum = (a, b) =>
        {
            var total = a + b;

            if (total < 100)
            {
                Debug.Log("Total is less than 100");
            }
            Debug.Log("Total: " + total);
        };

        Sum(5, 2);
        Debug.Log("Other sum");
        Sum(100, 5);
    }

    // int GetCharacters(string name)
    // {
    //     return name.Length;
    // }
}
