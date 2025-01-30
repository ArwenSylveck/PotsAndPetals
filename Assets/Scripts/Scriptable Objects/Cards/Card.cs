using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{

    [Header("Character Details")]
    public string characterName; // Name of the character
    public Sprite characterPortrait; // Character's portrait
    public CharacterDialog dialogTree; // Dialog associated with this interaction

    [Header("Card Properties")]
    public string cardID; // Unique identifier
    public int weight; // Likelihood of appearing
    public bool isRepeatable; // Can this card appear more than once?
    public int encounterCount; // Tracks how many times the card has been drawn

}
