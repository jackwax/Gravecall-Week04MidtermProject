using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//public player 
	public CarBehavior car;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		

		
	}
	
	// Update is called once per frame
	void Update () {
		if (car.checkLocked () == false) {
			if (Input.GetKeyUp (KeyCode.Space)) {
				car.lockCar ();
			}
		}
		
	}
}
