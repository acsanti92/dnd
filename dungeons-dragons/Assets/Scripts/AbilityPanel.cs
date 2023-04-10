using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityPanel : MonoBehaviour
{
    // List of ability UI elements.
    [SerializeField] List<AbilityUIElement> abilityUI;

    // Reference to the character panel.
    CharacterPanel characterPanel;

    // Called when the script is loaded or a value is changed in the inspector.
    private void Start()
    {
        characterPanel = GetComponentInParent<CharacterPanel>();
    }

    // Update the ability panel.
    public void UpdatePanel(List<Ability> abilities)
    {
        for (int i = 0; i < abilityUI.Count; i++)
        {
            abilityUI[i].Set(abilities[i]);
        }
    }

    // Add an ability score to the character.
    public void AddAbilityScore(CharacterAbility ability)
    {
        characterPanel.character.ChangeAbilityScore(ability, 1);
    }

    // Remove an ability score to the character.
    public void RemoveAbilityScore(CharacterAbility ability)
    {
        characterPanel.character.ChangeAbilityScore(ability, -1);
    }
}
