using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// These are the six ability scores that are used to determine a character's attributes.
public enum CharacterAbility
{
    Strength,
    Dexterity,
    Constitution,
    Intelligence,
    Wisdom,
    Charisma
}
[Serializable]

// This is a class that holds the ability score and the score itself.
public class Ability
{
    public int abilityScore;
    public CharacterAbility ability;

    // This is the modifier for the ability score.
    public int Mod
    {
        get
        {
            int mod = abilityScore - 10;
            mod += mod < 0 ? -1 : 0;
            return mod / 2;
        }
    }

    public Ability(CharacterAbility ability, int abilityScore)
    {
        this.ability = ability;
        this.abilityScore = abilityScore;
    }
}

[CreateAssetMenu]

public class Character : ScriptableObject
{
    // List of abilities that the character has.
    public List<Ability> abilities;

    //
    internal void ChangeAbilityScore(CharacterAbility ability, int amount)
    {
        Ability a = abilities[(int)ability];
        a.abilityScore += amount;
    }

    // This is called when the script is loaded or a value is changed in the inspector.
    void Reset()
    {
        abilities = new List<Ability>();
        abilities.Add(new Ability(CharacterAbility.Strength, 10));
        abilities.Add(new Ability(CharacterAbility.Dexterity, 10));
        abilities.Add(new Ability(CharacterAbility.Constitution, 10));
        abilities.Add(new Ability(CharacterAbility.Intelligence, 10));
        abilities.Add(new Ability(CharacterAbility.Wisdom, 10));
        abilities.Add(new Ability(CharacterAbility.Charisma, 10));
    }
}
