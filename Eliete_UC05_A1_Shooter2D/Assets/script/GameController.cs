using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject PrefabEnemy;
    public GameObject PrefabShot;
    public GameObject PrefabShot1;
    public Transform GunPoint;
    private int IndexArma;
    
   float randy;
   Vector3 WhereToSpawn;
   public float spawnRate = 2f;
   float nextSpawn = 0.0f;

    // Use this for initialization
    void Start () {
       // Vector3 posicao1 = new Vector3(14f, -7f);
        //Vector3 posicao2 = new Vector3 (3f, -2.5f);

       // Instantiate(PrefabEnemy, posicao1, Quaternion.identity);
        //Instantiate(PrefabEnemy, posicao2, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update () {

        // surgir novos inimigos
        if(Time.time > nextSpawn) {
             nextSpawn = Time.time + spawnRate;
             randy = Random.Range(-8.0f, -5.0f);
             WhereToSpawn = new Vector3(10f,randy);

             Instantiate(PrefabEnemy, WhereToSpawn, Quaternion.identity);
         }

               
        // atirando 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //if (IndexArma == 1)
           // {
                Instantiate(PrefabShot, GunPoint.position, Quaternion.identity);
            //}
           // else
           // {
              //  if (IndexArma == 2)
               // {
                   // Instantiate(PrefabShot1, transform.position, Quaternion.identity);
               // }
            }
        }
        //trocar de arma
       /* if (Input.GetKeyDown(KeyCode.Q))
        {
            IndexArma++;

            if(IndexArma > 2)
            {
                IndexArma = 1;
            }
        
		
	*/
}
