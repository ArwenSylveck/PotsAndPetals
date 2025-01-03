using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFlower", menuName = "Flowers/FlowerData")]
public class FlowerData : ScriptableObject
{
    public string flowerName;
    public Sprite flowerSprite;
    public int growthTime; // Days to fully grow
    public int sellPrice;
}