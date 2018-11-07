using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunBar : MonoBehaviour {
    public Sprite[] bar;
    public Image gunBarUI;
    private GameController IndexArma;
   
    

	// Use this for initialization
	void Start () {
        IndexArma = GameObject.Find("GameController").GetComponent<GameController>();
		
	}

    // Update is called once per frame
    void Update() {
        gunBarUI.sprite = bar[IndexArma.Gun];
		
	}
}
