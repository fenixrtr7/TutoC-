using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main5.onClick += TurnRed;
        //////////////////////////////
        Main5.actionBar += ChangePosition;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void ChangePosition(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable() {
        Main5.onClick -= TurnRed;
        Main5.actionBar -= ChangePosition;
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
