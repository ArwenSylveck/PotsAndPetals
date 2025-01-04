using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFlower", menuName = "Flowers/FlowerData")]
public class FlowerData : ScriptableObject
{
    public string flowerName;           // Name of the flower
    public int maxGrowthStage;          // Number of of days to reach max growth
    public int cost;                    // Cost to plant/buys
    public int sellPrice;               // Price when sold (optional if not needed)
    
    //public RuntimeAnimatorController animatorController; // Animator for flower animations

    // Magic-Specific Properties
    public enum MagicType { None, Fire, Water, Wind }
    public MagicType magicType;         // Type of magic the flower possesses
    public string uniqueTrait;          // Description of the flower's magic ability
    public string specialMechanic;      // Gameplay effect (e.g., speeds adjacent growth)
}
