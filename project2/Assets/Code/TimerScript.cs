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

<<<<<<< Updated upstream
    
    public int GetFood()
    {
        return PublicVars.Instance.playerResources[3];
=======
    private int food = 50;
    private int money = 50;
    private int population = 50;
    private int army = 50;
    private int stone = 50;
    private int water = 50;

    private int foodBuildingCount = 0;
    private int moneyBuildingCount = 0;
    private int populationBuildingCount = 0;
    private int armyBuildingCount = 0;
    private int stoneBuildingCount = 0;
    private int waterBuildingCount = 0;

    public int GetFood()
    {
        return food;
>>>>>>> Stashed changes
    }

    public int GetMoney()
    {
<<<<<<< Updated upstream
        return PublicVars.Instance.playerResources[2];
=======
        return money;
>>>>>>> Stashed changes
    }

    public int GetPopulation()
    {
<<<<<<< Updated upstream
        return PublicVars.Instance.playerResources[0];
=======
        return population;
>>>>>>> Stashed changes
    }

    public int GetArmy()
    {
<<<<<<< Updated upstream
        return PublicVars.Instance.playerResources[4];
=======
        return army;
>>>>>>> Stashed changes
    }

    public int GetStone()
    {
<<<<<<< Updated upstream
        return PublicVars.Instance.playerResources[1];
=======
        return stone;
>>>>>>> Stashed changes
    }

    public int getWater()
    {
<<<<<<< Updated upstream
        return PublicVars.Instance.playerResources[5];
=======
        return water;
>>>>>>> Stashed changes
    }

    public void setFood(int newFood)
    {
<<<<<<< Updated upstream
        PublicVars.Instance.buildingCounts[0] = newFood;
=======
        food = newFood;
>>>>>>> Stashed changes
    }

    public void setMoney(int newMoney)
    {
<<<<<<< Updated upstream
        PublicVars.Instance.playerResources[3] = newMoney;
=======
        money = newMoney;
>>>>>>> Stashed changes
    }

    public void setPopulation(int newPopulation)
    {
<<<<<<< Updated upstream
        PublicVars.Instance.playerResources[2] = newPopulation;
=======
        population = newPopulation;
>>>>>>> Stashed changes
    }

    public void setArmy(int newArmy)
    {
<<<<<<< Updated upstream
        PublicVars.Instance.playerResources[4] = newArmy;
=======
        army = newArmy;
>>>>>>> Stashed changes
    }

    public void setStone(int newStone)
    {
<<<<<<< Updated upstream
        PublicVars.Instance.playerResources[1] = newStone;
=======
        stone = newStone;
>>>>>>> Stashed changes
    }

    public void getWater(int newWater)
    {
<<<<<<< Updated upstream
        PublicVars.Instance.playerResources[5] = newWater;
=======
        water = newWater;
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
    //population, stone, bank, food, army, water
    //     0       1       2    3     4    5
    void UpdateResourceDisplay()
    {
        foodText.text = "Food: " + PublicVars.Instance.playerResources[3] + " (" + ((2 * PublicVars.Instance.buildingCounts[3]) + (-2 * PublicVars.Instance.buildingCounts[0]) + (-2 * PublicVars.Instance.buildingCounts[4])) + ")";
        moneyText.text = "Money: " + PublicVars.Instance.playerResources[2] + " (" + ((3 * PublicVars.Instance.buildingCounts[2]) + (-3 * PublicVars.Instance.buildingCounts[3]) + (-1 * PublicVars.Instance.buildingCounts[4]) + (-3 * PublicVars.Instance.buildingCounts[1])) + ")";
        populationText.text = "Population: " + PublicVars.Instance.playerResources[0] + " (" + ((3 * PublicVars.Instance.buildingCounts[0]) + (-3 * PublicVars.Instance.buildingCounts[2]) + (-4 * PublicVars.Instance.buildingCounts[1]) + (-4 * PublicVars.Instance.buildingCounts[5])) + ")";
        armyText.text = "Army: " + PublicVars.Instance.playerResources[4] + " (" + (4 * PublicVars.Instance.buildingCounts[4]) + ")";
        stoneText.text = "Stone: " + PublicVars.Instance.playerResources[1] + " (" + (4 * PublicVars.Instance.buildingCounts[1]) + ")";
        waterText.text = "Water: " + PublicVars.Instance.playerResources[5] + " (" + ((2 * PublicVars.Instance.buildingCounts[5]) + (-1 * PublicVars.Instance.buildingCounts[3]) + (-4 * PublicVars.Instance.buildingCounts[0])) + ")";
=======
    void UpdateResourceDisplay()
    {
        CountBuildings();
        foodText.text = "Food: " + food + " (" + ((2 * foodBuildingCount) + (-14 * populationBuildingCount) + (-12 * armyBuildingCount)) + ")";
        moneyText.text = "Money: " + money + " (" + ((18 * moneyBuildingCount) + (-13 * foodBuildingCount) + (-12 * armyBuildingCount) + (-3 * stoneBuildingCount)) + ")";
        populationText.text = "Population: " + population + " (" + ((3 * populationBuildingCount) + (-9 * moneyBuildingCount) + (-4 * stoneBuildingCount) + (-4 * waterBuildingCount)) + ")";
        armyText.text = "Army: " + army + " (" + (4 * armyBuildingCount) + ")";
        stoneText.text = "Stone: " + stone + " (" + (15 * stoneBuildingCount) + ")";
        waterText.text = "Water: " + water + " (" + ((20 * waterBuildingCount) + (-8 * foodBuildingCount) + (-4 * populationBuildingCount)) + ")";
>>>>>>> Stashed changes
    }

    void UpdateResources()
    {
<<<<<<< Updated upstream
        PublicVars.Instance.playerResources[3] += (2 * PublicVars.Instance.buildingCounts[3]) + (-4 * PublicVars.Instance.buildingCounts[0]) + (-2 * PublicVars.Instance.buildingCounts[4]);
        PublicVars.Instance.playerResources[2] += (1 * PublicVars.Instance.buildingCounts[2]) + (-1 * PublicVars.Instance.buildingCounts[3]) + (-1 * PublicVars.Instance.buildingCounts[4]) + (-3 * PublicVars.Instance.buildingCounts[1]);
        PublicVars.Instance.playerResources[0] += (3 * PublicVars.Instance.buildingCounts[0]) + (-3 * PublicVars.Instance.buildingCounts[2]) + (-4 * PublicVars.Instance.buildingCounts[1]) + (-4 * PublicVars.Instance.buildingCounts[5]);
        PublicVars.Instance.playerResources[4] += (4 * PublicVars.Instance.buildingCounts[4]);
        PublicVars.Instance.playerResources[1] += (5 * PublicVars.Instance.buildingCounts[1]);
        PublicVars.Instance.playerResources[5] += (2 * PublicVars.Instance.buildingCounts[5]) + (-8 * PublicVars.Instance.buildingCounts[3]) + (-4 * PublicVars.Instance.buildingCounts[0]);
=======
        food += (2 * foodBuildingCount) + (-14 * populationBuildingCount) + (-12 * armyBuildingCount);
        money += (18 * moneyBuildingCount) + (-13 * foodBuildingCount) + (-12 * armyBuildingCount) + (-3 * stoneBuildingCount);
        population += (3 * populationBuildingCount) + (-9 * moneyBuildingCount) + (-4 * stoneBuildingCount) + (-4 * waterBuildingCount);
        army += (4 * armyBuildingCount);
        stone += (15 * stoneBuildingCount);
        water += (20 * waterBuildingCount) + (-8 * foodBuildingCount) + (-4 * populationBuildingCount);
>>>>>>> Stashed changes
    }

    void FiveSecondMark()
    {
        UpdateResources();
        Debug.Log("5 seconds have passed");
    }

<<<<<<< Updated upstream
    /*
    void CountBuildings()
    {
        BuildingScript[] buildings = FindObjectsOfType<BuildingScript>();
        PublicVars.Instance.buildingCounts[3] = 0;
        PublicVars.Instance.buildingCounts[2] = 0;
        PublicVars.Instance.buildingCounts[0] = 0;
        PublicVars.Instance.buildingCounts[4] = 0;
        PublicVars.Instance.buildingCounts[1] = 0;
        PublicVars.Instance.buildingCounts[5] = 0;
=======
    void CountBuildings()
    {
        BuildingScript[] buildings = FindObjectsOfType<BuildingScript>();
        foodBuildingCount = 0;
        moneyBuildingCount = 0;
        populationBuildingCount = 0;
        armyBuildingCount = 0;
        stoneBuildingCount = 0;
        waterBuildingCount = 0;
>>>>>>> Stashed changes

        foreach (BuildingScript building in buildings)
        {
            switch (building.buildingType)
            {
                case BuildingScript.BuildingType.FoodBuilding:
<<<<<<< Updated upstream
                    PublicVars.Instance.buildingCounts[3]++;
                    break;
                case BuildingScript.BuildingType.MoneyBuilding:
                    PublicVars.Instance.buildingCounts[2]++;
                    break;
                case BuildingScript.BuildingType.PopulationBuilding:
                    PublicVars.Instance.buildingCounts[0]++;
                    break;
                case BuildingScript.BuildingType.ArmyBuilding:
                    PublicVars.Instance.buildingCounts[4]++;
                    break;
                case BuildingScript.BuildingType.StoneBuilding:
                    PublicVars.Instance.buildingCounts[1]++;
                    break;
                case BuildingScript.BuildingType.WaterBuilding:
                    PublicVars.Instance.buildingCounts[5]++;
                    break;
            }
        }
    }*/
=======
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
>>>>>>> Stashed changes
}
