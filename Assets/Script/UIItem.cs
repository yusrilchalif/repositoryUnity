﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public Item item;
    private Image spriteImage;
    private UIItem selectedItem;
    private Tooltip tooltip;

    void Awake()
    {
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        tooltip = GameObject.Find("Tooltip").GetComponent<Tooltip>();
        spriteImage = GetComponent<Image>();
        UpdateItem(null);
    }

    public void UpdateItem(Item item)
    {
        this.item = item;
        if (this.item != null)
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = item.icon;
        }
        else
        {
            spriteImage.color = Color.clear;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       if (this.item != null)
       {
            tooltip.GenerateTooltip(this.item);
       }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.gameObject.SetActive(false);
    }
}
