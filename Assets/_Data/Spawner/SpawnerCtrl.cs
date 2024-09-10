using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : NhoxMonoBehaviour
{
    [SerializeField] protected Spawner spawner;
    public Spawner Spawner => spawner;


    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints => spawnPoints;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadSpawnPoints();
    }

    protected virtual void LoadJunkSpawner()
    {
        if(this.spawner != null)
        {
            return;
        }
        this.spawner = GetComponent<Spawner>();
        Debug.Log(transform.name + ": Load Spawner", gameObject);
    }

    protected virtual void LoadSpawnPoints()
    {
        if (this.spawnPoints != null)
        {
            return;
        }
        this.spawnPoints = Transform.FindObjectOfType<SpawnPoints>();
        Debug.Log(transform.name + ": Load SpawnPoints", gameObject);
    }
}
