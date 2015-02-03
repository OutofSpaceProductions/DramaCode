using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeInButton : MonoBehaviour 
{
	public bool fadeIn = true;
	public GameObject Music;
	public Text fadeTimeValue;
	float FadeTime;


	void Start()
	{
		gameObject.SetActive(true);
	}

	void Update()
	{
		/*
		 if(fadeTimeValue != null)
		{
			FadeTime = float.Parse(fadeTimeValue.text);
		}
		else
		{
			FadeTime = 1;
		}
		*/
	}


	public void Clicked()
	{
		//Music.SendMessage("WaitNFaid", SendMessageOptions.DontRequireReceiver);

	}
}
