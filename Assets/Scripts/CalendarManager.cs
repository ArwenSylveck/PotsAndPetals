using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarManager : MonoBehaviour
{
    public int currentDay = 0; // Tracks the current in-game day
    public GameEvent timeToGrowEvent; // Reference to the ScriptableObject event

    public void AdvanceDay()
    {
        currentDay++;
        Debug.Log($"Day {currentDay}: Time to grow!");

        // Raise the Time to Grow event
        timeToGrowEvent?.Raise();
    }
}

