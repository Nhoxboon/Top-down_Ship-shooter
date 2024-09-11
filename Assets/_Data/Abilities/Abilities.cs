using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : NhoxMonoBehaviour
{
    [Header("Abilities")]

    [SerializeField] protected AbilityObjetCtrl abilityObjetCtrl;
    public AbilityObjetCtrl AbilityObjetCtrl => abilityObjetCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAbilityObjectCtrl();
    }

    protected virtual void LoadAbilityObjectCtrl()
    {
        if (this.abilityObjetCtrl != null)
        {
            return;
        }

        this.abilityObjetCtrl = transform.parent.GetComponent<AbilityObjetCtrl>();
        Debug.Log(transform.name + ": LoadAbilityObjectCtrl", gameObject);
    }
}
