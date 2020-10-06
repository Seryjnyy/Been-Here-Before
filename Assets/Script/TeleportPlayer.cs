using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Light flashlight;
    public LevelMetaData level;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Awake()
    {
        level.levelCount=-1;
        flashlight=GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();
        playerTransform = GameObject.FindGameObjectWithTag("PlayerTag").GetComponent<Transform>();
    }

    public void TeleportPlayerTo() {
        level.levelCount++;
        Debug.Log(level.houseStartPositions[level.levelCount]);
        playerTransform.pos=new Vector3(0,0,0);//level.houseStartPositions[level.levelCount];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
