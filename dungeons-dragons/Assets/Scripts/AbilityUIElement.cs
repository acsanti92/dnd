using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityUIElement : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI abilityScore;
    [SerializeField] TMPro.TextMeshProUGUI abilityMod;

    internal void Set(Ability ability)
    {
        abilityScore.text = ability.abilityScore.ToString();
        abilityMod.text = ability.Mod.ToString();
    }
}
