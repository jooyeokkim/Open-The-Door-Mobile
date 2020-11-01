using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleButton : MonoBehaviour {
	public GameObject[] purpledoors; //original doors
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
		manageallbuttons.Upcount_P ();
		howmanypeople = manageallbuttons.Gethowmanypeople_P ();
		if (howmanypeople == 1) {
			if (!push.isPlaying)
				push.Play ();
			for (int i = 0; i < purpledoors.Length; i++) {
				purpledoors [i].SetActive (false);
			}
		}
	}
	void OnTriggerExit(Collider other){
		manageallbuttons.Downcount_P ();
		howmanypeople = manageallbuttons.Gethowmanypeople_P ();
		if (howmanypeople == 0) {
			if (!exit.isPlaying)
				exit.Play ();
			for (int i = 0; i < purpledoors.Length; i++) {
				purpledoors [i].SetActive (true);
			}
		}
	}
}
