using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	/**OBJECT REFERENCES**/
	public GameObject player;
	public CarBehavior car;
	public GameObject phoneTrigger;


	/**UI OBJECTS**/

	public GameObject GameText;



	/**INTERNALS**/

	float seccounter;

	[HideInInspector] public bool fadedone = true;










	// Use this for initialization
	void Start () {
		seccounter = 0;

		Cursor.lockState = CursorLockMode.Locked;

		GameText = GameObject.Find ("GameText");
		GameText.GetComponent<Text>().text = "Gravecall, " +
			"by Jack Reynolds";

		player = GameObject.Find ("player");

		phoneTrigger = GameObject.Find ("phoneTrigger");

		fadedone = true;




		
	}
	
	// Update is called once per frame
	void Update () {
		seccounter += Time.deltaTime;

		int timesecs = (int)seccounter;

		if (fadedone == true) { //if the fade is finished, start game
			//print("yeah");
			if (seccounter > 3) {
				//player.GetComponent<mouselook> ().movementlocked = false;
				car.checkLocked ();

				//if (car.checkLocked()== true && if
				//allow movement
				//tutorial


			}

			
		}
	}


		


//	void initDialogue(List<string> MomOrJackDialogue){
////		if (MomOrJackDialogue == momdialogue) {
////			momdialogue.Add ("Dinner's ready... Where are you?");
////			momdialogue.Add ("You know what? I've had it with you.");
////			momdialogue.Add ("You don't have enough P.E credits... They might not let you graduate");
////			momdialogue.Add ("No shut the fuck up... Let me ask you something...");
////			momdialogue.Add ("When are you going to finish anything?");
////			momdialogue.Add ("We took you out of Hartsdale, you got fired from your job");
////			momdialogue.Add ("I'm tired of you tearing this family apart");
////			momdialogue.Add ("I don't care when you come home. Come back when you're not going to be a fuck up anymore.");
////			momdialogue.Add ("*click");
////
////		}
////
////		if (MomOrJackDialogue.Add == jackdialogue) {
////		}
////
//
//
//	}


	
}
