using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="levelMetaData",menuName ="LevelMetaData")]
public class LevelMetaData : ScriptableObject
{
    public int levelCount=-1;
    public float batteryCount=0;
    public int toysTocollect=20;
    public int ToysCollected=0;
    public Vector3[] houseStartPositions = {new Vector3(200,6.63f,123),new Vector3(330,6.63f,64),new Vector3(493,12.8f,105)};

   public string[] level1 = {"Instructions", "Go down the stairs ", "Open that door stupid", "Go down the stairs", "Open that door stupid", "IF NOT PICKING UP,","THEN LOOK LOWER","IT WILL WORK" };
    public string[] level2 = { "IF NOT PICKING UP,", "THEN LOOK LOWER", "IT WILL WORK" ,"THEN LOOK LOWER", "IT WILL WORK" };
}
