using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	private Text timertext;
	private float time;
	private float starttime;
	private bool isplaying;
	// Use this for initialization
	void Start () {
		timertext = GetComponent<Text> ();
		starttime = Time.time;
		isplaying = true;
	}

	// Update is called once per frame
	void Update () {
		if (isplaying) {
			time = Time.time - starttime;
			int intmin = (int)time / 60;
			int intsecond = (int)time % 60;
			float millisecond = (time % 1) * 98.3f;
			string min = intmin.ToString ();
			string second = intsecond.ToString ();
			if (intmin < 10)
				min = "0" + min;
			if (intsecond < 10)
				second = "0" + second;
			timertext.text = min + ":" + second + ":" + millisecond.ToString ("f0");
		} else
			timertext.color = new Color (0.9f, 0.1f, 0.1f);
	}
	public void gameover(){
		isplaying = false;
	}
}
