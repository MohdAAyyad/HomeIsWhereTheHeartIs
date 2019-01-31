using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeEnd : MonoBehaviour
{
	private Animator FB_FadeOutAnimator;
	private bool FB_InterimScreen;
	public string FB_Title;
	public string FB_Subtitle;
	public int FB_indexInBuild;
	public Text FB_CreditsText;
	public Text FB_TitleText;
	public Text FB_TileSubText;
	public GameObject FB_FadeOut;


	void Start()
	{
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
			FB_CreditsText.transform.position = new Vector3(FB_CreditsText.transform.position.x, FB_CreditsText.transform.position.y + 1.0f, FB_CreditsText.transform.position.z);
		}
	}

	public void fadeOutToScene()
	{

		FB_FadeOutAnimator.SetBool("FadeOut", true);
	}

	private void loadScene()
	{
		SceneManager.LoadScene(FB_indexInBuild);
	}

	public void startPlayer()
	{
		FB_InterimScreen = true;
	}

	public void freezePlayer()
	{
		FB_InterimScreen = true;
	}

}
