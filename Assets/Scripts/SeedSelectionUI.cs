using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SeedSelectionUI : MonoBehaviour
{
    public Button fireSeedButton;
    public Button waterSeedButton;
    public Button windSeedButton;

    public FlowerData fireSeedData;
    public FlowerData waterSeedData;
    public FlowerData windSeedData;

    private void Start()
    {
        fireSeedButton.onClick.AddListener(() => SeedSelectionManager.Instance.SelectSeed(fireSeedData));
        waterSeedButton.onClick.AddListener(() => SeedSelectionManager.Instance.SelectSeed(waterSeedData));
        windSeedButton.onClick.AddListener(() => SeedSelectionManager.Instance.SelectSeed(windSeedData));
    }
}
