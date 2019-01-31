using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart : Interactable
{
	public override void I_Activate()
	{
		SceneManager.LoadScene("Ending");
	}
}
