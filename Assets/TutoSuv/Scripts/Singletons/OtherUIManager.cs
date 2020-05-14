using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherUIManager : MonoBehaviour
{
    static OtherUIManager _instance;
    public static OtherUIManager Instance
    {
        get
        {
            if (_instance == null){
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<OtherUIManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void UpdateScore(int score)
    {
        Debug.Log("New score");
    }
}
