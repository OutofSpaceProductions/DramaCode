using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public Color Color0;
	public Color Color3;
	public Color Color5;
	Color currentColor;
	Color nextColor;
	Text text;

	public Slider ColorChangerSlider;

	void Start()
	{
		text = GetComponent<Text>();
		text.color = Color0;
	}

	void Update () 
	{
		currentColor = this.text.color;

		if(ColorChangerSlider.value > 4.5f)
		{
			nextColor = Color5;
		}
		if(ColorChangerSlider.value > 1.1f && ColorChangerSlider.value < 4.4f)
		{
			nextColor = Color3;
		}
		if(ColorChangerSlider.value < 1.0f)
		{
			nextColor = Color0;
		}

		text.color = Color.Lerp(currentColor, nextColor, 1.0f * Time.deltaTime);
	}
}
