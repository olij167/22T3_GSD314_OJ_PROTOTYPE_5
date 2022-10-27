using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionQuest : NumericalQuest
{
    public InventoryItem inventoryItem;

    private Inventory inventory;

    private void OnEnable()
    {
        inventory = FindObjectOfType<Inventory>();
        questType = QuestType.Collection;
    }
    public override bool GoalAchieved()
    {
        return base.GoalAchieved();
    }

    public override int SetCurrentAmount()
    {

        foreach (InventoryItem item in inventory.inventory)
        {
            if (item == inventoryItem)
            {
                int newAmount = item.numCarried;
                return base.SetCurrentAmount(newAmount);
            }
        }

        return default;
        
    }
}
