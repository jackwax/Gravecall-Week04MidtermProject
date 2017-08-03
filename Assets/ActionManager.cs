using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour {
	public GameObject car;
	public GameObject phoneTrigger;
	public PhoneCaller phonecall;


	// Use this for initialization
	void Start () {
		car = GameObject.Find ("car");
		phoneTrigger = GameObject.Find ("phoneTrigger");
		phonecall = GameObject.Find ("gM").GetComponent<PhoneCaller> ();
		
	}

	public string ManageActions(){
		if (car.GetComponent<CarBehavior> ().checkLocked() == false) {
			return "LockCar";
		}
		if (car.GetComponent<CarBehavior> ().checkLocked() == true && phoneTrigger.GetComponent<PhoneTrigger> ().isAnswered() == false) {
			return "AnswerPhone";
		} if (car.GetComponent<CarBehavior> ().checkLocked () == true && phoneTrigger.GetComponent<PhoneTrigger> ().isAnswered () == true && phoneTrigger.GetComponent<PhoneTrigger> ().checkifCalled () == true) {
			return "CycleDialogue";
		} else {
			return "";
		}
	}

	void LateUpdate(){
		if (Input.GetKeyDown(KeyCode.Space)){
			string action = ManageActions();
			if (action == "LockCar")
			{
				car.GetComponent<CarBehavior>().lockCar();
			}
			if (action == "AnswerPhone") {
				phoneTrigger.GetComponent<PhoneTrigger>().PhoneAnswer ();
			}
			if (action == "CycleDialogue") {
				print ("this is reached ");
				phonecall.DialogueHandler ();
				
			}


		}
	}
}
