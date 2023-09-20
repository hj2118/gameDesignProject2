using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 4) {
            int give_or_steal = Random.Range(0, 1);
            int res_to_alter = Random.Range(0, 5);
            int val_to_alter = Random.Range(1, 10);
            if (give_or_steal == 0)
            {
                PublicVars.playerResources[res_to_alter] -= val_to_alter;
                PublicVars.enemyResources[res_to_alter] += val_to_alter;
            }
            else
            {
                PublicVars.playerResources[res_to_alter] += val_to_alter;
                PublicVars.enemyResources[res_to_alter] -= val_to_alter;
            }
            timer = 0;
        }


       
    }

    /*
    IEnumerator AlterPlayerResources()
    {
        int give_or_steal = Random.Range(0, 1);
        int res_to_alter = Random.Range(0, 5);
        int val_to_alter = Random.Range(1, 10);
        yield return new WaitForSeconds(100);
        if (give_or_steal == 0)
        {
            PublicVars.playerResources[res_to_alter] -= val_to_alter;
            PublicVars.enemyResources[res_to_alter] += val_to_alter;
        }
        else
        {
            PublicVars.playerResources[res_to_alter] += val_to_alter;
            PublicVars.enemyResources[res_to_alter] -= val_to_alter;
        }
        
    } */
}
