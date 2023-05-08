using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward = 25;
    [SerializeField] int goldPenalty = 25;

    CurrencySystem currencySystem;


    private void Start()
    {
        currencySystem = FindObjectOfType<CurrencySystem>();
    }

    public void RewarddGold()
    {
        if(currencySystem == null) { return; }
        currencySystem.Deposit(goldReward);
    }

    public void StealGold()
    {
        if (currencySystem == null) { return; }
        currencySystem.WithDraw(goldPenalty);
    }
}
