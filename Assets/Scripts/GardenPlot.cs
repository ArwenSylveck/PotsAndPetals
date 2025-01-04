using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenPlot : MonoBehaviour
{
    public int plotID; // Unique identifier for this plot
    public FlowerData plantedFlower;   // Reference to the planted flower ScriptableObject
    public int currentGrowthStage = 0; // Tracks growth stage (0: Seedling, 1: Budding, 2: Blooming)
    public bool isOccupied = false;    // Whether a flower is currently planted

    //private Animator flowerAnimator;

    public void PlantFlower(FlowerData flower)
    {
        plantedFlower = flower;
        isOccupied = true;
        currentGrowthStage = 0;

        //flowerAnimator = GetComponent<Animator>();
        //flowerAnimator.runtimeAnimatorController = plantedFlower.animatorController;

        //UpdateGrowthAnimation();
    }

    public void Grow()
    {
        if (isOccupied)
        {
            if (currentGrowthStage < plantedFlower.maxGrowthStage)
            {
                currentGrowthStage++;
                //UpdateGrowthAnimation();
            }
        }
    }

    /*
    void UpdateGrowthAnimation()
    {
        if (flowerAnimator != null)
        {
            flowerAnimator.SetInteger("growthStage", currentGrowthStage);
        }
    }
    */
    
    public void ClearPlot()
    {
        plantedFlower = null;
        isOccupied = false;
        currentGrowthStage = 0;
    }
}

