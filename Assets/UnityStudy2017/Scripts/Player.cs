using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D _rigidBody2D = null;
    private Animator _animator = null;
    private SpriteRenderer _spriteRenderer = null;
    private Vector2 _moveVector = Vector2.zero;

    [SerializeField]
    private float moveSpeed = 3.0f;

	// Use this for initialization
	void Start ()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        	
	}
	
	// Update is called once per frame
	void Update ()
    {
        /// 移動入力
        PlayerMove();
        PlayerAnimation();
        PlayerFlip();
	}

    void FixedUpdate()
    {
        /// 移動
        _rigidBody2D.velocity = _moveVector * moveSpeed;

    }

    void PlayerMove()
    {
        _moveVector = new Vector2
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = _rigidBody2D.velocity.y
        }.normalized;
    }

    void PlayerAnimation()
    {
        var speed = _rigidBody2D.velocity.magnitude;

        if(speed > 0.1f)
        {
            _animator.Play("Running");
        }
        else
        {
            _animator.Play("Idling");
        }
    }

    void PlayerFlip()
    {
        if(_moveVector.x == 1)
        {
            _spriteRenderer.flipX = false;
        }
        else 
        if(_moveVector.x == -1)
        {
            _spriteRenderer.flipX = true;
        }
    }

}
