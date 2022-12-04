using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "SurvivalEngine/Actions/PetFollow", order = 50)]
public class ActionPetFollow : SAction
{
    public override void DoAction(PlayerCharacter character, Selectable select)
    {
        Pet pet = select.GetComponent<Pet>();
        pet.Follow();
    }

    public override bool CanDoAction(PlayerCharacter character, Selectable select)
    {
        Pet pet = select.GetComponent<Pet>();
        return pet != null && pet.GetMaster() == character && !pet.IsFollow();
    }
}