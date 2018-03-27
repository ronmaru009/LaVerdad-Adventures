using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutAppear : MonoBehaviour {

	public GameObject guiObject;

	void Start () {
		guiObject.SetActive (false);
	}

	void OnTriggerStay (Collider other){
		if (other.gameObject.tag == "Player") {

			guiObject.SetActive (true);
		}
	}

		void OnTriggerExit()
		{
			guiObject.SetActive (false);

		}
	


}
