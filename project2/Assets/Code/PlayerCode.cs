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
            if ((PublicVars.Instance.playerResources[i] >= PublicVars.Instance.resourceCap) || (PublicVars.Instance.playerResources[i] <= 0)) {
                SceneManager.LoadScene("GameOver");
            } 

            if(PublicVars.Instance.playerResources[4] >= 300){
                SceneManager.LoadScene("Win");
            }
        }
    }
}
