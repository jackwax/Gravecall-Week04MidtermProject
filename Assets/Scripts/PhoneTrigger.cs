using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneTrigger : MonoBehaviour {

	bool callAnswered = false;
	public AudioSource ringtone;
	bool isRinging;
	public GameObject GameText;
	bool isCalled = false;

	void Start(){
		ringtone = this.GetComponent<AudioSource> ();
		GameText = GameObject.Find ("GameText");
	}

	public bool isAnswered(){
		if (isRinging) {
			return false;
		} else {
			return true;
		}
	}
	public bool checkifCalled(){
		return isCalled;
	}


	public void PhoneAnswer(){
		if (isRinging)
		{
			GameText.SetActive (false);
			ringtone.Stop ();
			isRinging = false;
		}

	}



	void OnTriggerEnter(Collider col){
		Debug.Log ("This collider has been reached");
		GameText.GetComponent<Text>().text = "Press [space] to Answer";
		GameText.SetActive (true);
		if (callAnswered == false) {
			isCalled = true;
			ringtone.Play ();
			isRinging = true;
		}
			
		

	}
}
