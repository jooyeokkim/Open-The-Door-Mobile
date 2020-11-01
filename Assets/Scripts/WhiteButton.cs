using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteButton : MonoBehaviour {
	public GameObject[] whitedoors; //original doors
	private int howmanypeople;
	AudioSource push;
	AudioSource exit;
	public ManageAllButtons manageallbuttons;
	void Start () {
		var audios = GetComponents<AudioSource> ();
		push = audios [0];
		exit = audios [1];
	}
	void OnTriggerEnter(Collider other){
		manageallbuttons.Upcount_W ();
		howmanypeople = manageallbuttons.Gethowmanypeople_W ();
		if (howmanypeople == 1) {
			if (!push.isPlaying)
				push.Play ();
			for (int i = 0; i < whitedoors.Length; i++) {
				whitedoors [i].SetActive (false);
			}
		}
	}
	void OnTriggerExit(Collider other){
		manageallbuttons.Downcount_W ();
		howmanypeople = manageallbuttons.Gethowmanypeople_W ();
		if (howmanypeople == 0) {
			if (!exit.isPlaying)
				exit.Play ();
			for (int i = 0; i < whitedoors.Length; i++) {
				whitedoors [i].SetActive (true);
			}
		}
	}
}
