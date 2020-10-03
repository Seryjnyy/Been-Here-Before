using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatchOpenDoor : MonoBehaviour
{
    public bool open = false;
    public void OpenDoor() {
        open=true;
        Animator anim = GetComponent<Animator>();
        anim.SetBool("openDoor", true);
    }
}
