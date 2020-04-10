using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    public Dictionary<string, int> people = new Dictionary<string, int>();
    public Dictionary<int, string> books = new Dictionary<int, string>();
    // Start is called before the first frame update
    void Start()
    {
        people.Add("Jon", 26);
        people.Add("kil", 28);
        people.Add("Jum", 21);
        people.Add("hu", 39);

        int kilAge = people["kil"];

        Debug.Log("kil age: " + kilAge);
        books.Add(1, "ghdsfghdsggfdsgjhghjdghjdsgfgdhs");
        books.Add(2, "jkdkjfhdskjfhsjdk zzz");

        //Debug.Log(books[2]);
        foreach (KeyValuePair<int, string> book in books)
        {
            Debug.Log("Book: " + book.Value);
        }
        // Other form

        foreach (var book in books.Values)
        {
            Debug.Log("Book: " + book);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
