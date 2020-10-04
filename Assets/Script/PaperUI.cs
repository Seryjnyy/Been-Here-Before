using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PaperUI : MonoBehaviour
{
    private Text text;
    public void LoadText(string[] instructions) {
        gameObject.AddComponent<Text>();
       
        

        text=gameObject.GetComponent<Text>();
        text.alignment=TextAnchor.UpperLeft;
        text.fontSize=12;
        for(int i = 0; i<instructions.Length; i++) {
            text.text+=instructions[i];
        }

        RectTransform rectTRansform;
        rectTRansform=text.GetComponent<RectTransform>();
        rectTRansform.localPosition=new Vector3(0, 0, 0);
        rectTRansform.sizeDelta=new Vector2(600, 200);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
