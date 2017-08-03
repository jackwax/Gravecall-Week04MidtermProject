using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneCaller : MonoBehaviour {
	

	public PhoneTrigger pTrigger;
	public List<string> fulldialogue;
	public int counter;
	bool dialoguestart = false;
	bool dialoguedone = false;

	// Use this for initialization
	void Start () {
		counter = 0;
		pTrigger = GameObject.Find ("phoneTrigger").GetComponent<PhoneTrigger> ();
		fulldialogue.Add ("HEY I LIKE SPAGHETTI");
		fulldialogue.Add ("I ALSO DO");
		fulldialogue.Add ("this is a dia");
		fulldialogue.Add ("this is a dia 2");
		fulldialogue.Add ("this is a dia 3");



		
	}

	public void CreateNewDialogue(){
		
		this.GetComponent<PhoneTextManager> ().AddMessage(fulldialogue [counter]);
		counter++;


	}

	public void WipeDialogue(){
		this.GetComponent<PhoneTextManager> ().momphone.text = "";
	}

	public void DialogueHandler(){
		if (counter < fulldialogue.Count) {
			/**ONLY CALLED WHEN SPACE IS ENTERED**/
			//wipe dialogue if it's finished
			if (this.gameObject.GetComponent<PhoneTextManager> ().finishedtyping == true) {
				WipeDialogue ();
			}
			//if we need a new dialogue, create it
		
			if (this.gameObject.GetComponent<PhoneTextManager> ().finishedtyping == false) {
			
			} else {
				//deleteDialogue ();
				CreateNewDialogue ();

			}
		} else {
			/**dialogue is done, wipe it**/
			WipeDialogue ();
			dialoguedone = true;
		}

		}



	
	// Update is called once per frame
	void Update () {
		if (pTrigger.checkifCalled()== true && pTrigger.isAnswered() == true && dialoguestart == false) {
			print ("WEE HA");
			this.gameObject.AddComponent<PhoneTextManager> ();
			this.GetComponent<PhoneTextManager> ().AddMessage(fulldialogue [counter]);
			dialoguestart = true;
			counter++;
		}
		
			
			

			
		}
		

}
