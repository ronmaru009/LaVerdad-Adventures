using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SplashSequence : MonoBehaviour {

	public static int SceneNumber;
	public Color loadToColor = Color.black;
	public string scene;







	void Start () {
		if (SceneNumber == 0) {
			StartCoroutine (ToSplashOne ());

		}
		if (SceneNumber == 1) {
			StartCoroutine (ToSplashTwo ());	

		}
		if (SceneNumber == 2) {
			StartCoroutine (ToSplashThree ());	

		}
		if (SceneNumber == 3) {
			StartCoroutine (ToSplashFour ());	

		}
		if (SceneNumber == 4) {
			StartCoroutine (ToSplashFive ());	

		}
		if (SceneNumber == 5) {
			StartCoroutine (ToSplashSix ());	

		}
		if (SceneNumber == 6) {
			StartCoroutine (ToSplashSeven ());	

		}
		if (SceneNumber == 7) {
			StartCoroutine (ToSplashEight ());	

		}


	} 

	void Update(){
		if (Input.GetKeyDown(KeyCode.Q)) {
			Initiate.Fade ("7", loadToColor, 0.5f);
		}
	}

		IEnumerator ToSplashOne () {
			yield return new WaitForSeconds (7);
			SceneNumber = 1;
			SceneManager.LoadScene(1);


		}

		IEnumerator ToSplashTwo () {
		yield return new WaitForSeconds (3);
		SceneNumber = 2;
		Initiate.Fade ("1", loadToColor, 0.5f);

		if (Input.GetKeyDown(KeyCode.Q)) {
				Initiate.Fade ("7", loadToColor, 0.5f);
			}

		}
		
		IEnumerator ToSplashThree () {
			yield return new WaitForSeconds (3);
			SceneNumber = 3;
			Initiate.Fade ("2", loadToColor, 0.5f);

		if (Input.GetKeyDown(KeyCode.Q)) {
				Initiate.Fade ("7", loadToColor, 0.5f);
			}
		}

		IEnumerator ToSplashFour () {
			yield return new WaitForSeconds (3);
			SceneNumber = 4;
			Initiate.Fade ("3", loadToColor, 0.5f);

		if (Input.GetKeyDown(KeyCode.Q)) {
				Initiate.Fade ("7", loadToColor, 0.5f);
			}
		}

		IEnumerator ToSplashFive () {
			yield return new WaitForSeconds (3);
			SceneNumber = 5;
			Initiate.Fade ("4", loadToColor, 0.5f);

		if (Input.GetKeyDown(KeyCode.Q)) {
				Initiate.Fade ("7", loadToColor, 0.5f);
			}
		}

		IEnumerator ToSplashSix () {
			yield return new WaitForSeconds (3);
			SceneNumber = 6;
			Initiate.Fade ("5", loadToColor, 0.5f);

		if (Input.GetKeyDown(KeyCode.Q)) {
				Initiate.Fade ("7", loadToColor, 0.5f);
			}
		}

		IEnumerator ToSplashSeven () {
			yield return new WaitForSeconds (3);
			SceneNumber = 7;
			Initiate.Fade ("6", loadToColor, 0.5f);

		if (Input.GetKeyDown(KeyCode.Q)) {
				Initiate.Fade ("7", loadToColor, 0.5f);
			}
		}

		IEnumerator ToSplashEight () {
			yield return new WaitForSeconds (30);
			SceneNumber = 8;
			Initiate.Fade ("7", loadToColor, 0.5f);
		}
	}
