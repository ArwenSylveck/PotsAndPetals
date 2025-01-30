using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardManager : MonoBehaviour
{
    public List<CardDeck> allDecks; // Master list of all decks
    private List<Card> currentPool = new List<Card>(); // Cards in the active pool

    public WeatherCondition currentWeather; // Current weather
    public TimeOfDay currentTimeOfDay; // Current time of day

    public void ShuffleDeck()
    {
        currentPool.Clear();

        foreach (var deck in allDecks)
        {
            if (IsDeckActive(deck))
            {
                foreach (var card in deck.cards)
                {
                    if (IsCardAvailable(card))
                    {
                        currentPool.Add(card);
                    }
                }
            }
        }
    }

    private bool IsDeckActive(CardDeck deck)
    {
        // Check prerequisites for the deck
        foreach (var prerequisite in deck.prerequisiteDecks)
        {
            if (!IsDeckActiveByID(prerequisite)) return false;
        }

        // Check weather conditions
        if (deck.validWeatherConditions.Length > 0 && !IsWeatherValid(deck.validWeatherConditions))
            return false;

        // Check time of day
        if (deck.validTimeOfDay.Length > 0 && !IsTimeOfDayValid(deck.validTimeOfDay))
            return false;

        return deck.isActive; // Only include decks marked as active
    }

    private bool IsDeckActiveByID(string deckID)
    {
        var deck = allDecks.Find(d => d.deckID == deckID);
        return deck != null && deck.isActive;
    }

    private bool IsWeatherValid(WeatherCondition[] conditions)
    {
        if (conditions == null || conditions.Length == 0) return true;

        foreach (var weather in conditions)
        {
            if (weather == currentWeather)
                return true;
        }
        return false;
    }


    private bool IsTimeOfDayValid(TimeOfDay[] conditions)
    {
        if (conditions == null || conditions.Length == 0) return true;

        foreach (var time in conditions)
        {
            if (time == currentTimeOfDay)
                return true;
        }
        return false;
    }


    private bool IsCardAvailable(Card card)
    {
        // Check repeatable logic
        if (!card.isRepeatable && card.encounterCount > 0)
        {
            return false;
        }

        return true;
    }

    private bool IsCardEncountered(string cardID)
    {
        foreach (var deck in allDecks)
        {
            var card = deck.cards.Find(c => c.cardID == cardID);
            if (card != null && card.encounterCount > 0)
                return true;
        }
        return false;
    }

    public Card DrawCard()
    {
        if (currentPool.Count == 0) return null;

        int totalWeight = 0;
        foreach (var card in currentPool)
        {
            totalWeight += card.weight;
        }

        int randomValue = Random.Range(0, totalWeight);
        foreach (var card in currentPool)
        {
            if (randomValue < card.weight)
            {
                currentPool.Remove(card);
                card.encounterCount++;
                return card;
            }
            randomValue -= card.weight;
        }

        return null; // Fallback
    }

    public void ActivateDeck(string deckID)
    {
        var deck = allDecks.Find(d => d.deckID == deckID);
        if (deck != null) deck.isActive = true;
    }

    public void DeactivateDeck(string deckID)
    {
        var deck = allDecks.Find(d => d.deckID == deckID);
        if (deck != null) deck.isActive = false;
    }
}
