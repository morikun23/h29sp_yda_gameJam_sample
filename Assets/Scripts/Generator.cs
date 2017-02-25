using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	[SerializeField]
	float interval;

	[SerializeField]
	GameObject coinPrefab;

	Coin coin;
	
	// Use this for initialization
	void Start () {
		StartCoroutine(Exec());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator Exec() {
		while (true) {
			if(coin == null) {
				Generate();
			}
			yield return new WaitForSeconds(interval);
		}
	}

	void Generate() {
		coin = Instantiate(coinPrefab , transform.position,Quaternion.identity).GetComponent<Coin>();
	}
}