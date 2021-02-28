using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockStages : MonoBehaviour {
	private GameObject level;
	private Image image;
	private Button frameButton;
	private Button imageButton;
	private GameObject button;
	private GameObject dia;
	public Sprite lockimage;
	// Use this for initialization
	private int user_level = 38;
	void Start () {
		LoadLevelData ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadLevelData() {
		for (int i = user_level + 1; i <= 40; i++) {
			string levelnum = "LEVEL" + i;
			level = this.gameObject.transform.Find (levelnum).gameObject;
			frameButton = level.GetComponent<Button> ();
			frameButton.interactable = false;

			button = level.transform.Find ("Button").gameObject;
			dia = level.transform.Find ("userdia").gameObject;

			imageButton = button.GetComponent<Button> ();
			imageButton.interactable = false;

			image = button.GetComponent<Image> ();
			image.sprite = lockimage;
		
			dia.SetActive (false);
		}
	}
}
