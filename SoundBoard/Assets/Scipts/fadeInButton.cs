using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeInButton : MonoBehaviour 
{
	public bool fadeIn = true;
	public Slider fadeInSlider;

	void Update()
	{
		if(fadeIn == true)
		{
			fadeInSlider.value = 1;
		}
		if(fadeIn == false)
		{
			fadeInSlider.value = 0;
		}
	}
	public void Clicked()
	{
		Debug.Log("FadeIN");
		fadeIn = !fadeIn;
	}
}
