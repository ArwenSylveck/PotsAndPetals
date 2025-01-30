using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSelectionManager : MonoBehaviour
{
    public static SeedSelectionManager Instance { get; private set; }

    public FlowerData selectedSeed;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SelectSeed(FlowerData seed)
    {
        selectedSeed = seed;
        Debug.Log($"Selected Seed: {seed.flowerType}");
    }

    public void ClearSelection()
    {
        selectedSeed = null;
        Debug.Log("Seed selection cleared.");
    }

    public bool HasSelectedSeed()
    {
        return selectedSeed != null;
    }
}

