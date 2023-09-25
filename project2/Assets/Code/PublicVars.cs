using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVars : MonoBehaviour
{

    public static PublicVars Instance {get; private set;}
    public int[] playerResources = { 50, 50, 50, 50, 50, 50 };
    public int[] enemyResources = { 50, 50, 50, 50, 50, 50 };
    public int[] buildingCounts = {1,1,1,1,1,1,1};
    public int resourceCap = 100;
    private void Awake(){
         Instance = this;
    }

}
