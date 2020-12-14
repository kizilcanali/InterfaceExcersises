﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apples : MonoBehaviour, IEatable, IInteractable, IInteractWithKey
{

    int HealthValueOfApple = 5;
    Player p;

    private void Awake()
    {
        p = FindObjectOfType<Player>().GetComponent<Player>();
    }
    public void AddHealth()
    {
        p.Health += HealthValueOfApple;
        UIManager.Instance.UpdateHealthAmount(p.Health);
    }

    public void InteractWithE()
    {
      
    }
    
    public void InteractItem()
    {
       
            AddHealth();
        
        
    }
    
} 
