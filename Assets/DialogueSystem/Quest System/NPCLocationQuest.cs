using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Quests/Follow-EscortNPCQuest")]
public class NPCLocationQuest : LocationQuest
{
    //Quest is completed when destination is reached && npc is present

    public Transform npcToFollow;

    public float distanceFromNPC = 10f;

    [System.Serializable]
    public enum LocationQuestType { Escort, Follow};
    public LocationQuestType locationQuestType;
    // if escort the player must guide the npc to the destination
    //NPC State: follow player 

    // if follow the player must follow npc to an unknown destination
    //NPC State: Go to destination, stop if player is outside of the distance from npc

    private void OnEnable()
    {
        questType = QuestType.NPCLocation;

    }

    public override bool GoalAchieved()
    {
        if (Vector3.Distance(playerPosition.position, destination.position) < distanceToReach && 
            Vector3.Distance(playerPosition.position, npcToFollow.position) < distanceFromNPC)
        {
            return true;
        }

        return false;
    }
}

//Requires:
    //Create NPC State Machine & Escort/Follow states
    //Set "npcToFollow" based on the quest giver
