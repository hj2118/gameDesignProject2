using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI foodText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI armyText;
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI waterText;

    public Dictionary<BuildingScript.BuildingType, TextMeshProUGUI> resourceDisplays = new Dictionary<BuildingScript.BuildingType, TextMeshProUGUI>();
    public Dictionary<BuildingScript.BuildingType, int> resources = new Dictionary<BuildingScript.BuildingType, int>();
    public Dictionary<BuildingScript.BuildingType, int> buildingCounts = new Dictionary<BuildingScript.BuildingType, int>();
    public Dictionary<BuildingScript.BuildingType, string> resourceAmountStrings = new Dictionary<BuildingScript.BuildingType, string>();
    public Dictionary<BuildingScript.BuildingType, string> resourceChangeStrings = new Dictionary<BuildingScript.BuildingType, string>();


    private float elapsedTime = 0f;
    private float elapsedTime2 = 0f;

    private void Start()
    {
        InitializeResources();
        UpdateResourceAmountStrings();
        UpdateResourceChangeStrings();
        UpdateResourceDisplay();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        elapsedTime2 += Time.deltaTime;

        UpdateTimeDisplay();

        if (elapsedTime2 >= 5.0f)
        {
            FiveSecondMark();
            elapsedTime2 -= 5.0f;
        }
    }

    private void FiveSecondMark()
    {
        UpdateResources();
        UpdateResourceAmountStrings();
        UpdateResourceDisplay();
    }

    private void UpdateResources()
    {
        resources[BuildingScript.BuildingType.FoodBuilding] += CalculateFoodChange();
        resources[BuildingScript.BuildingType.MoneyBuilding] += CalculateMoneyChange();
        resources[BuildingScript.BuildingType.PopulationBuilding] += CalculatePopulationChange();
        resources[BuildingScript.BuildingType.ArmyBuilding] += CalculateArmyChange();
        resources[BuildingScript.BuildingType.StoneBuilding] += CalculateStoneChange();
        resources[BuildingScript.BuildingType.WaterBuilding] += CalculateWaterChange();
    }

    private int CalculateFoodChange()
    {
        return (2 * buildingCounts[BuildingScript.BuildingType.FoodBuilding])
                - (14 * buildingCounts[BuildingScript.BuildingType.PopulationBuilding])
                - (12 * buildingCounts[BuildingScript.BuildingType.ArmyBuilding]);
    }

    private int CalculateMoneyChange()
    {
        return (18 * buildingCounts[BuildingScript.BuildingType.MoneyBuilding])
                - (13 * buildingCounts[BuildingScript.BuildingType.FoodBuilding])
                - (12 * buildingCounts[BuildingScript.BuildingType.ArmyBuilding])
                - (3 * buildingCounts[BuildingScript.BuildingType.StoneBuilding]);
    }

    private int CalculatePopulationChange()
    {
        return (3 * buildingCounts[BuildingScript.BuildingType.PopulationBuilding])
                - (9 * buildingCounts[BuildingScript.BuildingType.MoneyBuilding])
                - (4 * buildingCounts[BuildingScript.BuildingType.StoneBuilding])
                - (4 * buildingCounts[BuildingScript.BuildingType.WaterBuilding]);
    }

    private int CalculateArmyChange()
    {
        return (4 * buildingCounts[BuildingScript.BuildingType.ArmyBuilding]);
    }

    private int CalculateStoneChange()
    {
        return (15 * buildingCounts[BuildingScript.BuildingType.StoneBuilding]);
    }

    private int CalculateWaterChange()
    {
        return (20 * buildingCounts[BuildingScript.BuildingType.WaterBuilding])
        - (8 * buildingCounts[BuildingScript.BuildingType.FoodBuilding])
        - (4 * buildingCounts[BuildingScript.BuildingType.PopulationBuilding]);
    }

    private void UpdateTimeDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void InitializeResources()
    {
        resourceDisplays[BuildingScript.BuildingType.FoodBuilding] = foodText;
        resourceDisplays[BuildingScript.BuildingType.MoneyBuilding] = moneyText;
        resourceDisplays[BuildingScript.BuildingType.PopulationBuilding] = populationText;
        resourceDisplays[BuildingScript.BuildingType.ArmyBuilding] = armyText;
        resourceDisplays[BuildingScript.BuildingType.StoneBuilding] = stoneText;
        resourceDisplays[BuildingScript.BuildingType.WaterBuilding] = waterText;

        resources[BuildingScript.BuildingType.FoodBuilding] = 60;
        resources[BuildingScript.BuildingType.MoneyBuilding] = 60;
        resources[BuildingScript.BuildingType.PopulationBuilding] = 70;
        resources[BuildingScript.BuildingType.ArmyBuilding] = 20;
        resources[BuildingScript.BuildingType.StoneBuilding] = 65;
        resources[BuildingScript.BuildingType.WaterBuilding] = 75;

        buildingCounts[BuildingScript.BuildingType.FoodBuilding] = 0;
        buildingCounts[BuildingScript.BuildingType.MoneyBuilding] = 0;
        buildingCounts[BuildingScript.BuildingType.PopulationBuilding] = 0;
        buildingCounts[BuildingScript.BuildingType.ArmyBuilding] = 0;
        buildingCounts[BuildingScript.BuildingType.StoneBuilding] = 0;
        buildingCounts[BuildingScript.BuildingType.WaterBuilding] = 0;
        buildingCounts[BuildingScript.BuildingType.StorageBuilding] = 1;
    }

    private void UpdateResourceAmountStrings()
    {
        resourceAmountStrings[BuildingScript.BuildingType.FoodBuilding] = "Food: " + resources[BuildingScript.BuildingType.FoodBuilding] + "/" + (100 * buildingCounts[BuildingScript.BuildingType.StorageBuilding]);
        resourceAmountStrings[BuildingScript.BuildingType.MoneyBuilding] = "Money: " + resources[BuildingScript.BuildingType.MoneyBuilding] + "/" + (100 * buildingCounts[BuildingScript.BuildingType.StorageBuilding]);
        resourceAmountStrings[BuildingScript.BuildingType.PopulationBuilding] = "Population: " + resources[BuildingScript.BuildingType.PopulationBuilding] + "/" + (100 * buildingCounts[BuildingScript.BuildingType.StorageBuilding]);
        resourceAmountStrings[BuildingScript.BuildingType.ArmyBuilding] = "Army: " + resources[BuildingScript.BuildingType.ArmyBuilding] + "/" + (100 * buildingCounts[BuildingScript.BuildingType.StorageBuilding]);
        resourceAmountStrings[BuildingScript.BuildingType.StoneBuilding] = "Stone: " + resources[BuildingScript.BuildingType.StoneBuilding] + "/" + (100 * buildingCounts[BuildingScript.BuildingType.StorageBuilding]);
        resourceAmountStrings[BuildingScript.BuildingType.WaterBuilding] = "Water: " + resources[BuildingScript.BuildingType.WaterBuilding] + "/" + (100 * buildingCounts[BuildingScript.BuildingType.StorageBuilding]);
    }

    private void UpdateResourceChangeStrings()
    {
        resourceChangeStrings[BuildingScript.BuildingType.FoodBuilding] = "(" + (CalculateFoodChange() > 0 ? "+" + CalculateFoodChange() : CalculateFoodChange()) + ")";
        resourceChangeStrings[BuildingScript.BuildingType.MoneyBuilding] = "(" + (CalculateMoneyChange() > 0 ? "+" + CalculateMoneyChange() : CalculateMoneyChange()) + ")";
        resourceChangeStrings[BuildingScript.BuildingType.PopulationBuilding] = "(" + (CalculatePopulationChange() > 0 ? "+" + CalculatePopulationChange() : CalculatePopulationChange()) + ")";
        resourceChangeStrings[BuildingScript.BuildingType.ArmyBuilding] = "(" + (CalculateArmyChange() > 0 ? "+" + CalculateArmyChange() : CalculateArmyChange()) + ")";
        resourceChangeStrings[BuildingScript.BuildingType.StoneBuilding] = "(" + (CalculateStoneChange() > 0 ? "+" + CalculateStoneChange() : CalculateStoneChange()) + ")";
        resourceChangeStrings[BuildingScript.BuildingType.WaterBuilding] = "(" + (CalculateWaterChange() > 0 ? "+" + CalculateWaterChange() : CalculateWaterChange()) + ")";
    }

    private void UpdateResourceDisplay()
    {
        foodText.text = resourceAmountStrings[BuildingScript.BuildingType.FoodBuilding] + " " + resourceChangeStrings[BuildingScript.BuildingType.FoodBuilding];
        moneyText.text = resourceAmountStrings[BuildingScript.BuildingType.MoneyBuilding] + " " + resourceChangeStrings[BuildingScript.BuildingType.MoneyBuilding];
        populationText.text = resourceAmountStrings[BuildingScript.BuildingType.PopulationBuilding] + " " + resourceChangeStrings[BuildingScript.BuildingType.PopulationBuilding];
        armyText.text = resourceAmountStrings[BuildingScript.BuildingType.ArmyBuilding] + " " + resourceChangeStrings[BuildingScript.BuildingType.ArmyBuilding];
        stoneText.text = resourceAmountStrings[BuildingScript.BuildingType.StoneBuilding] + " " + resourceChangeStrings[BuildingScript.BuildingType.StoneBuilding];
        waterText.text = resourceAmountStrings[BuildingScript.BuildingType.WaterBuilding] + " " + resourceChangeStrings[BuildingScript.BuildingType.WaterBuilding];
    }

    private void CountBuildings()
    {
        BuildingScript[] buildings = FindObjectsOfType<BuildingScript>();

        Dictionary<BuildingScript.BuildingType, int> tempBuildingCounts = new Dictionary<BuildingScript.BuildingType, int>();

        foreach (BuildingScript.BuildingType type in System.Enum.GetValues(typeof(BuildingScript.BuildingType)))
        {
            tempBuildingCounts[type] = 0;
        }

        foreach (BuildingScript building in buildings)
        {
            tempBuildingCounts[building.buildingType]++;
        }

        buildingCounts = tempBuildingCounts;
    }
}
