using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScripts : MonoBehaviour
{
    public bool player; //true if displaying the player scores; false if displaying the enemy scores
    public TextMeshProUGUI water_text;
    public TextMeshProUGUI money_text;
    public TextMeshProUGUI army_text;
    public TextMeshProUGUI food_text;
    public TextMeshProUGUI pop_text;
    public TextMeshProUGUI stone_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            pop_text.text = PublicVars.Instance.playerResources[0].ToString();
            stone_text.text = PublicVars.Instance.playerResources[1].ToString();
            money_text.text = PublicVars.Instance.playerResources[2].ToString();
            food_text.text = PublicVars.Instance.playerResources[3].ToString();
            army_text.text = PublicVars.Instance.playerResources[4].ToString();
            water_text.text = PublicVars.Instance.playerResources[5].ToString();
        }
        else
        {
            pop_text.text = PublicVars.Instance.enemyResources[0].ToString();
            stone_text.text = PublicVars.Instance.enemyResources[1].ToString();
            money_text.text = PublicVars.Instance.enemyResources[2].ToString();
            food_text.text = PublicVars.Instance.enemyResources[3].ToString();
            army_text.text = PublicVars.Instance.enemyResources[4].ToString();
            water_text.text = PublicVars.Instance.enemyResources[5].ToString();

        }
    }
}
