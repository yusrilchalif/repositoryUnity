using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public List<Item> sortItem = new List<Item>();

    private void Awake() {
        BuildDatabase();
    }

    public Item GetItem(int id) {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName) {
        return items.Find(item => item.title == itemName);
    }

    public void openAllItem() {
        sortItem.Clear();
        foreach(Item i in items) {
            sortItem.Add(i);
        }
    }

    public void sortItemType(string type) {
        sortItem.Clear();
        foreach(Item i in items) {
            if(i.type.ToString() == type)
                sortItem.Add(i);
        }
    }
    
    void BuildDatabase() {
        items = new List<Item>() {
            new Item(0, "Diamond Sword", "A sword made of diamond.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 15 },
                { "Defence", 10 }
            }),
            new Item(1, "Diamond Ore", "A pretty diamond.", Item.Type.jewerly,
            new Dictionary<string, int> {
                { "Value", 300 }
            }),
            new Item(2, "Silver Pick", "A pick that could kill a vampire.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(3, "axe_diamond", "A Diamond axe made from diamond.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 30 },
                { "Defence", 10}
            }),
            new Item(4, "bowArrow", "A Bow made from stick.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 19 },
                { "Defence", 10}
            }),
            new Item(5, "hammer_gold", "A Hammer made with gold.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 22 },
                { "Defence", 12}
            }),
            new Item(6, "Diamond Pick", "A Pick made with diamond.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 25 },
                { "Defence", 15}
            }),
            new Item(7, "axe_bronze", "A axe made with bronze.", Item.Type.weapon,
            new Dictionary<string, int> {
                { "Power", 20 },
                { "Defence", 15}
            }),
            new Item(8, "Emerald Ore", "A Emerald.", Item.Type.jewerly,
            new Dictionary<string, int> {
                { "Value", 250 }
            }),
            new Item(9, "ore_ruby", "A Ruby.", Item.Type.jewerly,
            new Dictionary<string, int> {
                { "Value", 300 }
            }),
            new Item(10, "ore_coal", "A Coal", Item.Type.jewerly,
            new Dictionary<string, int>{
                {"Value", 200}
            }),
            new Item(11, "ore_iron", "A Iron", Item.Type.jewerly,
            new Dictionary<string, int>{
                {"Value", 250}
            }),
            new Item(12, "ore_silver", "A Silver", Item.Type.jewerly,
            new Dictionary<string, int>{
                {"Value", 280}
            })
        };
    }
}
