using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoController : MonoBehaviour
{
    public StatContainer playerStats;

    public PlayerDialogue playerDialogue;

    public List<Quest> activeQuestList;
    public List<Quest> completedQuestList;

    //public void UpdateQuestProgress()
    //{
    //    foreach (Quest quest in activeQuestList)
    //    {
    //        quest.
    //    }
    //}

    public float AffectStatalues(StatContainer.Stat stat)
    {
        for (int i = 0; i < playerStats.listOfStats.Count; i++)
        {
            if (playerStats.listOfStats[i].statName == stat.statName)
                playerStats.listOfStats[i].statValue += stat.statValue;

        }

        return stat.statValue;
    }
}
