using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public GameObject door;
	private bool is_open = false;
	private float posDoor;
	private bool upDoor = false;

	void start(){
		posDoor = door.transform.position.y;
	}

	void OnTriggerStay(){
		if (is_open == false && Input.GetKeyDown ("e")) {
			is_open = true;
			upDoor = true;
		} else if (is_open && Input.GetKeyDown ("e")) {
			is_open = false;
			upDoor = false;
		}

	}

	void Update(){
		if(upDoor == false && door.transform.position.y > posDoor + 2)
			door.transform.position -= door.transform.up * Time.deltaTime;
		else if(upDoor && door.transform.position.y < posDoor + 6)
			door.transform.position += door.transform.up * Time.deltaTime;
			}
}
