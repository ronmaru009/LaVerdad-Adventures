using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Color loadToColor = Color.black;


	public void PlayGame()
	{
		Initiate.Fade ("LVCC2", loadToColor, 0.5f);
		//Destroy (GameObject.Find ("BGSound"));

	}


	public void QuitGame() {
		Application.Quit();
	}
}
