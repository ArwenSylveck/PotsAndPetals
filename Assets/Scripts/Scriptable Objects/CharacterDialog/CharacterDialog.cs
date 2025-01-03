using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewCharacterDialog", menuName = "Dialog/CharacterDialog")]
public class CharacterDialog : ScriptableObject
{
    public string characterID; // Unique identifier for the character
    public DialogNode startingNode; // Entry point for the dialog tree
    public List<DialogNode> allNodes; // All possible dialog nodes for this character
}
