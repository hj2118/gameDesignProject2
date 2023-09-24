using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public TextMeshProUGUI enemyAttackedText;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        enemyAttackedText.alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

<<<<<<< Updated upstream
        if (timer > 4) {
            int give_or_steal = Random.Range(0, 1);
            int res_to_alter = Random.Range(0, 5);
            int val_to_alter = Random.Range(1, 10);
            if (give_or_steal == 0)
            {
                PublicVars.Instance.playerResources[res_to_alter] -= val_to_alter;
                PublicVars.Instance.enemyResources[res_to_alter] += val_to_alter;
            }
            else
            {
                PublicVars.Instance.playerResources[res_to_alter] += val_to_alter;
                PublicVars.Instance.enemyResources[res_to_alter] -= val_to_alter;
            }
=======
        if (timer > 0.75)
        {
            enemyAttackedText.alpha = 0f;
        }

        // "Enemy Attacked!" text appears on the screen for 0.75 seconds

        if (timer > 25) {
            AlterPlayerResources();

            enemyAttackedText.alpha = 1f;
>>>>>>> Stashed changes
            timer = 0;

            //timer = 0;
        }


       
    }

    void AlterPlayerResources()
    {
        int give_or_steal = Random.Range(0, 1);
        int res_to_alter = Random.Range(0, 5);
        int val_to_alter = Random.Range(1, 30);
        if (give_or_steal == 0)
        {
            PublicVars.Instance.playerResources[res_to_alter] -= val_to_alter;
            PublicVars.Instance.enemyResources[res_to_alter] += val_to_alter;
        }
        else
        {
            PublicVars.Instance.playerResources[res_to_alter] += val_to_alter;
            PublicVars.Instance.enemyResources[res_to_alter] -= val_to_alter;
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
