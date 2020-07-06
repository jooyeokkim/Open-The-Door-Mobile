using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Submenu : MonoBehaviour {
	public GameObject SubmenuPanel;
	public GameObject loading;
	bool isactive;
	// Use this for initialization
	void Start () {
		SubmenuPanel.SetActive (false);
		isactive = false;
	}	
	public void OpenSubMenu(){
		if (isactive == false) {
			SubmenuPanel.SetActive (true);
			isactive = true;
		} else {
			SubmenuPanel.SetActive (false);
			isactive = false;
		}
	}
	public void Resume(){
		SubmenuPanel.SetActive (false);
	}
	public void Quitlevel(){
		loading.SetActive (true);
		SceneManager.LoadScene (1);
	}
	public void MainScreen(){
		loading.SetActive (true);
		SceneManager.LoadScene (0);
	}	
}
