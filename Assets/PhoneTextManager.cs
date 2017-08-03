using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneTextManager : MonoBehaviour {

	public Text momphone;
	public string message;
	public bool finishedtyping = false;
	bool startmessage = false;


	public void AddMessage(string messij){
		message = messij;
		startmessage = false;
	}

	// Use this for initialization
	void Start () {
		//print (message);
		momphone = GameObject.Find ("momphonetext").GetComponent<Text> ();



		
	}
	
	// Update is called once per frame
	public IEnumerator TypeText(){
		foreach (char letter in message.ToCharArray()) {
			momphone.text += letter;
			yield return new WaitForSeconds (0.01f);
		}

	}
	void LateUpdate(){
		if (message == null) {
			print ("fuck");
		}
		if (startmessage==false) {
			startmessage = true;
			StartCoroutine (TypeText ());
		}

		if (message!=null){ 
			if (message.Length == momphone.text.Length) {
			finishedtyping = true;
			}
		}
	}
}
