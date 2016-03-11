using UnityEngine;
using System.Collections;
using System;

public class CarControl : MonoBehaviour 
{

	Rigidbody body;
	float carSpeed;
	bool isTouchingGround;

	void Start() 
	{
		carSpeed = 5; 		//use number
		body = GetComponent<Rigidbody>();
		body.velocity += new Vector3(0, body.velocity.y, carSpeed);
	} 

	void Update() 
	{
		gameObject.transform.eulerAngles = new Vector3(0,0,0);
		if(Input.GetKeyDown(KeyCode.A) == true) 								//key pressed
			body.velocity = new Vector3(-1.5f, body.velocity.y, carSpeed);
		if(Input.GetKeyDown(KeyCode.D) == true) 								//key pressed
			body.velocity = new Vector3(1.5f, body.velocity.y, carSpeed);
		if(Input.GetKey(KeyCode.D) == false && Input.GetKey(KeyCode.A) == false)
			body.velocity = new Vector3(0, body.velocity.y ,carSpeed);
		if(Input.GetKey(KeyCode.Space) && isTouchingGround == true) 
			body.velocity = new Vector3(body.velocity.x,5,carSpeed);
		isTouchingGround = false;
	}

	void OnCollisionStay(Collision Col)
	{
		if(Col.gameObject.tag == "ground")
			isTouchingGround = true;
	}
}