﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "SurvivalEngine/Actions/PetTame", order = 50)]
public class ActionPetTame : SAction
{
    public override void DoAction(PlayerCharacter character, Selectable select)
    {
        Pet pet = select.GetComponent<Pet>();
        pet.TamePet(character);
    }

    public override bool CanDoAction(PlayerCharacter character, Selectable select)
    {
        Pet pet = select.GetComponent<Pet>();
        return pet != null && !pet.HasMaster();
    }
}