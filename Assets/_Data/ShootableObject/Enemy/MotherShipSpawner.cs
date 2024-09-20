using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShipSpawner : Spawner
{
    private static MotherShipSpawner instance;
    public static MotherShipSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (MotherShipSpawner.instance != null)
        {
            Debug.LogError("ONLY 1 instances of MotherShipSpawner exist");
        }
        MotherShipSpawner.instance = this;
    }
}
