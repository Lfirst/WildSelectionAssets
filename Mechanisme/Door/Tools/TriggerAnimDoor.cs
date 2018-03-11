using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimDoor : MonoBehaviour {

	public GameObject TheDoor1;
	public GameObject TheDoor2;
	private bool is_open = false;

	private void OnTriggerStay(){
		if (is_open == false && Input.GetKeyDown ("e")){
			TheDoor1.GetComponent<Animation>().Play ("OpenDoor");
			TheDoor2.GetComponent<Animation>().Play ("OpenDoorRight");
			is_open = true; 
		}

		else if (is_open == true && Input.GetKeyDown ("e")) {
			TheDoor1.GetComponent<Animation> ().Play ("CloseDoor");
			TheDoor2.GetComponent<Animation> ().Play ("CloseDoorRight");
			is_open = false;
		}
	}

	/*private void OnTriggerExit(){
		if (is_open == true) {
			TheDoor1.GetComponent<Animation> ().Play ("CloseDoor");
			TheDoor2.GetComponent<Animation> ().Play ("CloseDoorRight");
			is_open = false;
		}
	}*/
}
