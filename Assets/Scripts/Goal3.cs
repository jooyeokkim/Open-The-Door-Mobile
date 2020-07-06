using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal3 : MonoBehaviour {
	public Goals goals;
	AudioSource push;
	AudioSource exit;
	int howmanypeople;
	void Start(){
		howmanypeople = 0;
		var audios = GetComponents<AudioSource> ();
		push = audios [0];
		exit = audios [1];
	}
	void OnTriggerEnter(Collider other){
		push.Play ();
		howmanypeople++;
		if (howmanypeople == 1) goals.UpCount ();
	}
	void OnTriggerExit(Collider other){
		exit.Play ();
		howmanypeople--;
		if (howmanypeople == 0) goals.DownCount ();
	}
}
