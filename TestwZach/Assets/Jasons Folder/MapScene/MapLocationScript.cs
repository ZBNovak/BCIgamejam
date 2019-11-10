using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLocationScript : MonoBehaviour
{
	public bool highlighted1;

    
	Animator animator1;
	// Start is called before the first frame update
	void Start()
    {
		animator1 = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (highlighted1 == true)
		{
			animator1.SetBool("Highlighted", true);
		}
		else
		{
			animator1.SetBool("Highlighted", false);
		}

	}
	// create a function that will , when highlighted = true , highlight the goddam fukin thing
    
}