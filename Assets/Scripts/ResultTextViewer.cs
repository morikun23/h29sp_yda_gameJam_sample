using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextViewer : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start() {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update() {
		int score = GameManager.GetScore();

		text.text =
			"あなたのスコアは" + score + "点です！";
	}
}
