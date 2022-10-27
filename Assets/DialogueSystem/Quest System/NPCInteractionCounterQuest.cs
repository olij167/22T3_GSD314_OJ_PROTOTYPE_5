using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quests/NPCInteractionQuest")]
public class NPCInteractionCounterQuest : NumericalQuest
{
    //interact with the required amount of npcs

    private PlayerInteractionRaycast playerInteractionRaycast;

    public List<NPCBrain> interactionNPCList; // make sure the player talks to different people

    private void OnEnable()
    {
        playerInteractionRaycast = FindObjectOfType<PlayerInteractionRaycast>();

        questType = QuestType.NPCInteraction;

    }
    public override bool GoalAchieved()
    {
        return base.GoalAchieved();
    }

    public override int IncreaseCurrentAmount()
    {
        if (playerInteractionRaycast.selectedObject.GetComponent<NPCBrain>())
        {
            if (!interactionNPCList.Contains(playerInteractionRaycast.selectedObject.GetComponent<NPCBrain>()))
            {
                interactionNPCList.Add(playerInteractionRaycast.selectedObject.GetComponent<NPCBrain>());
                return base.IncreaseCurrentAmount();
            }
        }

        return default;
    }

    public override int ResetCurrentAmount(int originalAmount)
    {
        return base.ResetCurrentAmount(originalAmount);
    }
}
