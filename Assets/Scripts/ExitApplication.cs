using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitApplication : MonoBehaviour {
	public void GotoMainScreen(){
		SceneManager.LoadScene (0);
	}
	public void exit(){
		Application.Quit ();
	}
}
