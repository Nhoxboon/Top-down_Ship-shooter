using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCtrl : AbilityObjetCtrl
{
    [Header("Ship")]
    [SerializeField] protected Inventory inventory;

    public Inventory Inventory { get => inventory; }

    protected override string GetObjectTypeString()
    {
        return ObjectType.Ship.ToString();
    }

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
