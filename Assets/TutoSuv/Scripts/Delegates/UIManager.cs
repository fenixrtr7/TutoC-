using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;
    
    private void OnEnable() {
        Player3.onDeath += UpdateDeathCount;
    }
    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;
    }
}
