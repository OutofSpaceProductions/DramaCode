using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class credit : MonoBehaviour {

	public GameObject creditGameObject;
	bool showCredits = false;

	void Start()
	{
		creditGameObject.SetActive(false);
	}

	void Update()
	{
		if(showCredits == true)
		{
			creditGameObject.SetActive(true);
		}

		else
		{
			creditGameObject.SetActive(false);
		}
	}

	public void ShowCredits()
	{
		showCredits = !showCredits;
	}
}
