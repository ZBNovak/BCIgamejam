using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{

    //Reference to animaton
    private Animator anim;
    //Scene object
    private Scene scene;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("inScene", false);
    }

    // Update is called once per frame
    void Update()
    {
        //Check if battle scene is active
        scene = SceneManager.GetActiveScene();
        if (scene.name.Equals("Zachs Scene")) {
            anim.SetBool("inScene", true);
        }
        else
            anim.SetBool("inScene", false);


    }
}
