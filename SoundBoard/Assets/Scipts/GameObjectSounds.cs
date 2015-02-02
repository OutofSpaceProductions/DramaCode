using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameObjectSounds : MonoBehaviour {

	gameManager GameManager;
	public Color activeColor;
	public Color notActiveColor;
	public bool clicked = false;

	Animator anim;

	void Start () 
	{
		gameObject.SetActive(true);
		anim = GetComponent<Animator>();
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
		if(Input.GetKeyDown(KeyCode.F))
		{
			SendMessage("F", SendMessageOptions.DontRequireReceiver);
		}
	}

	void WaitNFaid (float fadeTime)
	{
		Debug.Log(audio.volume);
		audio.volume = Mathf.Lerp(audio.volume, 0.0f, fadeTime);
	}

	/*public IEnumerator Fade ()
	{
		Debug.Log("Waiting ");
		//anim.SetBool("Fade", true);
		clicked = false;
	}
	*/

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
