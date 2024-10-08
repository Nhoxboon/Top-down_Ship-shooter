using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryCtrl : NhoxMonoBehaviour
{
    [Header("Inv Item Ctrl")]

    [SerializeField] protected Transform content;
    public Transform Content => content;

    
    [SerializeField] protected UIInvItemSpawner invItemSpawner;
    public UIInvItemSpawner InvItemSpawner => invItemSpawner;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadContent();
        this.LoadItemSpawner();
    }

    protected virtual void LoadContent()
    {
        if (this.content != null) return;
        this.content = this.transform.Find("Scroll View").Find("Viewport").Find("Content");
        Debug.LogWarning(transform.name + " :LoadContent", gameObject);
    }

    protected virtual void LoadItemSpawner()
    {
        if (this.invItemSpawner != null) return;
        this.invItemSpawner = transform.GetComponentInChildren<UIInvItemSpawner>();
        Debug.LogWarning(transform.name + " :LoadItemSpawner", gameObject);
    }
}
