using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRay : MonoBehaviour
{
    public Camera camera;
    bool showPrompt = false;
    string pressKeyToOpen = "Press E to open";

    void Start() {
        camera=Camera.main;
    }
    void Update()
    {
        RayCastCamera();
    }

    void RayCastCamera() {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, 20.0f)) {
            if(hit.collider.tag =="Door") {
                LatchOpenDoor latch = hit.collider.GetComponentInParent<LatchOpenDoor>();
                if(latch.open != true) {
                    showPrompt=true;
                    if(Input.GetKeyDown(KeyCode.E)) {
                        showPrompt=false;
                        latch.OpenDoor();

                    }
                }
                
                //Open door
                

            }
            else {
                showPrompt=false;
            }
            
            //Debug.DrawRay(ray.origin, ray.direction*20, Color.red);
        }
    }

    void OnGUI() {
        if(showPrompt)
        GUI.Box(new Rect(140, Screen.height-50, Screen.width-300, 120), (pressKeyToOpen));
    }
}
