using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : Interactable
{
	private bool K_Dialogue;
	private float K_DialogueTimer;
	public SpriteRenderer K_SpriteRenderer;
	public string K_Season;
	private VGUI K_VGUI;

	private void Start()
	{
		K_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		K_DialogueTimer = 2.0f;
		if(K_VGUI = GameObject.Find("VGUI").GetComponent<VGUI>())
		{

		}
		else
		{
			Debug.Log("Key Cannot find VGUI");
		}
	}


	private void Update()
	{
		if(K_Dialogue)
		{
			if(K_DialogueTimer>0.0f)
			{
				K_DialogueTimer -= Time.deltaTime;
			}
			else
			{
				K_Dialogue = false;
				K_VGUI.V_Dialogue2 = false;
				K_DialogueTimer = 2.0f;
				SceneManager.LoadScene("Hub");

			}
		}
	}

	public override void I_Activate()
	{
		FadeBehaviour.FB_Counter++;
		
		switch(K_Season)
		{
			case "Autumn":
				FadeBehaviour.FB_Autumn = true;
				break;
			case "Spring":
				FadeBehaviour.FB_Spring = true;
				break;
			case "Summer":
				FadeBehaviour.FB_Summer = true;
				break;
			case "Winter":
				FadeBehaviour.FB_Winter = true;
				break;
		}


		K_Dialogue = true;
		K_VGUI.V_Dialogue2 = true;
		K_VGUI.V_ShowThisDialogue("Obtained key. Returning to hub...");
		K_SpriteRenderer.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
		gameObject.GetComponent<Collider2D>().enabled = false;
		AudioManager.instance.PlaySound("PickupKey");
	}
}
