using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropTest : NhoxMonoBehaviour
{
    public JunkCtrl junkCtrl;
    public int dropCount = 0;
    public List<ItemDropCount> dropCountItems = new List<ItemDropCount>();
    

    protected override void Start()
    {
        base.Start();
        InvokeRepeating(nameof(this.Droping), 2, 0.2f);
    }

    protected virtual void Droping()
    {
        this.dropCount += 1;
        Vector3 dropPos = transform.position;
        Quaternion dropRot = transform.rotation;
        List<ItemDropRate> dropItems = ItemDropSpawner.Instance.Drop(this.junkCtrl.ShootableObject.dropList, dropPos, dropRot);

        ItemDropCount itemsDropCount;
        foreach (ItemDropRate itemDropRate in dropItems)
        {
            itemsDropCount = this.dropCountItems.Find(i => i.itemName == itemDropRate.itemSO.itemName);
            if(itemsDropCount == null)
            {
                itemsDropCount = new ItemDropCount();
                itemsDropCount.itemName = itemDropRate.itemSO.itemName;
                this.dropCountItems.Add(itemsDropCount);
            }

            itemsDropCount.count += 1;
            itemsDropCount.rate = (float)Math.Round((float)itemsDropCount.count / (float)this.dropCount, 2);
        }
    }

}

[Serializable]
public class ItemDropCount
{
    public string itemName;
    public int count;
    public float rate;
}