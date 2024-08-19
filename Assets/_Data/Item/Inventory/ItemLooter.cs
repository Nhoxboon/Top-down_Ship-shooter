using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]


public class ItemLooter : NhoxMonoBehaviour
{
    [SerializeField] protected Inventory inventory;
    [SerializeField] protected SphereCollider _collider;
    [SerializeField] protected Rigidbody _rigidbody;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInventory();
        this.LoadTrigger();
        this.LoadRigidbody();
    }

    protected virtual void LoadInventory()
    {
        if (inventory != null)
        {
            return;
        }
        this.inventory = transform.parent.GetComponent<Inventory>();
        Debug.Log(transform.name + " Load Inventory", gameObject);
    }

    protected virtual void LoadTrigger()
    {
        if (_collider != null)
        {
            return;
        }
        _collider = GetComponent<SphereCollider>();
        _collider.isTrigger = true;
        _collider.radius = 0.3f;
        Debug.Log(transform.name + " Load Trigger", gameObject);
    }

    protected virtual void LoadRigidbody()
    {
        if (_rigidbody != null)
        {
            return;
        }
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = false;
        Debug.Log(transform.name + " Load Rigidbody", gameObject);
    }

    protected virtual void OnTriggerEnter(Collider collider)
    {
        ItemPickupable itemPickupable = collider.GetComponent<ItemPickupable>();
        if(itemPickupable == null)
        {
            return;
        }
        Debug.Log(collider.name);
        Debug.Log(collider.transform.parent.name);
    }
}
