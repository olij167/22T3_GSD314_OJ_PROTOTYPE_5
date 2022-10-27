using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quests/WaypointQuest")]
public class WaypointQuest : LocationQuest
{
    //Quest completed when destination is reached

    private void OnEnable()
    {
        questType = QuestType.Waypoint;

    }
    public override bool GoalAchieved()
    {
        return base.GoalAchieved();
    }
}
