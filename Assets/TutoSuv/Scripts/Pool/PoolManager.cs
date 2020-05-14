using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PoolManager : MonoSingleton<PoolManager>
{ 
    [SerializeField]
    int _numObjectsInstantiate = 10;
    [SerializeField]
    GameObject _bulletPrefab;
    [SerializeField]
    List<GameObject> _bulletPool;
    [SerializeField]
    GameObject _bulletContainer;

    private void Start() {
        _bulletPool = GenerateBullets(_numObjectsInstantiate);
    }
    List<GameObject> GenerateBullets(int amountBullets)
    {
        for (int i = 0; i < amountBullets; i++)
        {
            var bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);
            
            _bulletPool.Add(bullet);   
        }
        return _bulletPool;
    }

    public GameObject RequestBullet()
    {
        // bullet trough the bullet list
        foreach (var bullet in _bulletPool)
        {
            if (bullet.activeInHierarchy == false)
            {
                // bullet is avalible
                bullet.SetActive(true);
                return bullet;
            }
            
        }
        // need to create a new bullet

        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.parent = _bulletContainer.transform;
        newBullet.SetActive(false);
        _bulletPool.Add(newBullet);

        return newBullet;
    }
}
