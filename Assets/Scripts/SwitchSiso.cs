using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSiso : MonoBehaviour {
	public Rigidbody[] blocks;
	AudioSource push;
	AudioSource exit;
	void Start () {
		var audios = GetComponents<AudioSource> ();
		push = audios [0];
		exit = audios [1];
		for (int i = 0; i < blocks.Length; i++) {
			if (i % 2 == 0)
				blocks [i].mass = 10.0f;
			else
				blocks [i].mass = 0f;
		}
	}
	void OnTriggerEnter(Collider other){
		if (!push.isPlaying)
			push.Play ();
		for (int i = 0; i < blocks.Length; i++) {
			if (i % 2 == 1)
				blocks [i].mass = 10.0f;
			else
				blocks [i].mass = 0f;
		}
	}
	void OnTriggerExit(Collider other){
		if (!exit.isPlaying)
			exit.Play ();
		for (int i = 0; i < blocks.Length; i++) {
			if (i % 2 == 0)
				blocks [i].mass = 10.0f;
			else
				blocks [i].mass = 0f;
		}
	}
}

