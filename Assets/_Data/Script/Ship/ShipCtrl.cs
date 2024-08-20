using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCtrl : NhoxMonoBehaviour
{
    [SerializeField] protected Inventory inventory;

    public Inventory Inventory { get => inventory; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInventory();
    }

    protected virtual void LoadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = GetComponentInChildren<Inventory>();
        Debug.LogWarning(transform.name + " LoadInventory", gameObject);
    }
}
