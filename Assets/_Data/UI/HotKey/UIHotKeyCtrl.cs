using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHotKeyCtrl : NhoxMonoBehaviour
{
    private static UIHotKeyCtrl instance;
    public static UIHotKeyCtrl Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if(UIHotKeyCtrl.instance != null)
        {
            Debug.LogError("Only 1 UIHotKeyCtrl allow to exist");
        }
        UIHotKeyCtrl.instance = this;
    }
}
