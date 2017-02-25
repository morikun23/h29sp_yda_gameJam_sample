using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 0.1f;
	Rigidbody2D rigidbody2d;
	Vector3 velocity;

	[SerializeField]
	bool isRunning;
	[SerializeField]
	bool isGrounded;

	// Use this for initialization
	void Start() {
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {

		Run();
		
		isGrounded = Physics2D.Linecast(transform.position ,
			transform.position - transform.up * 1.6f ,
			1 << LayerMask.NameToLayer("Ground"));

		if (Input.GetKeyDown(KeyCode.Space)) {
			Jump();
		}
		
	}

	void Run() {
		velocity = Vector3.zero;

		if (Input.GetKey(KeyCode.RightArrow)) {
			velocity.x += speed;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			velocity.x += -speed;		}

		transform.position += velocity;
		isRunning = !(velocity.magnitude == 0);
	}

	void Jump() {
		if (!IsGrounded()) return;
		isGrounded = false;
		rigidbody2d.AddForce(new Vector2(0 , 400f));
	}

	public bool IsRunning() {
		return isRunning;
	}

	public Vector3 GetDirection() {
		return velocity.normalized;
	}

	public bool IsGrounded() {
		return isGrounded;
	}	
}