using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour {
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory inventoryUI;

    void Start()
    {
        StartItemInventory();
        // StartRandom();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
        }
    }

    public void StartItemInventory() {
        for (int i = 0; i < 5000; i++)
        {
            //Random a number based on items database length
            int randNum = UnityEngine.Random.Range(0, itemDatabase.items.Count);
            
            GiveItem(randNum);
        }
    }

    public void GiveItem() {
        characterItems.Clear();
        int id = UnityEngine.Random.Range(0, itemDatabase.items.Count);
        Item itemToAdd = itemDatabase.GetItem(id);

        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);        
        Debug.Log($"Added item : { itemToAdd.title }");
    }

    public void GiveSortItem()
    {
        characterItems.Clear();
        inventoryUI.RemoveAll();
        for(int i=0; i<itemDatabase.sortItem.Count; i++)
        {
            Item itemToAdd = itemDatabase.sortItem[i];

            characterItems.Add(itemToAdd);
            inventoryUI.AddNewItem(itemToAdd);  
        } 
    }

    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);

        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    
}
