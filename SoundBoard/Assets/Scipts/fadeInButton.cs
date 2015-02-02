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
		FadeTime = float.Parse(fadeTimeValue.text);
	}


	public void Clicked()
	{
		Music.SendMessage("WaitNFaid",FadeTime, SendMessageOptions.DontRequireReceiver);

	}
}
