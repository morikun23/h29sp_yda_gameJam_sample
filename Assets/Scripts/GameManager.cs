using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour {

	int score;
	const int MAX_SCORE = 9999;
	float limitTime;

	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		score = 0;
		limitTime = 60;
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Coin[] coins = FindObjectsOfType<Coin>();
		
		foreach(Coin coin in coins) {
			if (coin.IsGotten()) {
				audioSource.Play();
				AddScore(coin.GetScore());
				Destroy(coin.gameObject);
			}
		}
		
		limitTime -= Time.deltaTime;
		if(limitTime < 0) { limitTime = 0; }
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

	public float GetLimitTime() {
		return limitTime;
	}
}
