using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVars : MonoBehaviour
{

    public static PublicVars Instance {get; private set;}
    public int[] playerResources = { 50, 50, 50, 50, 50, 50 };
    // playerResources contains player's HP, money, army, food, population (in that order)

    public int[] enemyResources = { 50, 50, 50, 50, 50, 50 };
    // enemyResources contains enemy's HP, money, army, food, population (in that order)
    public int[] buildingCounts = {0,0,0,0,0,0};
   private void Awake(){
   //     if(Instance == null){
    Instance = this;
    //    }

   }
    /*                          bank,farm,hospital,armory,housing
    public static int playerHP = 50;
    public static int playerMoney = 50;
    public static int playerArmy = 50;
    public static int playerFood = 50;
    public static int playerPop = 50;

    public static int enemyHP = 50;
    public static int enemyMoney = 50;
    public static int enemyArmy = 50;
    public static int enemyFood = 50;
    public static int enemyPop = 50;
    */
}
