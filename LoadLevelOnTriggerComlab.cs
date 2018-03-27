 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnTriggerComlab : MonoBehaviour {

	public GameObject guiObject;
	public string levelToLoad;
	public Color loadToColor = Color.black;



	// Use this for initialization
	void Start () {
		guiObject.SetActive (false);	
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other)
	{

		if (other.gameObject.tag == "Player") {

			guiObject.SetActive (true);
			if (guiObject.activeInHierarchy == true && Input.GetButtonDown ("Use")) {
				Initiate.Fade ((levelToLoad), loadToColor, 0.5f);
			}
		}
	}

	void OnTriggerExit()
	{
		guiObject.SetActive (false); 
	}
}
