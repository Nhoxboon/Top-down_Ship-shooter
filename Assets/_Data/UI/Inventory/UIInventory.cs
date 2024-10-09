using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : UIInventoryAbstract
{
    [Header("UI Inventory")]

    [SerializeField] protected InventorySort inventorySort = InventorySort.ByName;

    private static UIInventory instance;
    public static UIInventory Instance => instance;

    protected bool isOpen = true;


    protected override void Awake()
    {
        base.Awake();
        if (UIInventory.instance != null) Debug.LogError("Only 1 UIInventory allow to exist");
        UIInventory.instance = this;
    }

    protected override void Start()
    {
        base.Start();
        //this.Close();

        InvokeRepeating(nameof(this.ShowItems), 1, 1);
    }

    protected virtual void FixedUpdate()
    {
        //this.ShowItem();
    }

    public virtual void Toggle()
    {
        this.isOpen = !this.isOpen;
        if (this.isOpen) this.Open();
        else this.Close();
    }

    public virtual void Open()
    {
        this.inventoryCtrl.gameObject.SetActive(true);
        this.isOpen = true;
    }

    public virtual void Close()
    {
        this.inventoryCtrl.gameObject.SetActive(false);
        this.isOpen = false;
    }

    protected virtual void ShowItems()
    {
        if (!this.isOpen) return;

        this.ClearItems();

        List<ItemInventory> items = PlayerCtrl.Instance.CurrentShip.Inventory.Items;
        UIInvItemSpawner spawner = this.inventoryCtrl.InvItemSpawner;

        foreach (ItemInventory item in items)
        {
            spawner.SpawnItem(item);
        }

        this.SortItems();
    }

    protected virtual void SortItems()
    {
        switch (this.inventorySort)
        {
            case InventorySort.ByName:
                Debug.Log("Sort by name");
                break;
            case InventorySort.ByCount:
                Debug.Log("Sort by count");
                break;
            default:
                Debug.Log("No sort");
                break;
        }
    }

    protected virtual void ClearItems()
    {
        this.inventoryCtrl.InvItemSpawner.ClearItems();
    }


}
