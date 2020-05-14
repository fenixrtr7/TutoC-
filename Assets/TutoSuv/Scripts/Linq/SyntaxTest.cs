using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SyntaxTest : MonoBehaviour
{
    int[] scores = new int[] { 97, 92, 81, 60 };
    // Start is called before the first frame update
    void Start()
    {
        var scoreQuerySyntax =
            from score in scores
            where score > 80
            select score;

        // The same
        var scoreQuery = scores.Where(score => score > 80);

        foreach(var score in scoreQuery)
        {
            Debug.Log("Score: " + score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
