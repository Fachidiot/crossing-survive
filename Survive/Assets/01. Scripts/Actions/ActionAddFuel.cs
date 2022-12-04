using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "SurvivalEngine/Actions/AddFuel", order = 50)]
public class ActionAddFuel : MAction
{
    public float range = 2f;

    //Merge action
    public override void DoAction(PlayerCharacter character, ItemSlot slot, Selectable select)
    {
        Firepit fire = select.GetComponent<Firepit>();
        InventoryData inventory = slot.GetInventory();
        if (fire != null && slot.GetItem() && inventory.HasItem(slot.GetItem().id))
        {
            fire.AddFuel(fire.wood_add_fuel);
            inventory.RemoveItemAt(slot.index, 1);
        }

    }

}