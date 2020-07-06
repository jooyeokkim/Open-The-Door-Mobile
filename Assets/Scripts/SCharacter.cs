using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCharacter : MonoBehaviour {
	public Camera[] camera;
	public string Select = "C1";
	public void Change(string i){
		Select = i;
		if (i == "C1") {
			camera [0].enabled = true;
			camera [1].enabled = false;
			camera [2].enabled = false;
		}
		else if(i=="C2") {
			camera [0].enabled = false;
			camera [1].enabled = true;
			camera [2].enabled = false;
		}
		else {
			camera [0].enabled = false;
			camera [1].enabled = false;
			camera [2].enabled = true;
		}
	}
	public string GetSelect(){
		return Select;
	}
}
