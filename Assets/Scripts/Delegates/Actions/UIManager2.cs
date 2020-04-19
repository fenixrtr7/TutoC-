using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager2 : MonoBehaviour
{
    private void OnEnable() {
        Player4.OnDamageReceived += UpdateHealth;
    }
    public void UpdateHealth(int health)
    {
        Debug.Log("Current Health: " +  health);
    }
}
