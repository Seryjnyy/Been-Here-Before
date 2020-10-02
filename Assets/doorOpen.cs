using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen: MonoBehaviour
{
    bool OpenClose;
    [SerializeField] GameObject latch = null;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)) {
            OpenClose=true;
        }
        if(OpenClose)
            RotateDoor();
    }

    void RotateDoor() {
        latch.transform.Rotate(new Vector3(0, 90.0f)*Time.deltaTime);
    }
}
