using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityPanel : MonoBehaviour
{
    // 
    [SerializeField] List<AbilityUIElement> abilityUI;

    //
    public void UpdatePanel(List<Ability> abilityUI)
    {
        for (int i = 0; i < abilityUI.Count; i++)
        {
            abilityUI[i].SetAbility(abilities[i]);
        }
    }
}
