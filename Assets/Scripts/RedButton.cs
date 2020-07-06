using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour {
	public GameObject[] reddoors; //original doors
	AudioSource push;
	AudioSource exit;
	public ManageAllButtons manageallbuttons;
	private int howmanypeople;
	void Start () {
		var audios = GetComponents<AudioSource> ();
		push = audios [0];
		exit = audios [1];
	}
	void OnTriggerEnter(Collider other){
		manageallbuttons.Upcount_R ();
		howmanypeople = manageallbuttons.Gethowmanypeople_R ();
		if (howmanypeople == 1) {
			if (!push.isPlaying)
				push.Play ();
			for (int i = 0; i < reddoors.Length; i++) {
				reddoors [i].SetActive (false);
			}
		}
	}
	void OnTriggerExit(Collider other){
		manageallbuttons.Downcount_R ();
		howmanypeople = manageallbuttons.Gethowmanypeople_R ();
		if (howmanypeople == 0) {
			if (!exit.isPlaying)
				exit.Play ();
			for (int i = 0; i < reddoors.Length; i++) {
				reddoors [i].SetActive (true);
			}
		}
	}
}
