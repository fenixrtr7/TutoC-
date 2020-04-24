using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ExampleLinq : MonoBehaviour
{
    public string[] names = {"jon", "ales", "julie", "jessie", "david", "mark", "matt", "batista" };
    public string[] namesDuplicate = {"jon", "jon", "julie", "jessie", "david", "mark", "matt", "david" };
    public int[] grades = { 3, 5, 80, 77, 10, 70};
    
    // Start is called before the first frame update
    void Start()
    {
        var nameFound = names.Any(name => name == "jon");
        Debug.Log("Name Found: " + nameFound);

        nameFound = names.Contains("Jon");
        Debug.Log("Name Found: " + nameFound);

        // foreach (var name in names)
        // {
        //     if (name == "jon")
        //     {
        //         Debug.Log("Found Jon!");
        //     }
        // }

        ///////////////////////
        // DUPLICATE

        var uniqueNames = namesDuplicate.Distinct();

        foreach (var name in uniqueNames)
        {
            Debug.Log("Name: " + name);
        }

        ///////////////////////////
        // WHERE
        Debug.Log("Start WHERE");
        var result = names.Where(n => n.Length > 5);

        foreach (var name in result)
        {
            Debug.Log("Name: " + name);
        }

        //////////////////////////
        // Grades mayor than 69
        Debug.Log("Start challenge Num above 69");

        var more69 = grades.Where( num => num > 69).OrderByDescending(g => g).Reverse();

        foreach (var num in more69)
        {
            Debug.Log("Num: " + num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
