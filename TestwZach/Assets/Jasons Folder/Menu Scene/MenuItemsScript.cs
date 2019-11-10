using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemsScript : MonoBehaviour
{
    public bool highlighted;

    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>(); 
    }// this starts the "Idle" animation 

    void Update()
    {
        if (highlighted==true)
        {
            animator.SetBool("Highlighted", true);
        }
        else
        {
            animator.SetBool("Highlighted", false);
        }

    }
    // create a function that will , when highlighted = true , highlight the goddam fukin thing
}
