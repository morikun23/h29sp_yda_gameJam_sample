using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	//取得された
	bool isGotten;

	[SerializeField]
	int score;

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		isGotten = true;
	}

	public bool IsGotten() {
		return isGotten;
	}

	public int GetScore() {
		return score;
	}
	
}
