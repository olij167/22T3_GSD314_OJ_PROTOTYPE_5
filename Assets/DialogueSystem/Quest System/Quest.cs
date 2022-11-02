using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest : ScriptableObject
{
    public QuestType questType;
    public string questName;
    public string questDescription;

    //public List<QuestGoal> questGoalsList;

    public List<QuestReward> questRewards;

    public bool isActive;
    public bool isCompleted;
    //public bool isLocked;

    //public void LockQuest(bool locked)
    //{
    //    //public bool questIsLocked;
    //}

    public void ActivateQuest()
    {
        Quest quest = this;
        PlayerInfoController playerInfo = FindObjectOfType<PlayerInfoController>();

        playerInfo.activeQuestList.Add(quest);
        quest.isActive = true;
    }

    public void CompleteQuest()
    {
        Quest quest = this;
        PlayerInfoController playerInfo = FindObjectOfType<PlayerInfoController>();

        if (!quest.isCompleted)
        {
            playerInfo.activeQuestList.Remove(quest);
            playerInfo.completedQuestList.Add(quest);
            quest.isActive = false;
            quest.isCompleted = true;

            //Give player reward

            // apply stat effects
        }
    }
    
    //public void ActivateQuest(LocationQuest quest)
    //{
    //    PlayerInfoController playerInfo = FindObjectOfType<PlayerInfoController>();

    //    playerInfo.activeQuestList.Add(quest);
    //    quest.isActive = true;
    //}

    //public void CompleteQuest(LocationQuest quest)
    //{
    //    PlayerInfoController playerInfo = FindObjectOfType<PlayerInfoController>();

    //    if (quest.GoalAchieved() && !quest.isCompleted)
    //    {

    //        playerInfo.activeQuestList.Remove(quest);
    //        playerInfo.completedQuestList.Add(quest);
    //        quest.isActive = false;
    //        quest.isCompleted = true;

    //        //Give player reward

    //        // apply stat effects
    //    }
    //} 
    
    //public void ActivateQuest(DialogueQuest quest)
    //{
    //    PlayerInfoController playerInfo = FindObjectOfType<PlayerInfoController>();

    //    playerInfo.activeQuestList.Add(quest);
    //    quest.isActive = true;
    //}

    //public void CompleteQuest(DialogueQuest quest)
    //{
    //    PlayerInfoController playerInfo = FindObjectOfType<PlayerInfoController>();

    //    if (quest.goalAchieved && !quest.isCompleted)
    //    {

    //        playerInfo.activeQuestList.Remove(quest);
    //        playerInfo.completedQuestList.Add(quest);
    //        quest.isActive = false;
    //        quest.isCompleted = true;

    //        //Give player reward

    //        // apply stat effects
    //    }
    //}

}

public enum QuestType { Waypoint, NPCLocation, Collection, NPCInteraction, /*EnvironmentInteraction*/ DialogueInteraction}

public abstract class NumericalQuest : Quest
{
    // quests that can be tracked with a number
    //for example collect x items, talk to x people, visit x rooms, etc

    public int requiredAmount;
    public int currentAmount;

    public virtual bool GoalAchieved()
    {
        return currentAmount >= requiredAmount;
    }

    public virtual int SetCurrentAmount()
    {
        int newAmount = 0;
        return currentAmount = newAmount;
    }

    public virtual int SetCurrentAmount(int newAmount)
    {
        return currentAmount = newAmount;
    }

    public virtual int IncreaseCurrentAmount()
    {
        return currentAmount++;
    }

    public virtual int DecreaseCurrentAmount()
    {
        return currentAmount--;
    }

    public virtual int ResetCurrentAmount(int originalAmount)
    {
        return currentAmount = originalAmount;
    }


}

public abstract class LocationQuest : Quest
{
    // quests that require the player to go to a location
    // for example go to waypoint, follow / meet npc, escort npc, etc

    public Transform destination;
    public Transform playerPosition;

    public float distanceToReach = 0.5f;
    public virtual bool GoalAchieved()
    {
        return Vector3.Distance(playerPosition.position, destination.position) < distanceToReach;
    }
}

public abstract class DialogueQuest : Quest
{
    public NPCInfo npc;

    public PlayerDialogueOption questDialogue;

    public bool goalAchieved;

}

//public abstract class EnvironmentQuest : ScriptableObject
//{
//    //Quests related to performing some form of environmental interaction
//    //for example inspecting elements of the environment to solve a puzzle
//}


