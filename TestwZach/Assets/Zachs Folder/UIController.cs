using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public bool highlighted = false;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (highlighted == true) 
            animator.SetBool("Highlighted", true);
        else 
            animator.SetBool("Highlighted", false);
    }
}
