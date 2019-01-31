using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
	private Animator S_Animator;
	public GameObject S_Key;
	public string S_Origin;

	private void Start()
	{
		S_Animator = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
    {
        if(S_Animator.GetCurrentAnimatorStateInfo(0).IsName("End"))
		{
			GameObject Key;
			Key = Instantiate(S_Key, gameObject.transform.position, gameObject.transform.rotation);
			switch (S_Origin)
			{
				case "Autumn":
					Key.GetComponent<SpriteRenderer>().color = Color.red;
					Key.GetComponent<Key>().K_Season = S_Origin;
					break;
				case "Summer":
					Key.GetComponent<Key>().K_Season = S_Origin;
					break;
				case "Winter":
					Key.GetComponent<SpriteRenderer>().color = Color.grey;
					Key.GetComponent<Key>().K_Season = S_Origin;
					break;
				case "Spring":
					Key.GetComponent<SpriteRenderer>().color = Color.green;
					Key.GetComponent<Key>().K_Season = S_Origin;
					break;
			}
			Destroy(gameObject);
		}
		
    }
}
