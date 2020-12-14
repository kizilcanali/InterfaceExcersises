﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour, ICollectable , IInteractable
{
    Player p;
    int BulletValue = 1;
    private void Awake()
    {
        p = FindObjectOfType<Player>().GetComponent<Player>();
    }
    public void CollectItem()
    {
        p.BulletAmount += BulletValue;
        UIManager.Instance.UpdateBulletAmount(p.BulletAmount);
        Destroy(this.gameObject);
    }

    public void InteractItem()
    {
        CollectItem();
    }
}
