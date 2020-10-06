using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="levelMetaData",menuName ="LevelMetaData")]
public class LevelMetaData : ScriptableObject
{
    public int levelCount=-1;

    public Vector3[] houseStartPositions = {new Vector3(200,6.63f,123),new Vector3(330,6.63f,64),new Vector3(493,12.8f,105)};

   public string[] level1 = {"Instructions", "Go down the stairs ", "Open that door stupid", "Go down the stairs", "Open that door stupid" };
    public string[] level2 = {"Notes", "Go dowfdsafsdn the stairs", "Open that d3235oor stupid", "Go down325325 the stairs", "Open that doo532523r stupid" };
}
