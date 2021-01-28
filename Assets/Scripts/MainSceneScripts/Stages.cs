using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stages : MonoBehaviour
{
	public GameObject scrollbar;
	public GameObject loading;
	private float scroll_pos = 0;
	float[] pos;
	void Start(){
		scrollbar.GetComponent<Scrollbar> ().value = (float) 30 / 40;
		scroll_pos = (float) 30 / 40;
	}
	void Update()
	{
		pos = new float[transform.childCount];
		float distance = 1f / (pos.Length - 1f);
		for (int i = 0; i < pos.Length; i++)
		{
			pos[i] = distance * i;
		}

		if (Input.GetMouseButton(0))
		{
			scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
		}
		else
		{
			for (int i = 0; i < pos.Length; i++)
			{
				if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
				{
					scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
				}
			}
		}
		for (int i = 0; i < pos.Length; i++)
		{
			if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
			{
				transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.2f, 1.2f), 0.1f);
				for (int j = 0; j < pos.Length; j++)
				{
					if (j!=i)
					{
						transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
					}
				}
			}
		}
	}
	public void SelectStage1(){SceneManager.LoadScene (3); loading.SetActive (true);}
	public void SelectStage2(){SceneManager.LoadScene (4); loading.SetActive (true);}
	public void SelectStage3(){SceneManager.LoadScene (5); loading.SetActive (true);}
	public void SelectStage4(){SceneManager.LoadScene (6); loading.SetActive (true);}
	public void SelectStage5(){SceneManager.LoadScene (7); loading.SetActive (true);}
	public void SelectStage6(){SceneManager.LoadScene (8); loading.SetActive (true);}
	public void SelectStage7(){SceneManager.LoadScene (9); loading.SetActive (true);}
	public void SelectStage8(){SceneManager.LoadScene (10); loading.SetActive (true);}
	public void SelectStage9(){SceneManager.LoadScene (11); loading.SetActive (true);}
	public void SelectStage10(){SceneManager.LoadScene (12); loading.SetActive (true);}
	public void SelectStage11(){SceneManager.LoadScene (13); loading.SetActive (true);}
	public void SelectStage12(){SceneManager.LoadScene (14); loading.SetActive (true);}
	public void SelectStage13(){SceneManager.LoadScene (15); loading.SetActive (true);}
	public void SelectStage14(){SceneManager.LoadScene (16); loading.SetActive (true);}
	public void SelectStage15(){SceneManager.LoadScene (17); loading.SetActive (true);}
	public void SelectStage16(){SceneManager.LoadScene (18); loading.SetActive (true);}
	public void SelectStage17(){SceneManager.LoadScene (19); loading.SetActive (true);}
	public void SelectStage18(){SceneManager.LoadScene (20); loading.SetActive (true);}
	public void SelectStage19(){SceneManager.LoadScene (21); loading.SetActive (true);}
	public void SelectStage20(){SceneManager.LoadScene (22); loading.SetActive (true);}
	public void SelectStage21(){SceneManager.LoadScene (23); loading.SetActive (true);}
	public void SelectStage22(){SceneManager.LoadScene (24); loading.SetActive (true);}
	public void SelectStage23(){SceneManager.LoadScene (25); loading.SetActive (true);}
	public void SelectStage24(){SceneManager.LoadScene (26); loading.SetActive (true);}
	public void SelectStage25(){SceneManager.LoadScene (27); loading.SetActive (true);}
	public void SelectStage26(){SceneManager.LoadScene (28); loading.SetActive (true);}
	public void SelectStage27(){SceneManager.LoadScene (29); loading.SetActive (true);}
	public void SelectStage28(){SceneManager.LoadScene (30); loading.SetActive (true);}
	public void SelectStage29(){SceneManager.LoadScene (31); loading.SetActive (true);}
	public void SelectStage30(){SceneManager.LoadScene (32); loading.SetActive (true);}
	public void SelectStage31(){SceneManager.LoadScene (33); loading.SetActive (true);}
	public void SelectStage32(){SceneManager.LoadScene (34); loading.SetActive (true);}
	public void SelectStage33(){SceneManager.LoadScene (35); loading.SetActive (true);}
	public void SelectStage34(){SceneManager.LoadScene (36); loading.SetActive (true);}
	public void SelectStage35(){SceneManager.LoadScene (37); loading.SetActive (true);}
	public void SelectStage36(){SceneManager.LoadScene (38); loading.SetActive (true);}
	public void SelectStage37(){SceneManager.LoadScene (39); loading.SetActive (true);}
	public void SelectStage38(){SceneManager.LoadScene (40); loading.SetActive (true);}
	public void SelectStage39(){SceneManager.LoadScene (41); loading.SetActive (true);}
	public void SelectStage40(){SceneManager.LoadScene (42); loading.SetActive (true);}
}
