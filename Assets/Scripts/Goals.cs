using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goals : MonoBehaviour {
	int count;
	public timer time;
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
			time.gameover ();
			isgameover = true;
			clearpanel.SetActive (true);
		}
	}
	public void DownCount() {
		if (!isgameover) count--;
	}
}
