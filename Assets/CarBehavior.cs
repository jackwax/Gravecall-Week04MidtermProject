using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehavior : MonoBehaviour {

	private AudioSource locksound;
	bool isLocked;

	GameObject[] lights;

	// Use this for initialization
	void Start () {
		lights = new GameObject[2];

		isLocked = false;
		locksound = this.GetComponent<AudioSource> ();

		lights [0] = this.gameObject.transform.GetChild (0).gameObject;
		lights [1] = this.gameObject.transform.GetChild (1).gameObject;

		
	}

	public bool checkLocked(){
		return isLocked;
	}

	public void lockCar(){
		if (isLocked == false) {
			isLocked = true;
			locksound.Play ();
			foreach (GameObject light in lights){
				light.transform.GetChild (0).gameObject.SetActive (false);
			}
		} else {
			Debug.Log ("car is already locked");
		}

	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
