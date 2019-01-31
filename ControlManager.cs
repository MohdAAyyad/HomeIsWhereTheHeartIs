using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
	public static bool CM_PlayerControl;
	private VGUI CM_VGUI;
    // Start is called before the first frame update
    void Start()
    {
		CM_PlayerControl = true;
		CM_VGUI = GameObject.Find("VGUI").GetComponent<VGUI>();

	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
		{
			CM_PlayerControl = !CM_PlayerControl;

			if(CM_PlayerControl)
			{
				CameraScript.C_FollowPlayer = true;
				CM_VGUI.V_RtoReturn = false;
			}
			else
            {
                CameraScript.C_FollowPlayer = false;
                CM_VGUI.V_RtoReturn = true;
			}
		}
    }
}
