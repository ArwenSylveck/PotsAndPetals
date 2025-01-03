using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewDialogNode", menuName = "Dialog/DialogNode")]
public class DialogNode : ScriptableObject
{
    [Header("Dialog Details")]
    public string characterName; // Name of the speaking character
    public Sprite characterPortrait; // Character's portrait in the dialog UI
    [TextArea] public string dialogText; // The actual dialog text
    
    [Header("Dialog Options")]
    public List<DialogOption> options; // Possible player responses

    [Header("Event Triggers")]
    public string eventID; // Unique ID for tying to specific events
    public bool isTerminalNode; // Marks the end of a dialog sequence
}

[System.Serializable]
public class DialogOption
{
    public string optionText; // Text shown to the player
    public DialogNode nextNode; // Next dialog node if chosen
    public string requiredEventID; // Event condition to enable this option
    public string triggerEventID; // Event triggered after this option is chosen
}