using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenPlot : MonoBehaviour
{
    public int plotID;
    public bool isOccupied = false;
    public FlowerData plantedFlowerData;
    public int growthStage = 0;

    public Flower currentFlower;

    public void PlantFlower(FlowerData flowerData)
    {
        if (isOccupied) return;

        isOccupied = true;
        plantedFlowerData = flowerData;
        growthStage = 0;

        GameObject flowerPrefab = Instantiate(flowerData.prefab, transform);
        currentFlower = flowerPrefab.GetComponent<Flower>();
        currentFlower.Initialize(flowerData, growthStage);
    }

    public void RemoveFlower()
    {
        if (currentFlower != null)
        {
            Destroy(currentFlower.gameObject);
        }
        isOccupied = false;
        plantedFlowerData = null;
        growthStage = 0;
    }

    public void GrowFlower()
    {
        if (!isOccupied || currentFlower == null) return;

        if (growthStage < plantedFlowerData.maxGrowthStage)
        {
            growthStage++;
        }

        currentFlower.UpdateVisual(growthStage);
    }


    public PlotSaveData GetSaveData()
    {
        return new PlotSaveData
        {
            plotID = plotID,
            isOccupied = isOccupied,
            plantedFlowerType = plantedFlowerData != null ? plantedFlowerData.flowerType : FlowerType.None,
            growthStage = growthStage
        };
    }
}