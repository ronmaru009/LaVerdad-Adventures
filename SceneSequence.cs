using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour {
	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;

	public static int SceneNumber;
	public Color loadToColor = Color.black;



	void Start () {
		StartCoroutine (TheSequence ());

	}

	IEnumerator TheSequence () {
		yield return new WaitForSeconds (10);
		cam2.SetActive (true);
		cam1.SetActive (false);
		yield return new WaitForSeconds (10);
		cam3.SetActive (true);
		cam2.SetActive (false);
		yield return new WaitForSeconds (7);
		SceneNumber = 8;
		Initiate.Fade ("7", loadToColor, 0.5f);


	}
	

}
