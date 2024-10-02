using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : NhoxMonoBehaviour
{
    private static UIInventory instance;
    public static UIInventory Instance => instance;

    protected bool isOpen = false;

    protected override void Awake()
    {
        base.Awake();
        if (instance != null)
        {
            Debug.LogError("Only 1 instance of UIinventory is allowed");
        }
        UIInventory.instance = this;
    }

    protected override void Start()
    {
        base.Start();
        //this.Close();
    }

    protected virtual void FixedUpdate()
    {
        this.ShowItem();
    }

    public virtual void Toggle()
    {
        this.isOpen = !this.isOpen;
        if(this.isOpen)
        {
            Open();
        }
        else
        {
            Close();
        }
    }

    public virtual void Open()
    {
        gameObject.SetActive(true);
        this.isOpen = true;
    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
        this.isOpen = false;
    }

    protected virtual void ShowItem()
    {
        if (!this.isOpen) return;
        float itemCount = PlayerCtrl.Instance.CurrentShip.Inventory.Items.Count;
        Debug.Log("ShowItem: " + itemCount);
    }
}
