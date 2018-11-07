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
    public int Gun;
    
   float randy;
   Vector3 WhereToSpawn;
   public float spawnRate = 2f;
   float nextSpawn = 0.0f;

 

    // Use this for initialization
    void Start () {
              
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
        if (Input.GetKey(KeyCode.Q))
        {
            IndexArma++;

            if (IndexArma > 2)
            {
                IndexArma = 1;
            }
        }
         
        // atirando 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (IndexArma == 1)
            {
                Instantiate(PrefabShot, GunPoint.position, Quaternion.identity);
                Gun = 1;
            }
            else
            {
                if (IndexArma == 2)
                {
                    Instantiate(PrefabShot1, GunPoint.position, Quaternion.identity);
                    Gun = 2;
                }
            }
        }

       
    }
}
