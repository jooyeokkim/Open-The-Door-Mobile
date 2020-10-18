using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainSceneButtons : MonoBehaviour {
	public GameObject loading;
	public void Gotostage(){
		loading.SetActive (true);
		SceneManager.LoadScene (1);
	}
	public void Guide(){
		loading.SetActive (true);
		SceneManager.LoadScene (2);
	}	
	public void Quit(){
		Application.Quit ();
	}	
}
