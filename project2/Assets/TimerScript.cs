using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float elapsedTime = 0.0f;

    public float elapsedTime2 = 0.0f;

    public TextMeshProUGUI timerText;

    public TextMeshProUGUI foodText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI armyText;
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI waterText;

    private int food = 60;
    private int money = 60;
    private int population = 70;
    private int army = 10;
    private int stone = 65;
    private int water = 75;

    private int foodBuildingCount = 0;
    private int moneyBuildingCount = 0;
    private int populationBuildingCount = 0;
    private int armyBuildingCount = 0;
    private int stoneBuildingCount = 0;
    private int waterBuildingCount = 0;

    public int GetFood()
    {
        return food;
    }

    public int GetMoney()
    {
        return money;
    }

    public int GetPopulation()
    {
        return population;
    }

    public int GetArmy()
    {
        return army;
    }

    public int GetStone()
    {
        return stone;
    }

    public int getWater()
    {
        return water;
    }

    public void setFood(int newFood)
    {
        food = newFood;
    }

    public void setMoney(int newMoney)
    {
        money = newMoney;
    }

    public void setPopulation(int newPopulation)
    {
        population = newPopulation;
    }

    public void setArmy(int newArmy)
    {
        army = newArmy;
    }

    public void setStone(int newStone)
    {
        stone = newStone;
    }

    public void getWater(int newWater)
    {
        water = newWater;
    }



    // Start is called before the first frame update
    void Start()
    {
        UpdateResourceDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateResourceDisplay();
        elapsedTime += Time.deltaTime;
        elapsedTime2 += Time.deltaTime;

        UpdateTimeDisplay();

        if (elapsedTime2 >= 5.0f)
        {
            FiveSecondMark();
            elapsedTime2 -= 5.0f;
        }
        
    }

    void UpdateTimeDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    void UpdateResourceDisplay()
    {
        CountBuildings();
        foodText.text = "Food: " + food + " (" + ((2 * foodBuildingCount) + (-14 * populationBuildingCount) + (-12 * armyBuildingCount)) + ")";
        moneyText.text = "Money: " + money + " (" + ((18 * moneyBuildingCount) + (-13 * foodBuildingCount) + (-12 * armyBuildingCount) + (-3 * stoneBuildingCount)) + ")";
        populationText.text = "Population: " + population + " (" + ((3 * populationBuildingCount) + (-9 * moneyBuildingCount) + (-4 * stoneBuildingCount) + (-4 * waterBuildingCount)) + ")";
        armyText.text = "Army: " + army + " (" + (4 * armyBuildingCount) + ")";
        stoneText.text = "Stone: " + stone + " (" + (15 * stoneBuildingCount) + ")";
        waterText.text = "Water: " + water + " (" + ((20 * waterBuildingCount) + (-8 * foodBuildingCount) + (-4 * populationBuildingCount)) + ")";
    }

    void UpdateResources()
    {
        food += (2 * foodBuildingCount) + (-14 * populationBuildingCount) + (-12 * armyBuildingCount);
        money += (18 * moneyBuildingCount) + (-13 * foodBuildingCount) + (-12 * armyBuildingCount) + (-3 * stoneBuildingCount);
        population += (3 * populationBuildingCount) + (-9 * moneyBuildingCount) + (-4 * stoneBuildingCount) + (-4 * waterBuildingCount);
        army += (4 * armyBuildingCount);
        stone += (15 * stoneBuildingCount);
        water += (20 * waterBuildingCount) + (-8 * foodBuildingCount) + (-4 * populationBuildingCount);
    }

    void FiveSecondMark()
    {
        UpdateResources();
        Debug.Log("5 seconds have passed");
    }

    void CountBuildings()
    {
        BuildingScript[] buildings = FindObjectsOfType<BuildingScript>();
        foodBuildingCount = 0;
        moneyBuildingCount = 0;
        populationBuildingCount = 0;
        armyBuildingCount = 0;
        stoneBuildingCount = 0;
        waterBuildingCount = 0;

        foreach (BuildingScript building in buildings)
        {
            switch (building.buildingType)
            {
                case BuildingScript.BuildingType.FoodBuilding:
                    foodBuildingCount++;
                    break;
                case BuildingScript.BuildingType.MoneyBuilding:
                    moneyBuildingCount++;
                    break;
                case BuildingScript.BuildingType.PopulationBuilding:
                    populationBuildingCount++;
                    break;
                case BuildingScript.BuildingType.ArmyBuilding:
                    armyBuildingCount++;
                    break;
                case BuildingScript.BuildingType.StoneBuilding:
                    stoneBuildingCount++;
                    break;
                case BuildingScript.BuildingType.WaterBuilding:
                    waterBuildingCount++;
                    break;
            }
        }
    }
}
