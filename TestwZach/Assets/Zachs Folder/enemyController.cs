using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyController : MonoBehaviour {


    //Reference to animaton
    private Animator anim;
    //Direction variable
    private bool facingLeft = true;
    //Scene object
    private Scene scene;

    //Weapon chosing
    private int chosenWeapon = 0;
        // 0 - No weapon
        // 1 - Laser
        // 2 - Missle
        // 3 - Shield
    public int battleNum = 0;

    // Start is called before the first frame update*************************************************************
    void Start(){
        anim = GetComponent<Animator>();
        anim.SetBool("inScene", false);
    }

    //Enemy properties based on battle number
    private void enemyProperties() {
        return;
    }

    // Update is called once per frame***************************************************************************
    void Update(){
        //Check if battle scene is active
        scene = SceneManager.GetActiveScene();
        if (scene.name.Equals("Zachs Scene")) {
            anim.SetBool("inScene", true);
        }
        else
            anim.SetBool("inScene", false);


        //Decide to shoot
        if (chosenWeapon == 0)
            chooseWeapon();
        else {
            
        }

    }

    //Choose Weapon to Use
    private void chooseWeapon() {
        //Randomly choose weapon:
        chosenWeapon = Random.Range(1, 3);

        return;
    }
    //Use Weapon
    private void useWeapon() {

        return;
    }
}
