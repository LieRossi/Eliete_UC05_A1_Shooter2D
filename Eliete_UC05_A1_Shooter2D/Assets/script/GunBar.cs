using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunBar : MonoBehaviour {
    public Sprite[] bar;
    public Image GunBarUI;
    private GameController Gun;
  

	// Use this for initialization
	void Start () {
        Gun = GameObject.Find("GameController").GetComponent<GameController>();
		
	}

    // Update is called once per frame
    void Update() {
        GunBarUI.sprite = bar[Gun.Gun];
		
	}
}
