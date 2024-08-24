using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopItem", menuName = "Shop/ShopItem")]
public class ShopItem : ScriptableObject
{
    [field: SerializeField] public Cars carType { get; private set; }
    [field: SerializeField] public GameObject Model { get; private set; }
    [field: SerializeField, Range(0, 200000)] public int Price { get; private set; } 
}
