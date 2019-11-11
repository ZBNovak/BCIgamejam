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

    
    public int battleNum = GameStats.BattleNum;

    //Enemy Health
    public int initialHealth = 100;
    public static int health;
    GameObject healthBarEnemy;
    private float scaleWidth = .0355268F;
    private readonly float scaleX = .0371854F, scaleY = 0.009413587F, scaleZ = 0.008859847F;
    private float xWidth = .00122F;
    private readonly float x = -.19722F, y = 0, z = 0;

    public bool healthbarchanged = false; 
    //Time inbetween weapon
    public float timeBetweenWeapons;
    private float lastTime;

    //Weapon Preference
    private int laserLimit = 33;
    private int missleLimit = 33;

    //check for shields
    public bool Shielded = false;

    // Start is called before the first frame update*************************************************************
    void Start(){
        anim = GetComponent<Animator>();
        anim.SetBool("inScene", false);
        lastTime = Time.time;
        health = initialHealth;
        if (GameStats.Path == GameStats.BattleNum)
            health += 50;
        healthBarEnemy = GameObject.Find("healthBarEnemy");
        healthBarEnemy.transform.localScale = new Vector3(scaleX, scaleY, scaleZ); //init scale


    }

    //Enemy properties based on battle number
    private void enemyProperties() {
        switch (battleNum) {
            case 1:
                laserLimit = 33;
                missleLimit = 33;
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

        //check if shields are up
        if (GameObject.Find("ShieldClone")) {
            Shielded = true;
            print("en shielded");
        }
        else
            Shielded = false;




        /*
        //Change health bar if needed
        if (healthbarchanged == true) {
            calculateHealthBar();
            healthbarchanged = false;
        }
        */
    }

    void OnCollisionEnter2D(Collision2D col) {
        print("Enemy Hit");
        if (col.gameObject.tag == "Lazer") {
            print("Enemy Hit by LAzer");
            if (Shielded == false) {
                health = health - 15;
                calculateHealthBar();
            }
        }
        else {
            print("Enemy hit by missile");
            if (Shielded == false) {
                health = health - 25;
                calculateHealthBar();
            }
            else {
                health = health - 5;
                calculateHealthBar();
            }
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

    public GameObject Missile;
    public GameObject Lazer;
    public GameObject Shield;
    public GameObject SpawnforWep;
    private void useWeapon(int weapon) {
        GameObject clone;
        GameObject ShieldClone;

        var SpawnPos = SpawnforWep.GetComponent<Transform>();
        switch (weapon) {
            case 1:
                clone = Instantiate(Lazer, SpawnPos.transform.position, transform.rotation);
                timeBetweenWeapons = 9 - GameStats.BattleNum;
                break;
            case 2:
                clone = Instantiate(Missile, SpawnPos.transform.position, transform.rotation);
                timeBetweenWeapons = 12 - GameStats.BattleNum;
                break;
            case 3:
                ShieldClone = Instantiate(Shield, transform.position, transform.rotation);
                Destroy(ShieldClone, 3);
                //ADD VARIABLE BOOL SHIELD UP OR NAH 
                //If shieldClone != exist then shield down > put this in update ^
                timeBetweenWeapons = 2;
                break;
        }
        return;
    }

    private void calculateHealthBar() {
        //width = orig xwidth * health / original health
        healthBarEnemy.transform.localScale = new Vector3(((float)health / 100) * scaleWidth, scaleY, scaleZ);
        healthBarEnemy.transform.Translate(new Vector3(((float)health / 100) * xWidth, y, z));

    }
}
