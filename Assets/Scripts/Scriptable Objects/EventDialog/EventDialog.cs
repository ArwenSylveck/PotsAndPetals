using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEventDialog", menuName = "Dialog/EventDialog")]
public class EventDialog : ScriptableObject
{
    public string eventID; // Unique identifier for the event
    public DialogNode startingNode; // Entry point for this dialog tree
    public List<DialogNode> allNodes; // All nodes tied to this event
}
