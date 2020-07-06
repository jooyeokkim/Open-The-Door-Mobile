using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour {
	public GameObject[] greendoors; //original doors
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
		manageallbuttons.Upcount_G ();
		howmanypeople = manageallbuttons.Gethowmanypeople_G ();
		if (howmanypeople == 1) {
			if (!push.isPlaying)
				push.Play ();
			for (int i = 0; i < greendoors.Length; i++) {
				greendoors [i].SetActive (false);
			}
		}
	}
	void OnTriggerExit(Collider other){
		manageallbuttons.Downcount_G ();
		howmanypeople = manageallbuttons.Gethowmanypeople_G ();
		if (howmanypeople == 0) {
			if (!exit.isPlaying)
				exit.Play ();
			for (int i = 0; i < greendoors.Length; i++) {
				greendoors [i].SetActive (true);
			}
		}
	}
}
