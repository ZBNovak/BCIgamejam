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
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("inScene", false);
        health = 100;
        PlayerHealthCounter.Counter = health;
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

        PlayerHealthCounter.Counter = health;

    }

    void OnCollisionEnter2D(Collision2D col) {
        print("Enemy Hit");
        //BattleOptionController.Shielded = true;
        if (col.gameObject.tag == "Lazer") {
            print("Enemy Hit by LAzer");
            if (BattleOptionController.Shielded == false) {
                health = health - 15;

            }
        }
        else {
            print("Enemy hit by missile");
            if (BattleOptionController.Shielded == false) {
                health = health - 25;
            }
            else {
                health = health - 5;
            }
        }

    }
}
