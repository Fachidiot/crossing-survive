using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "Action", menuName = "SurvivalEngine/Actions/Read", order = 50)]
    public class ActionRead : SAction
    {

        public override void DoAction(PlayerCharacter character, ItemSlot slot)
    {
            ItemData item = slot.GetItem();
            if (item != null)
            {
                ReadPanel.Get().ShowPanel(item.title, item.desc);
            }

        }

        public override bool CanDoAction(PlayerCharacter character, ItemSlot slot)
        {
            return true;
        }
    }