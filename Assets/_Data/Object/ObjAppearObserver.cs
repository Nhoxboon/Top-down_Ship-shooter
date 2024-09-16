using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjAppearObserver
{
    //Observer Pattern(ShootableObjectAbtract, ObjAppearWithoutShoot, ObjAppearing)
    public abstract void OnAppearStart();

    public abstract void OnAppearFinish();
}
