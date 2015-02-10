using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameObjectSounds : MonoBehaviour {

	gameManager GameManager;
	public Color activeColor;
	public Color notActiveColor;
	public bool clicked = false;
	bool fadeIn = false;

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

		if(GameManager.volume.value <= 0.026f)
		{
			clicked = false;
			GetComponent<Image>().color = notActiveColor;
		}
	}

	/*IEnumerator fadeInFunction ()
	{
		yield return new WaitForSeconds(1f);
		anim.SetBool("Fade Out", true);
		clicked = false;
	}

	void WaitNFaid ()
	{
		if(audio.volume > 0.0f)
		{
		audio.volume = Mathf.Lerp(audio.volume, 0.0f, fadeTime);
		if(audio.volume == 0.0f)
				break;
		}


		anim.SetBool("Fade Out", true);
		fadeIn = true;

	}

	public IEnumerator Fade ()
	{
		Debug.Log("Waiting ");
		//anim.SetBool("Fade", true);
		clicked = false;
	}
	*/

	public void Clicked()
	{
		if(Input.touchCount == 2)
		{
			Debug.Log("Play Sound 2");
		}
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
