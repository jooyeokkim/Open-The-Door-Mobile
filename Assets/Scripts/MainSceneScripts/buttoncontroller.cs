using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncontroller : MonoBehaviour {
	public Button uibutton;
	public Button ui;
	public Button gameplaybutton;
	public Button gameplay;
	public void UI(){
		ui.gameObject.SetActive (true);
		gameplay.gameObject.SetActive (false);
		uibutton.image.color = new Color (255, 255, 255, 1f);
		gameplaybutton.image.color = new Color (255, 255, 255, 0.8f);
	}
	public void Gameplay(){
		gameplay.gameObject.SetActive (true);
		ui.gameObject.SetActive (false);
		uibutton.image.color = new Color (255, 255, 255, 0.8f);
		gameplaybutton.image.color = new Color (255, 255, 255, 1f);
	}
}
