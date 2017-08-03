using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	private float lookspeed = 1f;
	private float movespeed = 200f;
	private Vector3 moveDir;

	private float mouseY; //because we're clamping

	Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;


		
	}
	void Move(){
		//Vector3 yVelFix = new Vector3( 0, rb.velocity.y, 0 );
		rb.velocity = moveDir * movespeed * Time.deltaTime;
		//rb.velocity += yVelFix;
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalmove = Input.GetAxisRaw ("Horizontal");
		float verticalmove = Input.GetAxisRaw ("Vertical");
		moveDir = (transform.right * horizontalmove + transform.forward * verticalmove).normalized;
		//print (moveDir);



		transform.Rotate (0f, Input.GetAxis ("Mouse X") * lookspeed, 0f);
		mouseY += Input.GetAxis ("Mouse Y") * lookspeed;
		mouseY = Mathf.Clamp (mouseY, -60f, 60f);
		Camera.main.transform.localEulerAngles = new Vector3( -mouseY, 0f, 0f ); 



	}


	void FixedUpdate(){
		Move ();

		
	}
}
