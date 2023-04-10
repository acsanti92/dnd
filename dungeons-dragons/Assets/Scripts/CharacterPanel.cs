using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPanel : MonoBehaviour
{
    // This is the character that the panel is displaying.
    public Character character;
    // This is the panel that displays the abilities.
    [SerializeField] AbilityPanel abilityPanel;

    private void Update()
    {
        // Update the ability panel.
        abilityPanel.UpdatePanel(character.abilities);
    }
}
