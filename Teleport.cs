using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : Interactable
{
	private SpriteRenderer T_SpriteRenderer;
	private VGUI T_VGUI;
	private float T_VGUITimer;
	private bool T_StartVGUITimer;
	public static int T_Counter;
	public string T_SceneName;

	private void Start()
	{
		T_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		if(T_VGUI = GameObject.Find("VGUI").GetComponent<VGUI>())
		{

		}
		else
		{
			Debug.Log("Teleporter cannot find VGUI");
		}
		T_VGUITimer = 2.0f;
		T_StartVGUITimer = false;
	}

	private void Update()
	{
		if(T_Counter ==4)
		{
			T_SpriteRenderer.color = Color.white;
		}

		if(T_StartVGUITimer)
		{
			if(T_VGUITimer>0.0f)
			{
				T_VGUITimer -= Time.deltaTime;
			}
			else
			{
				T_VGUI.V_Dialogue2 = false;
				T_StartVGUITimer = false;
				T_VGUITimer = 2.0f;
			}
		}
	}

	public override void I_Activate()
	{
		if (T_SceneName != "Home")
		{
			SceneManager.LoadScene(T_SceneName);
		}
		else if (T_SceneName == "Home" && T_Counter==4)
		{
			SceneManager.LoadScene(T_SceneName);
		}
		else
		{
			T_StartVGUITimer = true;
			T_VGUI.V_Dialogue2 = true;
			T_VGUI.V_ShowThisDialogue("I can't go back yet...");
		}
	}
}
