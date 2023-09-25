using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlaceBuildingButtonScript : MonoBehaviour
{
    public Button buildBuilding;
    public GameObject buildPreFab;
    private GameObject ghostBuilding;
    private SpriteRenderer ghostBuildingRenderer;
    public TimerScript timerScript;
    

    public void OnButtonClick()
    {
        if (!ghostBuilding)
        {
            ghostBuilding = Instantiate(buildPreFab);
            ghostBuildingRenderer = ghostBuilding.GetComponent<SpriteRenderer>();
            Color transparent = ghostBuildingRenderer.color;
            transparent.a = 0.5f;
            ghostBuildingRenderer.color = transparent;
        }
    }

    private void PlaceBuilding()
    {
        Color full = ghostBuildingRenderer.color;
        full.a = 1f;
        ghostBuildingRenderer.color = full;

        ghostBuilding = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (ghostBuilding)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20));
            ghostBuilding.transform.position = mousePosition;
        }

        if (Input.GetMouseButtonDown(0) && ghostBuilding)
        {
            PlaceBuilding();
        }
        
    }
}
