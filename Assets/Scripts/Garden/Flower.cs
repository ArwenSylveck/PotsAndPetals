using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    private FlowerData flowerData; // Reference to static flower data
    private Animator animator;

    /// Initializes the flower visuals based on the given data and growth stage.
 
    public void Initialize(FlowerData data, int growthStage)
    {
        flowerData = data;
        animator = GetComponent<Animator>();

        UpdateVisual(growthStage);
    }

    /// Updates the flower's visuals to match its current growth stage.
    public void UpdateVisual(int growthStage)
    {
        if (animator != null)
        {
            animator.SetInteger("GrowthStage", growthStage);
        }
        else
        {
            Debug.LogWarning($"Animator not set on flower prefab: {flowerData?.flowerType}");
        }
    }
}