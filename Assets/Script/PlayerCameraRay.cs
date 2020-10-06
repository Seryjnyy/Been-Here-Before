using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRay : MonoBehaviour
{
    public Camera camera;
    public Battery battery;
    bool showPrompt = false;
    string pressKeyToOpen = "Press E to open";
    string pressKeyToBattery = "Press E to recharge";
    string prompt = null;

    void Start() {
        camera=Camera.main;
        battery=GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Battery>();
    }
    void Update()
    {
        showPrompt=false;
        RayCastCamera();
    }

    void RayCastCamera() {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, 20.0f)) {
            //Debug.Log(hit.collider.tag);
            switch(hit.collider.tag) {
                case "Door":

                    LatchOpenDoor latch = hit.collider.GetComponentInParent<LatchOpenDoor>();
                    if(latch.open!=true) {
                        prompt=pressKeyToOpen;
                        showPrompt=true;
                        if(Input.GetKeyDown(KeyCode.E)) {
                            showPrompt=false;
                            latch.OpenDoor();
                            Debug.Log(hit.collider.gameObject.GetComponent<TeleportPlayer>());
                            if(hit.collider.gameObject.GetComponent<TeleportPlayer>()!=null) {
                                TeleportPlayer teleport = hit.collider.GetComponent<TeleportPlayer>();
                                teleport.TeleportPlayerTo();
                        }
                    }
                    }
                    else {
                        showPrompt=false;
                    }
                    break;
                case "Battery":
                    prompt=pressKeyToBattery;
                    showPrompt=true;
                    if(Input.GetKeyDown(KeyCode.E)) {
                        battery.batteryLife+=5;
                        Destroy(hit.collider.gameObject);
                    }
                    break;
            }

            
            //Debug.DrawRay(ray.origin, ray.direction*20, Color.red);
        }
    }

    void OnGUI() {
        if(showPrompt)
        GUI.Box(new Rect(140, Screen.height-50, Screen.width-300, 120), (prompt));
    }
}
