using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour {

	public GameObject TheDoor;
	private float coorY;

	void Start () {
		coorY = TheDoor.transform.position.y;
	}

	private void OnTriggerStay(){
		if (coorY + 3.5 > TheDoor.transform.position.y)
			TheDoor.transform.position += TheDoor.transform.up * Time.deltaTime;
	}

	private void OnTriggerExit(){
		while (coorY < TheDoor.transform.position.y) 
			TheDoor.transform.position -= TheDoor.transform.up * Time.deltaTime;

		}

}
