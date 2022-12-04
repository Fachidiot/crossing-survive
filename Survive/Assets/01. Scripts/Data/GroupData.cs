using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GroupData", menuName = "SurvivalEngine/GroupData", order = 1)]
public class GroupData : ScriptableObject
{
    public string group_id;
    public string title;
    public Sprite icon;
}