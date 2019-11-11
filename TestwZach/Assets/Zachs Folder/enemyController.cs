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


    public int battleNum = 1;

    //Enemy Health
    private int initialHealth = 100;

    //Time inbetween weapon
    private float timeBetweenWeapons;
    private float lastTime;

    //Weapon Preference
    private int laserLimit = 33;
    private int missleLimit = 33;
    private int shieldLimit = 33;



    // Start is called before the first frame update*************************************************************
    void Start(){
        anim = GetComponent<Animator>();
        anim.SetBool("inScene", false);
        lastTime = Time.time;
    }

    //Enemy properties based on battle number
    private void enemyProperties() {
        switch (battleNum) {
            case 1:
                laserLimit = 33;
                missleLimit = 33;
                shieldLimit = 33;
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
        }
        return;
    }

    // Update is called once per frame***************************************************************************
    void Update() {
        //Check if battle scene is active
        scene = SceneManager.GetActiveScene();
        if (scene.name.Equals("Zachs Scene")) {
            anim.SetBool("inScene", true);
        }
        else
            anim.SetBool("inScene", false);


        //Use weapon if enough time has passed
        if (Time.time-lastTime>timeBetweenWeapons) { 
            chooseWeapon();
            lastTime = Time.time;
        }    
    }

    //Choose Weapon to Use
    private void chooseWeapon() {
        //Randomly choose weapon:
        int weapon = 0;
        // 1 - Laser
        // 2 - Missle
        // 3 - Shield
        int rand = Random.Range(1, 99);
        if (rand < laserLimit)
            weapon = 1;
        else if (rand < missleLimit && rand > laserLimit)
            weapon = 2;
        else
            weapon = 3;
        useWeapon(weapon);
        return;
    }

    //Use Weapon
    private void useWeapon(int weapon) {
        switch (weapon) {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
        }
        return;
    }
}
