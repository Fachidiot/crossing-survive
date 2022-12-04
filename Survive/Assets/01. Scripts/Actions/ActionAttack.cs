using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "SurvivalEngine/Actions/Attack", order = 50)]
public class ActionAttack : SAction
{
    public override void DoAction(PlayerCharacter character, Selectable select)
    {
        if (select.GetDestructible())
        {
            character.Attack(select.GetDestructible());
        }
    }
}