using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewInteractionCard", menuName = "Shop/InteractionCard")]
public class InteractionCard : ScriptableObject
{
    [Header("Character Details")]
    public string characterName; // Name of the character
    public Sprite characterPortrait; // Character's portrait
    public CharacterDialog dialogTree; // Dialog associated with this interaction

    [Header("Card Properties")]
    public float drawWeight; // Likelihood of being drawn (e.g., 0.1, 0.5)
    public bool isRepeatable; // Can this card appear more than once?

    [Header("Availability Conditions")]
    public string requiredEventID; // Event required for this card to be drawn
    public string blockingEventID; // Event that prevents this card from being drawn
    public string triggerEventID; // Event triggered after this card is drawn
}
