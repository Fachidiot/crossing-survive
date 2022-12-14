using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "SurvivalEngine/Actions/ActivateTrap", order = 50)]
public class ActionSetTrap : SAction
{
    public override void DoAction(PlayerCharacter character, Selectable select)
    {
        Trap trap = select.GetComponent<Trap>();
        if (trap != null)
            trap.Activate();
    }

    public override bool CanDoAction(PlayerCharacter character, Selectable select)
    {
        Trap trap = select.GetComponent<Trap>();
        if (trap != null)
            return !trap.IsActive();
        return false;
    }
}