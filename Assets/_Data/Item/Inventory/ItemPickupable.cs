using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : NhoxMonoBehaviour
{
    [SerializeField] protected SphereCollider _collider;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTrigger();
    }

    protected virtual void LoadTrigger()
    {
        if (_collider != null)
        {
            return;
        }
        _collider = GetComponent<SphereCollider>();
        _collider.isTrigger = true;
        _collider.radius = 0.1f;
        Debug.Log(transform.name + " Load Trigger", gameObject);
    }
}
