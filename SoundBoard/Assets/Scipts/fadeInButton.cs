using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeInButton : MonoBehaviour 
{
	public bool fadeIn = true;
	public Slider fadeTimeValue;
	public Text fadeTimeText;
	public float FadeTime;
	gameManager GameManager;

	bool fading = false;

	void Start()
	{
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		GameManager = gameController.GetComponent<gameManager>();
	}

	void Update()
	{
		Debug.Log(GameManager.volume.value);
		fadeTimeValue.value = Mathf.Round(fadeTimeValue.value);
		fadeTimeText.text = "" + fadeTimeValue.value;

		if(fading == true)
		{
			GameManager.volume.value = Mathf.Lerp(GameManager.volume.value, 0.0f, fadeTimeValue.value * Time.deltaTime);
		}
		if(GameManager.volume.value <= 0.025f)
		{
			fading = false;
			GameManager.volume.value = 1;
		}

	}



	public void Clicked()
	{
		fading = true;
	}

}
