using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjAppearing : NhoxMonoBehaviour
{
    [Header("Obj Appearing")]

    [SerializeField] protected bool appeared = false;
    [SerializeField] protected List<IObjAppearObserver> observers = new List<IObjAppearObserver>(); //Observer Pattern(ShootableObjectAbtract, ObjAppearWithoutShoot, ObjAppearing)

    public bool Appeared => appeared;

    protected override void Start()
    {
        base.Start();
        this.OnAppearStart();
    }
    //protected override void OnEnable()
    //{
    //    base.OnEnable();
    //    this.OnAppearStart();
    //}
    protected override void OnDisable()
    {
        base.OnDisable();
        this.appeared = false;
        this.OnAppearStart();
    }

    protected virtual void FixedUpdate()
    {
        this.Appearing();
    }

    protected abstract void Appearing();

    public virtual void Appear()
    {
        this.appeared = true;
        this.OnAppearFinish();
    }

    public virtual void ObserverAdd(IObjAppearObserver observer)
    {
        this.observers.Add(observer);
    }

    protected virtual void OnAppearStart()
    {
        foreach(IObjAppearObserver observer in this.observers)
        {
            observer.OnAppearStart();
        }
    }

    protected virtual void OnAppearFinish()
    {
        foreach (IObjAppearObserver observer in this.observers)
        {
            observer.OnAppearFinish();
        }
    }
}
