using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAllButtons : MonoBehaviour {
	int howmanypeople_R;
	int howmanypeople_G;
	int howmanypeople_B;
	int howmanypeople_P;
	int howmanypeople_W;
	void Start () {
		howmanypeople_R = 0;
		howmanypeople_G = 0;
		howmanypeople_B = 0;
		howmanypeople_P = 0;
		howmanypeople_W = 0;
	}
	public void Upcount_R() { howmanypeople_R++;}
	public void Upcount_G() { howmanypeople_G++;}
	public void Upcount_B() { howmanypeople_B++;}
	public void Upcount_P() { howmanypeople_P++;}
	public void Upcount_W() { howmanypeople_W++;}
	public void Downcount_R() { howmanypeople_R--;}
	public void Downcount_G() { howmanypeople_G--;}
	public void Downcount_B() { howmanypeople_B--;}
	public void Downcount_P() { howmanypeople_P--;}
	public void Downcount_W() { howmanypeople_W--;}
	public int Gethowmanypeople_R(){return howmanypeople_R;}
	public int Gethowmanypeople_G(){return howmanypeople_G;}
	public int Gethowmanypeople_B(){return howmanypeople_B;}
	public int Gethowmanypeople_P(){return howmanypeople_P;}
	public int Gethowmanypeople_W(){return howmanypeople_W;}
}
