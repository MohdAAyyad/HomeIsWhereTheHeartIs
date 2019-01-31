using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutumnMonster : MonoBehaviour
{
	public bool AM_Active;
	public static bool AM_Repsawn;
	private GameObject AM_Player;
	private Rigidbody2D AM_RigidBody;
	private Vector2 AM_DirectionToPlayer;
	private float AM_Speed;

	public GameObject[] AM_Leaves;

    // Start is called before the first frame update
    void Start()
    {
		AM_Active = false;
		AM_Repsawn = false;

		if (AM_Player = GameObject.Find("Player"))
		{
			//Do nothing
		}
		else
		{
			Debug.Log("Enemy Could not find player");
		}

		AM_RigidBody = gameObject.GetComponent<Rigidbody2D>();
		AM_Speed = 6.0f;

		gameObject.transform.position = AM_Leaves[(Random.Range(0, AM_Leaves.Length - 1))].transform.position;

	}

    // Update is called once per frame
    void Update()
    {
		//Debug.Log(AM_Repsawn);
        if(AM_Active)
		{
			AM_DirectionToPlayer = new Vector2(AM_Player.transform.position.x - gameObject.transform.position.x,
											   AM_Player.transform.position.y - gameObject.transform.position.y).normalized;

			AM_RigidBody.velocity = AM_DirectionToPlayer * AM_Speed;

			if(AM_DirectionToPlayer.x < 0.0f)
			{
				gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, 90.0f, 0.0f);
			}
			else if (AM_DirectionToPlayer.x > 0.0f)
			{
				gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, -90.0f, 0.0f);
			}
			else if (AM_DirectionToPlayer.y < 0.0f)
			{
				gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, 180.0f, 0.0f);
			}
			else if (AM_DirectionToPlayer.y > 0.0f)
			{
				gameObject.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
			}
		}

		if(AM_Repsawn)
		{
			AM_Active = false;
			AM_RigidBody.velocity = new Vector2(0.0f, 0.0f);
			gameObject.transform.position = AM_Leaves[(Random.Range(0, AM_Leaves.Length - 1))].transform.position;
			AM_Repsawn = false;
		}

		
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals("Player"))
		{
            AudioManager.instance.PlaySound("Hit");
			col.gameObject.GetComponent<PlayerMovement>().P_Respawn();
			AM_Repsawn = true;
		}
		if(col.gameObject.tag.Equals("Door"))
		{
			AM_Active = false;
			AM_RigidBody.velocity = new Vector2(0.0f, 0.0f);
			gameObject.transform.position = AM_Leaves[(Random.Range(0, AM_Leaves.Length - 1))].transform.position;

		}
	}
}
