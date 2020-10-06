using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultText : MonoBehaviour
{
    public LevelMetaData level;
    public Text text;
    void Awake()
    {
            Cursor.lockState=CursorLockMode.None;
            Cursor.visible=true;

        text=gameObject.GetComponent<Text>();
        if(level.batteryCount >4){
            if(level.ToysCollected == 0){
                text.text = "You escaped the house,\n you are free from the chains of that house...";
            }else if(level.ToysCollected ==20){
                text.text = "You escaped the house,\n but the toys you collected brought back too many memories,\n you've been here before and now you are staying...";
            }else{
                text.text = "You didnt escape the house,\n however you still dont know the truth behind this,\n and will never know...";
            }

        }else{
                text.text = "You didnt escape the house,\n the familiar scene turned into darkness\n and the light never did turn back on...";
        }

        
    }


}
