using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPool : MonoBehaviour
{
    [SerializeField]
    GameObject _bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Communicate with the object pool system
            // Request bullet
            var objBullet = PoolManager.Instance.RequestBullet();
        }
    }
}
