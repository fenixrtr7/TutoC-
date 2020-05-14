using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main5.onClick += Test;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Test()
    {
        Debug.Log("Esto es un test");
    }
}
