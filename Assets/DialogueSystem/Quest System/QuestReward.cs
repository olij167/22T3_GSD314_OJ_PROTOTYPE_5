using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public class QuestReward
{
    public List<Reward> rewards;

    [System.Serializable]
#if UNITY_EDITOR
    public struct Reward
    {
        public RewardType rewardType;


        //[HideIfEnumValue("rewardType", HideIf.Equal, (int)RewardType.item)]
        public GameObject itemReward;

        //[HideIfEnumValue("rewardType", HideIf.NotEqual, (int)RewardType.statAffect)]
        public NPCMood.Emotion statToAffect;

        //[HideIfEnumValue("rewardType", HideIf.NotEqual, (int)RewardType.unlockDialogue)]
        public PlayerDialogueOption unlockedPlayerDialogueOption;

        //[HideIfEnumValue("rewardType", HideIf.NotEqual, (int)RewardType.unlockDialogue)]
        public NPCDialogueOption unlockedNPCDialogueOption;
    }
#endif

}

public enum RewardType { item, statAffect, unlockDialogue } // add others as relevant

//[CustomEditor(typeof(QuestReward))]
//public class QuestRewardEditor : Editor
//{


//    public override void OnInspectorGUI()
//    {
//        base.OnInspectorGUI();

//        Quest quest = (Quest)target;
//        if (quest == null) return;

//        foreach(QuestReward reward in quest.questRewards)
//        {
            
//        }
//    }
//}

