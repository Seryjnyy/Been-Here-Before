using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {
    public float batteryLife = 100.0f;
    float timer = 0.0f;


    void Start() {
        StartCoroutine(DecreaseBattery());
    }


    IEnumerator DecreaseBattery() {
        while(batteryLife>0) {
            yield return new WaitForSeconds(1);
            RemoveOne();
        }
    }

    void RemoveOne() {
        batteryLife--;
    }
}

