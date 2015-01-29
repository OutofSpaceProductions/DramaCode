using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSliderColor : MonoBehaviour {

	fadeInButton fadeScript;

	void Start () 
	{
		GameObject fadeInScript = GameObject.FindGameObjectWithTag("FadeInButton");
		fadeScript = fadeInScript.GetComponent<fadeInButton>();
	}

	void Update () 
	{
		if(fadeScript.fadeIn = true)
		{
			GetComponent<Image>().color = Color.green;
		}
		else
		{
			GetComponent<Image>().color = Color.red;
		}
	}
}
