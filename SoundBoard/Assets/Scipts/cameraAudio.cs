using UnityEngine;
using System.Collections;

public class cameraAudio : MonoBehaviour {

	public GameObject VicotrianMusic;
	public GameObject Horse;
	public bool noListener;

	void Start () 
	{
		GetComponent<AudioListener>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(VicotrianMusic.GetComponent<GameObjectSounds>().clicked == true || Horse.GetComponent<GameObjectSounds>().clicked == true)
		{
			noListener = false;
		}
		else
		{
			noListener = true;
		}
		if(noListener == true)
		{
			GetComponent<AudioListener>().enabled = false;
		}
		else 
		{
			GetComponent<AudioListener>().enabled = true;
		}
	}
}
