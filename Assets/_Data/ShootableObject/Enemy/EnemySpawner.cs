using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    private static EnemySpawner instance;
    public static EnemySpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (EnemySpawner.instance != null)
        {
            Debug.LogError("ONLY 1 instances of EnemySpawner exist");
        }
        EnemySpawner.instance = this;
    }
}
