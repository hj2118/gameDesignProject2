using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCode : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < PublicVars.Instance.playerResources.Length; i++)
        {
            
            if ((PublicVars.Instance.playerResources[i] >= 200) || (PublicVars.Instance.playerResources[i] <= 0)) {
                SceneManager.LoadScene("GameOver");
            } 
            /*
            if (PublicVars.Instance.playerResources[i] != 50)
            {
                SceneManager.LoadScene("GameOver");
            } */
        }
    }
}
