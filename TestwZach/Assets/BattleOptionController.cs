using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleOptionController : MonoBehaviour
{
    public int highlightedOption; // This is for storing which item is highlighted
    private GameObject menuitem1; // this stores opt 1
    private GameObject menuitem2; // opt 2
    private GameObject menuitem3; // opt 3 

    public void changeHighlight() {
        UIController MIS1 = menuitem1.GetComponent<UIController>(); // gets all components from menuitem scripts aka HIGHLIGHTED
        UIController MIS2 = menuitem2.GetComponent<UIController>();
        UIController MIS3 = menuitem3.GetComponent<UIController>();

        MIS1.highlighted = false; //sets values to false 
        MIS2.highlighted = false;
        MIS3.highlighted = false;

        highlightedOption = Random.Range(1, 4); // Randomly switches which is highlighted (upper limit has to be +1)

        //Debug.Log("changed highlight to " + highlightedOption);

        switch (highlightedOption) {
            case 1:
                MIS1.highlighted = true;
                break;
            case 2:
                MIS2.highlighted = true;
                break;
            case 3:
                MIS3.highlighted = true;
                break;
        }
    }
    // Start is called before the first frame update
    void Start() {
        menuitem1 = GameObject.Find("UI_Laser"); //init all game objects and such you want to manipulate
        menuitem2 = GameObject.Find("UI_Missle");
        menuitem3 = GameObject.Find("UI_Shield");
        InvokeRepeating("changeHighlight", 1.0f, 1.0f);
        lastTime = Time.time; //init start time (to track delay between choices)
    }

    // Update is called once per frame
    public GameObject Missile;
    public GameObject Lazer;
    public GameObject Shield;
    public GameObject Player;

    public float timeBetweenWeapons;
    private float lastTime;

    public static bool Shielded = false;
    void Update() {
        if (timeBetweenWeapons - (Time.time - lastTime) > 0)
            CooldownDisplay.Counter = (timeBetweenWeapons - (Time.time - lastTime));
        else
            CooldownDisplay.Counter = 0f;

        if (GameObject.Find("ShieldCloneP")) {
            Shielded = true;
            print("P shields up");
        }
        else
            Shielded = false;




        GameObject clone;
        GameObject ShieldCloneP;
        Player = GameObject.Find("shipPlayer");
        var PlayerPos = Player.GetComponent<Transform>();
        if (Time.time - lastTime > timeBetweenWeapons) {
            if (Input.GetKeyDown("space")) {
                //print("space key was pressed");
                if (highlightedOption == 1) {
                    //Debug.Log("FIRE M");
                    // Instantiate the projectile at the position and rotation of this transform

                    clone = Instantiate(Lazer, transform.position, transform.rotation);
                    timeBetweenWeapons = 7;
                }
                if (highlightedOption == 2) {
                    //Debug.Log("FIRE L");
                    clone = Instantiate(Missile, transform.position, transform.rotation);
                    timeBetweenWeapons = 10;
                }
                if (highlightedOption == 3) {
                    //Debug.Log("act sh");
                    ShieldCloneP = Instantiate(Shield, PlayerPos.transform.position, PlayerPos.transform.rotation);
                    Destroy(ShieldCloneP, 3);
                    //ADD VARIABLE BOOL SHIELD UP OR NAH 
                    //If shieldClone != exist then shield down > put this in update ^
                    timeBetweenWeapons = 2;
                }
                lastTime = Time.time;
            }
        }

 
    }
}
