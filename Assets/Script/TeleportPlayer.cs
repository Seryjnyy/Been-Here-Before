using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TeleportPlayer : MonoBehaviour
{
    public Light flashlight;
    public LevelMetaData level;
    public PlayerController playerController;

    
    void Awake()
    {
        level.levelCount=-1;
        flashlight=GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Light>();
        playerController = GameObject.FindGameObjectWithTag("PlayerTag").GetComponent<PlayerController>();
    }

    public void TeleportPlayerTo() {
        level.levelCount++;
        if(level.levelCount >=3){
        SceneManager.LoadScene("GameOver");
        }else{
        playerController.gameObject.GetComponent<PlayerController>().enabled=false;
        playerController.MoveToLocation(level.houseStartPositions[level.levelCount]);
        Invoke("turnCharacterControllerOn",0.5f);
        }
        
    }
    public void turnCharacterControllerOn(){
playerController.gameObject.GetComponent<PlayerController>().enabled=true;
    }


}
