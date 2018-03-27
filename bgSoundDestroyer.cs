using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSoundDestroyer : MonoBehaviour {


	void Start () {
		Destroy (GameObject.Find ("BGSound"));
	}
	

	void Update () {
		
	}
}
