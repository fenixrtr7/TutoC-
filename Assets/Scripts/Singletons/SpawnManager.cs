using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject _enemyPrefab;
    static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null){
                GameObject go = new GameObject("Spawn Manager");
                go.AddComponent<SpawnManager>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private void Start() {
        Debug.Log(Player6.Instance.name);
    }

    public void StartSpawning()
    {
        Debug.Log("Spawn started");
        Instantiate(_enemyPrefab);
    }
}
