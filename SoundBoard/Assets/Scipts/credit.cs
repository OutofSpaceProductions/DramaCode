using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class credit : MonoBehaviour {

	public GameObject creditGameObject;
	bool showCredits = false;
	gameManager GameManager;

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
