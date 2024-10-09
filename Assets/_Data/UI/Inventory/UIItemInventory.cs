using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIItemInventory : NhoxMonoBehaviour
{
    [Header("UI Item Inventory")]

    [SerializeField] protected ItemInventory itemInventory;
    public ItemInventory ItemInventory => itemInventory;

    [SerializeField] protected TextMeshProUGUI itemName;
    public TextMeshProUGUI ItemName => itemName;

    [SerializeField] protected TextMeshProUGUI itemNumber;
    public TextMeshProUGUI ItemNumber => itemNumber;

    [SerializeField] protected Image itemSprite;
    public Image ItemSprite => itemSprite;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemName();
        this.LoadItemNumber();
        this.LoadItemSprite();
    }

    protected virtual void LoadItemName()
    {
        if (this.itemName != null) return;
        this.itemName = this.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
        Debug.LogWarning(transform.name + " :LoadItemName", gameObject);
    }

    protected virtual void LoadItemNumber()
    {
        if (this.itemNumber != null) return;
        this.itemNumber = this.transform.Find("ItemNumber").GetComponent<TextMeshProUGUI>();
        Debug.LogWarning(transform.name + " :LoadItemNumber", gameObject);
    }

    protected virtual void LoadItemSprite()
    {
        if (this.itemSprite != null) return;
        this.itemSprite = this.transform.Find("ItemSprite").GetComponent<Image>();
        Debug.LogWarning(transform.name + " :LoadItemSprite", gameObject);
    }

    public virtual void ShowItem(ItemInventory item)
    {
        this.itemInventory = item;
        this.itemName.text = this.itemInventory.itemProfile.itemName;
        this.itemNumber.text = this.itemInventory.itemCount.ToString();
        this.itemSprite.sprite = this.itemInventory.itemProfile.sprite;
    }
}
