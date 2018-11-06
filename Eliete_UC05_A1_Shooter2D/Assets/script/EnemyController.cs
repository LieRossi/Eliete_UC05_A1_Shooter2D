using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject PrefabShot;
    

  
    void Start()
    {
        

    }

    
    void Update()
    {       //movimento do inimigo
        Vector3 deslocamento = new Vector3(-5, 0, 0) * Time.deltaTime;
        transform.position = transform.position + deslocamento;

        // destruicao apos 7s
        Destroy(gameObject, 7f);

     }

    void OnTriggerEnter2D(Collider2D other)
    {
        /*if (!other.isTrigger)
        {
            Destroy(gameObject);
        }*/
             // destruicao do inimigo ao ser atingido pelo tiro
        if (other.CompareTag("PrefabShot")) ;
        {
            Destroy(gameObject);
        }

    }


}