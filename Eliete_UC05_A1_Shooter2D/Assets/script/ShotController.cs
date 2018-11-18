using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour {
    private GameObject player;
    public bool viradoDireita = true;
    

    //trajetoria e velocidade do tiro, e destruido apos alguns segundos
    void Start()
    {
        /*GetComponent<Rigidbody2D>().velocity
            = new Vector2(transform.localRotation.eulerAngles.z == 0 ? 20 : -20, 0);
        Destroy(gameObject, 2f);*/

        player = GameObject.FindWithTag("Player");
    }

    private void Update()

    {
        GetComponent<Rigidbody2D>().velocity
        = new Vector2(transform.localRotation.eulerAngles.z == 0 ? 20 : -20, 0);
     
        Destroy(gameObject, 2f);

        //inverter a direcao dos tiros
        if (player.transform.localScale.x < 0)
        {
            GetComponent<Rigidbody2D>().velocity
            = new Vector2(transform.localRotation.eulerAngles.z == 180 ? 20 : -20, 0);



           // GetComponent<Transform>().localScale
           // = new Vector3(transform.localScale.x *= -1,0,0);

            Destroy(gameObject, 2f);


            // inverter a animacao do tiro
            //FlipShot(){
        
               // viradoDireita = !viradoDireita;
               /* Vector3 escalaShot = transform.localScale;
                escalaShot.x *= -1;
                transform.localScale = escalaShot;
                }*/

            }
        }

        //destruido no momento da colisao
        /* void OnTriggerEnter2D(Collider2D other)
     {
         if (other.CompareTag("PrefabEnemy"))
         {
             Destroy(gameObject);
         }

     }*/

    }


