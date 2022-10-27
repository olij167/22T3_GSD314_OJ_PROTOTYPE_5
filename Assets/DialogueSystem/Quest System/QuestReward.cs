using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestReward 
{
    public List<Reward> rewards;

    public class Reward
    {
        public RewardType rewardType;

        public List<GameObject> itemRewardsList;
        public List<NPCMood.Emotion> statsToAffectList;
        public List<PlayerDialogueOption> unlockedPlayerDialogueOptionsList;
        public List<NPCDialogueOption> unlockedNPCDialogueOptionsList;

    }
}

public enum RewardType { item, statAffect, unlockDialogue } // add others as relevant
