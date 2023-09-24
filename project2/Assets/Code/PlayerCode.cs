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
        for (int i = 0; i < PublicVars.playerResources.Length; i++)
        {
            
<<<<<<< Updated upstream
            if ((PublicVars.playerResources[i] >= 100) || (PublicVars.playerResources[i] <= 0)) {
=======
            if ((PublicVars.Instance.playerResources[i] >= 200) || (PublicVars.Instance.playerResources[i] <= 0)) {
>>>>>>> Stashed changes
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
