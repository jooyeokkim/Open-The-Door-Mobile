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
		scrollbar.GetComponent<Scrollbar> ().value = (float) 2 / 6;
		scroll_pos = (float) 2 / 6;
	}
	void Update()
	{
		Debug.Log (scroll_pos);
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
}
