using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainSceneButtons : MonoBehaviour {
	public GameObject copyrightPanel;
	public GameObject gameinfoPanel;
	public GameObject memoPanel;
	bool isactiveC;
	bool isactiveG;
	bool isactiveM;
	public GameObject loading;
	public void OpenCopyright(){
		if (isactiveC == false) {
			copyrightPanel.SetActive (true);
			isactiveC = true;
		} else {
			copyrightPanel.SetActive (false);
			isactiveC = false;
		}
	}
	public void OpenGameinfo(){
		if (isactiveG == false) {
			gameinfoPanel.SetActive (true);
			isactiveG = true;
		} else {
			gameinfoPanel.SetActive (false);
			isactiveG = false;
		}
	}
	public void OpenMemo(){
		if (isactiveM == false) {
			memoPanel.SetActive (true);
			isactiveM = true;
		} else {
			memoPanel.SetActive (false);
			isactiveM = false;
		}
	}
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
