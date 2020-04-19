using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main5 : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    ///////////////////////////////////////////////

    public delegate void ActionBar(Vector3 pos);
    public static event ActionBar actionBar;
    public void ButtonClick()
    {
        if(onClick != null)
            onClick();
        //turn all cubes red
    }

    public void SpaceBarClick()
    {
        if(actionBar != null)
        {
            actionBar(new Vector3(5, 2, 0));
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceBarClick();
        }
    }
}
