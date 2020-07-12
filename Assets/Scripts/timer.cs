using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	private Text timertext;
	private float time;
	private float starttime;
	private bool isplaying;
	private int intmin;
	private int intsecond;
	private float floatmillisecond;
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
			intmin = (int)time / 60;
			intsecond = (int)time % 60;
			floatmillisecond = (time % 1) * 100;
			string min = intmin.ToString ();
			string second = intsecond.ToString ();
			string millisecond = floatmillisecond.ToString ("f0");
			if (intmin < 10)
				min = "0" + min;
			if (intsecond < 10)
				second = "0" + second;
			if (floatmillisecond < 10)
				millisecond = "0" + millisecond;
			if (floatmillisecond >= 99)
				millisecond = "99";
			timertext.text = min + ":" + second + ":" + millisecond;
		} else
			timertext.color = new Color (0.9f, 0.1f, 0.1f);
	}
	public void gameover(){
		isplaying = false;
	}
	public float getrecord(){
		return intmin * 60 + intsecond + floatmillisecond / 100;
	}	
}
