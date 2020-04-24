using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    static GameManager2 _instance;
    public static GameManager2 Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The GameManager is NULL.");

            return _instance;
        }
    }
    //public static GameManager2 sharedInstance;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        //if(sharedInstance == null)
        //{
        //    sharedInstance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    public void DisplayName()
    {
        Debug.Log("My name is Jonathan");
    }
}
