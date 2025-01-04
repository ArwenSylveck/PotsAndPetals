using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenManager : MonoBehaviour
{
    public List<GardenPlot> gardenPlots; // References to all plots in the scene
    public List<FlowerData> allFlowerData; // All flower data assets

    public void LoadGarden(List<PlotSaveData> saveDataList)
    {
        foreach (var plotSave in saveDataList)
        {
            GardenPlot plot = gardenPlots.Find(p => p.plotID == plotSave.plotID);
            if (plot == null)
            {
                Debug.LogWarning($"No plot found with ID {plotSave.plotID}");
                continue;
            }

            if (!plotSave.isOccupied)
            {
                plot.RemoveFlower();
                continue;
            }

            FlowerData flowerData = allFlowerData.Find(f => f.flowerType == plotSave.plantedFlowerType);
            if (flowerData == null)
            {
                Debug.LogWarning($"No flower data found for type {plotSave.plantedFlowerType}");
                plot.RemoveFlower();
                continue;
            }

            // GardenPlot handles flower instantiation and initialization
            plot.PlantFlower(flowerData);
            plot.growthStage = plotSave.growthStage;
            plot.currentFlower.UpdateVisual(plotSave.growthStage); // Ensure visuals match the saved state
        }
    }

}

