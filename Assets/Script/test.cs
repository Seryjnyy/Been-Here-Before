using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public Text text;
    public RectTransform img;
    int arrowDirection = 0;
    void Awake()
    {
        text=gameObject.GetComponent<Text>();
        img=GameObject.FindGameObjectWithTag("NotesArrow").GetComponent<RectTransform>();

    }
    public void LoadText(string[] instructions,int arrowDirection) {
        img.localScale=new Vector3(arrowDirection, 1, 1);

        text.text="";
        string UIText = "";

        for(int i = 0; i<instructions.Length; i++) 
            UIText+=instructions[i]+"\n";

           text.text=UIText;
       

    }


}
