using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeBegin : MonoBehaviour
{
	private Animator FB_FadeOutAnimator;
	private bool FB_InterimScreen;
	public string FB_Title;
	public string FB_Subtitle;
	public int FB_indexInBuild;
	public Text FB_StartText;
	public Text FB_QuitText;
	public Text FB_TitleText;
	public Text FB_TileSubText;
	public GameObject FB_FadeOut;


	void Start()
	{
		Cursor.visible = true;
		FB_FadeOutAnimator = gameObject.GetComponent<Animator>();
		FB_FadeOutAnimator.SetBool("FadeOut", false);
		FB_InterimScreen = false;

	}

	private void Update()
	{

		if (FB_InterimScreen)
		{
			FB_TitleText.text = FB_Title;
			FB_TileSubText.text = FB_Subtitle;
			FB_StartText.enabled = true;
			FB_QuitText.enabled = true;
		}
	}

	public void fadeOutToScene()
	{

		FB_FadeOutAnimator.SetBool("FadeOut", true);
	}

	public void startPlayer()
	{
		FB_InterimScreen = true;
	}

	public void freezePlayer()
	{
		FB_InterimScreen = true;
	}

	public void FB_LoadHub()
	{
		SceneManager.LoadScene("Hub");
	}

	public void FB_Quit()
	{
		Application.Quit();
	}
}
