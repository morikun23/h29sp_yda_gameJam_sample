using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemManager : MonoBehaviour {
	
	Coin[] coins;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		coins = FindObjectsOfType<Coin>();
		
		foreach(Coin coin in coins) {
			if (coin.IsGotten()) {
				Destroy(coin.gameObject);
			}
		}
		
	}
}
