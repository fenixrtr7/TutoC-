﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour
{
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamege;
    //Same
    public static Action<int> OnDamageReceived;

    public int Health { get; set; }

    private void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        Health--;
        if (OnDamageReceived != null)
        {
            OnDamageReceived(Health);
        }
    }
}
