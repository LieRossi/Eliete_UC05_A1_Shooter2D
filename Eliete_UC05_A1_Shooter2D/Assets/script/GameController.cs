using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public GameObject PrefabEnemy;
    public GameObject PrefabShot;
    public GameObject PrefabShot1;
    public Transform GunPoint;
    private int IndexArma;
    public Text ArmaUIText;
    public int Gun;
    public int GunBar1;
    public int GunBar2;
    public bool viradoDireita = true;
    private GameObject player;



    float randy;
   Vector3 WhereToSpawn;
   public float spawnRate = 2f;
   float nextSpawn = 0.0f;

 

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        // surgir novos inimigos
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randy = Random.Range(-8.0f, -5.0f);
            WhereToSpawn = new Vector3(10f, randy);

            Instantiate(PrefabEnemy, WhereToSpawn, Quaternion.identity);
        }

        // escolha de arma
        if (Input.GetKeyDown(KeyCode.Q))
        {
            IndexArma++;

            if (IndexArma > 2)
            {
                IndexArma = 1;
                //Gun = GunBar1;
            }
        }
         
        // atirando 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (IndexArma == 1)
            {
                Instantiate(PrefabShot, GunPoint.position, Quaternion.identity);
                Gun = GunBar1;
                ArmaUIText.text = " 1ª" + " " + "Arma";
            }
            else
            {
                if (IndexArma == 2)
                {
                    Instantiate(PrefabShot1, GunPoint.position, Quaternion.identity);
                    Gun = GunBar2;
                    ArmaUIText.text = " 2ª" + " " + "Arma";
                }
            }
        }


        // inverte a animacao do tiro
       
        /*{ 
            viradoDireita = !viradoDireita;
            Vector3 escalaPrefabShot = transform.localScale;
            escalaPrefabShot.x *= -1;
            transform.localScale = escalaPrefabShot;

            Vector3 escalaPrefabShot1 = transform.localScale;
            escalaPrefabShot1.x *= -1;
            transform.localScale = escalaPrefabShot1;
        }*/








    }
}
