using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 0.1f;
	Rigidbody2D rigidbody2d;


	// Use this for initialization
	void Start() {
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		///////////////////////////////////////////////////////
		//Chapter1
		
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position += new Vector3(speed , 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += new Vector3(-speed , 0);
		}

		///////////////////////////////////////////////////////

		if (Input.GetKeyDown(KeyCode.Space)) {
			rigidbody2d.AddForce(new Vector2(0 , 400f));
		}
	}
	
}