using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour {
	public GameObject Characters;
	public int speed;
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, speed * Time.deltaTime, 0);
	}

	void OnTriggerStay(Collider other){
		Debug.Log (other.tag[0]);
		if (other.tag [0] == 'C') {
			other.transform.parent = gameObject.transform;
		}
	}
	void OnTriggerExit(Collider other){
		Debug.Log ("Exit");
		if (other.tag [0] == 'C') {
			other.transform.parent = Characters.transform;
		}
	}
}
