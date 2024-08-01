using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDispawn : DespawnByDistance
{
    protected override void DespawnObject()
    {
        BulletSpawner.Instance.Despawn(transform.parent);
    }
}
