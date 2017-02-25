using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour {

	int score;
	const int MAX_SCORE = 9999;


	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Coin[] coins = FindObjectsOfType<Coin>();
		
		foreach(Coin coin in coins) {
			if (coin.IsGotten()) {
				AddScore(coin.GetScore());
				Destroy(coin.gameObject);
			}
		}
		
	}

	void AddScore(int value) {
		if(score + value >= MAX_SCORE) {
			score = MAX_SCORE;
		}
		else {
			score += value;
		}
	}

	public int GetScore() {
		return score;
	}
}
