using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHotKeyAbstract : NhoxMonoBehaviour
{
    [SerializeField] protected UIHotKeyCtrl hotKeyCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUIHotKeyCtrl();
    }

    protected virtual void LoadUIHotKeyCtrl()
    {
        if (this.hotKeyCtrl != null) return;
        this.hotKeyCtrl = transform.parent.GetComponent<UIHotKeyCtrl>();
        Debug.Log(transform.name + " :LoadUIHotKeyCtrl", gameObject);
    }
}
