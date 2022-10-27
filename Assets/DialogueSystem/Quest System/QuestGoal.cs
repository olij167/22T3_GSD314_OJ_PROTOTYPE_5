using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


// CHANGE QUEST TYPES TO SCRIPTABLE OBJECTS
// MAKE QUEST GOAL DISPLAY A FIELD FOR THE SET QUEST TYPE IN THE INSPECTOR

//[System.Serializable]
//public abstract class QuestGoal : ScriptableObject
//{
//    public GoalType goalType;
//    public bool goalAchieved;

//    public abstract void Goal();

//    public virtual bool GoalAchieved()
//    {
//        return goalAchieved = true;
//    }
//}

//[CreateAssetMenu(menuName = "Quests/Numerical")]


//[CreateAssetMenu(menuName = "Quests/Location")]


//[CreateAssetMenu(menuName = "Quests/Dialogue")]
//public abstract class DialogueQuest : ScriptableObject
//{
//    //Quests that require the player to discuss something with a specified npc
//    //for example conveying a message between npc's, convincing an npc of something, etc


//}

//[CreateAssetMenu(menuName = "Quests/Environmental")]
//public abstract class EnvironmentQuest : ScriptableObject
//{
//    //Quests related to performing some form of environmental interaction
//    //for example inspecting elements of the environment to solve a puzzle


//}



//#if UNITY_EDITOR
//[CustomEditor(typeof(QuestGoal))]

//public class QuestGoalInspectorEditor : Editor
//{
//    GoalType goalType;
//    public override void OnInspectorGUI()
//    {
//        base.OnInspectorGUI();

//        PlayerInfoController playerInfo = (PlayerInfoController)target;
//        if (playerInfo == null) return;

//        for (int i = 0; i < playerInfo.activeQuestList.Count; i++)
//        {
//            for (int q = 0; q < playerInfo.activeQuestList[i].questGoalsList.Count; q++)
//            {
//                goalType = playerInfo.activeQuestList[i].questGoalsList[q].goalType;

//                switch (goalType)
//                {
//                    case GoalType.Waypoint:
//                        LocationQuest waypointQuest = new LocationQuest();

//                        playerInfo.activeQuestList[i].questGoalsList[q].goal = waypointQuest;
//                        waypointQuest.destination = EditorGUILayout.Vector3Field("Destination:", waypointQuest.destination);
//                        waypointQuest.playerPosition = EditorGUILayout.Vector3Field("Position", waypointQuest.playerPosition);

//                        break;

//                    case GoalType.Escort:
//                        LocationQuest escortQuest = new LocationQuest();

//                        playerInfo.activeQuestList[i].questGoalsList[q].goal = escortQuest;
//                        escortQuest.destination = EditorGUILayout.Vector3Field("Destination:", escortQuest.destination);
//                        escortQuest.playerPosition = EditorGUILayout.Vector3Field("Position", escortQuest.playerPosition);


//                        break;

//                    case GoalType.Follow:
//                        LocationQuest followQuest = new LocationQuest();

//                        playerInfo.activeQuestList[i].questGoalsList[q].goal = followQuest;
//                        followQuest.destination = EditorGUILayout.Vector3Field("Destination:", followQuest.destination);
//                        followQuest.playerPosition = EditorGUILayout.Vector3Field("Position", followQuest.playerPosition);
//                        break;

//                    case GoalType.Collection:
//                        NumericalQuest numericalQuest = new NumericalQuest();

//                        playerInfo.activeQuestList[i].questGoalsList[q].goal = numericalQuest;
//                        numericalQuest.requiredAmount = EditorGUILayout.IntField("Required Amount:", numericalQuest.requiredAmount);
//                        numericalQuest.currentAmount = EditorGUILayout.IntField("Current Amount:", numericalQuest.currentAmount);
//                        break;

//                    case GoalType.EnvironmentInteraction:
//                        EnvironmentQuest environmentQuest = new EnvironmentQuest();

//                        playerInfo.activeQuestList[i].questGoalsList[q].goal = environmentQuest;

//                        break;

//                    case GoalType.DialogueInteraction:
//                        DialogueQuest dialogueQuest = new DialogueQuest();

//                        playerInfo.activeQuestList[i].questGoalsList[q].goal = dialogueQuest;
//                        break;
//                }
//            }
//        }
//    }

//    public void ChangeQuestTypeInspector()
//    {
//    }
//}
//#endif

