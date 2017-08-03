using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarBehavior : MonoBehaviour {

	private AudioSource locksound;
	bool isLocked;

	GameObject[] lights;

	public GameObject GameText;

	// Use this for initialization
	void Start () {
		GameText = GameObject.Find ("GameText");

		lights = new GameObject[2];

		isLocked = false;
		locksound = this.GetComponent<AudioSource> ();

		lights [0] = this.gameObject.transform.GetChild (0).gameObject;
		lights [1] = this.gameObject.transform.GetChild (1).gameObject;

		
	}

	public bool checkLocked(){
		if (isLocked == false) {
			GameText.GetComponent<Text> ().text = "Press [space] to turn off the car";
			return false;
			
		} else {
			return true;
		}

	}

	public void lockCar(){
		bool isit = checkLocked ();
		if (isit == false) {
			isLocked = true;
			locksound.Play ();
			GameText.SetActive (false);
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
