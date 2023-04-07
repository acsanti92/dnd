using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityUIElement : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI abilityScore;
    internal void SetAbility(Ability ability)
    {
        abilityScore.text = ability.abilityScore.ToString();
    }
}
