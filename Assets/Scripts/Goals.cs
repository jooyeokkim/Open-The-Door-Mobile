using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goals : MonoBehaviour {
	int count;
	float gamerecord;
	public Text[] dia;
	public Button diareward;
	public Text diarewardtext;
	string minstring;
	string secstring;
	string millisecstring;
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
			gamerecord = time.getrecord();
			for (int i = 0; i < 4; i++) {
				minstring = dia [i].text.ToString ().Substring (0, 2);
				secstring = dia [i].text.ToString ().Substring (3, 2);
				millisecstring = dia [i].text.ToString ().Substring (6, 2);
				int min = (minstring [0] - '0') * 10 + (minstring [1] - '0');
				int sec = (secstring [0] - '0') * 10 + (secstring [1] - '0');
				float millisec = (millisecstring [0] - '0') * 10 + (millisecstring [1] - '0');
				if(gamerecord<=(min*60+sec+millisec/100)){
					Debug.Log (gamerecord + "and" + (min * 60 + sec + millisec/100));
					diarewardtext.text = "+0"+(4-i);
					dia[i].color = new Color (0.9f, 0.1f, 0.1f);
					break;
				}
				if (i == 3 && gamerecord > (min * 60 + sec + millisec/100)) {
					diarewardtext.text = "+00";
					Debug.Log (gamerecord + "and" + (min * 60 + sec + millisec/100));
				}
			}
			isgameover = true;
			diareward.gameObject.SetActive (true);
			clearpanel.SetActive (true);
		}
	}
	public void DownCount() {
		if (!isgameover) count--;
	}
}
