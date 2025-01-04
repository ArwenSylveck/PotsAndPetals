using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenManager : MonoBehaviour
{
    public List<GardenPlot> gardenPlots; // List of all garden plots

    public void PlantFlowerInPlot(int plotIndex, FlowerData flower)
    {
        if (plotIndex < 0 || plotIndex >= gardenPlots.Count) return;

        var plot = gardenPlots[plotIndex];
        if (plot.isOccupied)
        {
            Debug.Log("This plot is already occupied!");
            return;
        }

        plot.PlantFlower(flower);
    }

    public void ClearPlot(int plotIndex)
    {
        if (plotIndex < 0 || plotIndex >= gardenPlots.Count) return;

        var plot = gardenPlots[plotIndex];
        plot.ClearPlot();
    }
}

