using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarManager : MonoBehaviour
{
    private int currentDay = 0; // Tracks the current in-game day
    public DayOfTheWeek startDay = DayOfTheWeek.Monday; //Configurable start day
    public DayOfTheWeek dayOfTheWeek;
    public GameEvent timeToGrowEvent; // Reference to the ScriptableObject event

    public void AdvanceDay()
    {
        currentDay++;
        Debug.Log($"Day {currentDay}: {CurrentDayOfWeek}");

        // Raise the Time to Grow event
        timeToGrowEvent?.Raise();
    }

    public int GetDay
    {
        get
        {
            return currentDay;
        }
    }

    public DayOfTheWeek CurrentDayOfWeek
    {
        get
        {
            int startDayIndex = (int)startDay;
            int dayIndex = (currentDay+ startDayIndex) % 7;
            return (DayOfTheWeek)dayIndex;
        }
    }

    public bool isWeekend
    {
        get
        {
            bool weekend = false;
            if ((CurrentDayOfWeek == DayOfTheWeek.Saturday)||(CurrentDayOfWeek == DayOfTheWeek.Sunday))
            {
                weekend = true;
            }
            return weekend;
        }
    }
    
}

