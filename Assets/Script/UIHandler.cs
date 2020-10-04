using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] float battery;
    [SerializeField] Text healthText;

    public int gameTime = 1200;

    public Image img;
    public Battery flashlightBattery;
    public int batteryScale = 3000;

    void Start() {
        GameObject flashLight = GameObject.Find("Flashlight");
        flashlightBattery=flashLight.GetComponent<Battery>();
        
    }

    void Update()
    {
        battery=flashlightBattery.batteryLife;
        healthText.text="Battery = "+battery;
        img.rectTransform.localScale = new Vector3(battery/batteryScale, img.rectTransform.localScale.y, img.rectTransform.localScale.z);
        //if(Input.GetKeyDown(KeyCode.S)) {
        //    battery--;
        //    img.rectTransform.localScale += new Vector3(4.0f,0,0);
        //}


    }
}
