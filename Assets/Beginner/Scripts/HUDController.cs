using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void TextOutputHandler(string text);

public class HUDController : MonoBehaviour
{
    public Text textPause, textScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OutPutText(string output)
    {
        Debug.LogFormat("{0} output by GameSceneController", output);
    }
}
