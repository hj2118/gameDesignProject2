using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public enum BuildingType
    {
        FoodBuilding,
        MoneyBuilding,
        PopulationBuilding,
        ArmyBuilding,
        StoneBuilding,
        WaterBuilding
    }

    public BuildingType buildingType;
}
