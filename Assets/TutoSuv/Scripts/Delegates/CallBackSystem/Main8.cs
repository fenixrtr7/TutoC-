using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Main8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("The routine has finished!");
        }));
    }

    public IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5.0f);

        if(onComplete != null)
            onComplete();
    }
}
