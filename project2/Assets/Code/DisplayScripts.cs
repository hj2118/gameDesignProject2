using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScripts : MonoBehaviour
{
    public bool player; //true if displaying the player scores; false if displaying the enemy scores
    public TextMeshProUGUI HP_text;
    public TextMeshProUGUI money_text;
    public TextMeshProUGUI army_text;
    public TextMeshProUGUI food_text;
    public TextMeshProUGUI pop_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            HP_text.text = PublicVars.playerResources[0].ToString();
            money_text.text = PublicVars.playerResources[1].ToString();
            army_text.text = PublicVars.playerResources[2].ToString();
            food_text.text = PublicVars.playerResources[3].ToString();
            pop_text.text = PublicVars.playerResources[4].ToString();
        }
        else
        {
            HP_text.text = PublicVars.enemyResources[0].ToString();
            money_text.text = PublicVars.enemyResources[1].ToString();
            army_text.text = PublicVars.enemyResources[2].ToString();
            food_text.text = PublicVars.enemyResources[3].ToString();
            pop_text.text = PublicVars.enemyResources[4].ToString();
        }
    }
}
