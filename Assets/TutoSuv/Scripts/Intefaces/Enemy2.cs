﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour, IDamageble
{
    public int Health { get; set; }

    public void Damage( int damageAcount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
