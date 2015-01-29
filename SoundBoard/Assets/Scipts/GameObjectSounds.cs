using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameObjectSounds : MonoBehaviour {

	gameManager GameManager;
	public Color activeColor;
	public Color notActiveColor;
	public bool clicked = false;

	void Start () 
	{
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		GameManager = gameController.GetComponent<gameManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		audio.volume = GameManager.volume.value;
		if(clicked == false)
		{
			audio.Play();
		}
	}

	public void Clicked()
	{
		clicked = !clicked;
		if(clicked == true)
		{
			GetComponent<Image>().color = activeColor;
		}
		else
		{
			GetComponent<Image>().color = notActiveColor;

		}
	}
}
