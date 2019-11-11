using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeaderTextScript : MonoBehaviour
{
    public Text PHC;  // public if you want to drag your text object in there manually
    public static string Counter;


    void Start() {
        PHC = GetComponent<Text>();
        Counter = SceneManager.GetActiveScene().name;// if you want to reference it by code - tag it if you have several texts 
        PHC.text = Counter.ToString();
    }

    void Update() {
        PHC.text = Counter;  // make it a string to output to the Text object
    }
}
