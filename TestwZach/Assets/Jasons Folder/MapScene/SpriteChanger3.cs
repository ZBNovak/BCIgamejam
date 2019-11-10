using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger3 : MonoBehaviour
{
	public Sprite[] brainSprites;
    GameObject brain1;// create the object
    GameObject brain2;
    GameObject brain3;
    GameObject brain4;

    void Awake()
	{
		// load all frames in fruitsSprites array
		brainSprites = Resources.LoadAll<Sprite>("Brains2");
	}

	void Start()
	{
		
		//GameObject brain = new GameObject();
		brain1 = GameObject.Find("PBLocation");
        brain2 = GameObject.Find("PBLocation (1)");
        brain3 = GameObject.Find("PBLocation (2)");
        brain4 = GameObject.Find("PBLocation (3)");
        //brain1.AddComponent<SpriteRenderer>();// add a "SpriteRenderer" component to the newly created object
        //brain2.AddComponent<SpriteRenderer>();
        //brain3.AddComponent<SpriteRenderer>();
        //brain4.AddComponent<SpriteRenderer>();


        

    }

    void ChangeSprite()
    {
        MapLocationScript MLS1 = brain1.GetComponent<MapLocationScript>(); // gets all components from mapitem scripts aka HIGHLIGHTED
        //MapLocationScript MLS2 = brain2.GetComponent<MapLocationScript>();
        //MapLocationScript MLS3 = brain3.GetComponent<MapLocationScript>();
        //MapLocationScript MLS4 = brain3.GetComponent<MapLocationScript>();



        if (MLS1.highlighted1 == true)
        {
            brain1.GetComponent<SpriteRenderer>().sprite = brainSprites[1];
        }// set to green brain


        //brain2.GetComponent<SpriteRenderer>().sprite = brainSprites[1];
        //brain3.GetComponent<SpriteRenderer>().sprite = brainSprites[1];
        //brain4.GetComponent<SpriteRenderer>().sprite = brainSprites[1];
    }

    void Update()
    {
        ChangeSprite();


    }

}
