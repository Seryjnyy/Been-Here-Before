using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battery : MonoBehaviour {
    public float batteryLife = 20.0f;
    float timer = 0.0f;
    [SerializeField]public LevelMetaData level;


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
        if(batteryLife < 3){
            Debug.Log( "Endddddd");
        SceneManager.LoadScene("GameOver");
        }else{
        batteryLife--;
        level.batteryCount=batteryLife;
        }

    }
}

