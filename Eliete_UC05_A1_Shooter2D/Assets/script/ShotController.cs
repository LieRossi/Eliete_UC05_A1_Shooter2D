using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{


    //trajetoria e velocidade do tiro, e destruido apos alguns segundos
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity
            = new Vector2(transform.localRotation.eulerAngles.z == 0 ? 20 : -20, 0);
        Destroy(gameObject, 2f);
    }
    //destruido no momento da colisao

   /* void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PrefabEnemy"));
        {
            Destroy(gameObject);
        }

    }*/

}
