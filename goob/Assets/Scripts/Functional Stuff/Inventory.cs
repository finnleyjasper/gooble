using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> inventoryList = new List<Item>();

    public void AddItem(Item item)
    {
        inventoryList.Add(item);
    }
}
