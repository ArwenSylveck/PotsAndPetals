using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlotSaveData
{
    public int plotID;
    public bool isOccupied;
    public FlowerType plantedFlowerType; // Enum instead of ID
    public int growthStage;
}