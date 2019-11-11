using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownDisplay : MonoBehaviour
{
    public Text CooldownText;  // public if you want to drag your text object in there manually
    public static float Counter;

    void Start() {
        CooldownText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
    }

    void Update() {
        CooldownText.text = Counter.ToString();  // make it a string to output to the Text object
    }
}
