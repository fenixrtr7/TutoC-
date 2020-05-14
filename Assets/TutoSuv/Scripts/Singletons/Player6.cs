using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player6 : MonoSingleton<Player6>
{
    public string name;

    public override void Init()
    {
        base.Init();

        Debug.Log("Player Initialized!");
        LevelManager.Instance.LoadLevel();
    }
}
