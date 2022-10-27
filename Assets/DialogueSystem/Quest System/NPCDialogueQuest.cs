using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("Quests/NPCDialogueQuest"))]
public class NPCDialogueQuest : DialogueQuest
{
    private DialogueListSystem dialogueSystem;
    private void OnEnable()
    {
        questType = QuestType.DialogueInteraction;
        dialogueSystem = FindObjectOfType<DialogueListSystem>();
    }

    public void CompleteQuest()
    {
        if (dialogueSystem.npc == npc && dialogueSystem.selectedDialogueOption == questDialogue)
        {
            goalAchieved = true;
        }
    }
}
