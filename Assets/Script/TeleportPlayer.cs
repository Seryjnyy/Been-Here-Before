using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Light flashlight;


    // Start is called before the first frame update
    void Awake()
    {
        flashlight=GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();
    }

    public void TeleportPlayerTo() {
        Debug.Log("Nice oneeeeeee");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
