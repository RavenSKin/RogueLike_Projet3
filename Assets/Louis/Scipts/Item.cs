using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{

    public enum ItemType
    {
        Coins,
        HealthPotion,
        Arrows,
    }
    
    public ItemType _itemType;
    public int _amount;

}