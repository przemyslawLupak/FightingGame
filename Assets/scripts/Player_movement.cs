using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {
	public float movementSpeed = 40f;
	float horizontalMove = 0f;
	public bool isGrounded = false;
	bool jump = false;
	public Animator animator; 
	public CharacterController2D controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;
		animator.SetFloat("move",horizontalMove);
		animator.SetFloat("speed", Mathf.Abs(horizontalMove));
		if(Input.GetButtonDown("Jump")){
			
			animator.SetBool("isJumping",true);
			jump = true;
		}
	}
	public void OnLanding(){
		animator.SetBool("isJumping",false);
	}
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
		jump = false;
	}
	
}
