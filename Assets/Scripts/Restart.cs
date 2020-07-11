using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public Button re;
	public GameObject loading;
	public void retry(){
		loading.SetActive (true);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
