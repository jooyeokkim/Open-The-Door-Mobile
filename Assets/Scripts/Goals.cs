using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour {
	int count;
	AudioSource clear;
	public GameObject clearpanel;
	bool isgameover = false;
	void Start() {
		clear = GetComponent<AudioSource> ();
		count = 0;
		clearpanel.SetActive (false);
	}
	public void UpCount() {
		if(!isgameover) count++;
		if (!isgameover && count == 3) {
			Debug.Log ("GAME CLEAR!");
			clear.Play ();
			isgameover = true;
			clearpanel.SetActive (true);
		}
	}
	public void DownCount() {
		if (!isgameover) count--;
	}
}
