using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component
    public Sprite[] growthStageSprites; // Array of sprites for each growth stage

    private FlowerData flowerData;
    private int currentGrowthStage;

    public void Initialize(FlowerData data, int growthStage)
    {
        flowerData = data;
        currentGrowthStage = growthStage;

        UpdateVisual(growthStage);
    }

    public void UpdateVisual(int growthStage)
    {
        if (growthStageSprites == null || growthStageSprites.Length == 0)
        {
            Debug.LogWarning("No growth stage sprites assigned to the flower!");
            return;
        }

        currentGrowthStage = Mathf.Clamp(growthStage, 0, growthStageSprites.Length - 1);
        spriteRenderer.sprite = growthStageSprites[currentGrowthStage];

        Debug.Log($"Flower updated to growth stage: {currentGrowthStage}");
    }
}
