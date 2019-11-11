using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeaderTextScript : MonoBehaviour
{
    public Text PHC;  // public if you want to drag your text object in there manually
    public static string Counter;


    void Start() {
        PHC = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts 
        PHC.text = "SPACE BRAINZ: FIGHT!";
    }

    void Update() {
        PHC.text = Counter;  // make it a string to output to the Text object
    }
}
