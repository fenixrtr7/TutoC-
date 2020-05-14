using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main3: MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                // if(hitInfo.collider.name == "Player")
                // hitInfo.collider.GetComponent<Player2>().Damage(100);

                // if(hitInfo.collider.name == "Enemy")
                // hitInfo.collider.GetComponent<Enemy2>().Damage(100); 

                IDamageble obj = hitInfo.collider.GetComponent<IDamageble>();

                if (obj != null)
                {
                    obj.Damage(500);
                }
            }
        }
    }
}
