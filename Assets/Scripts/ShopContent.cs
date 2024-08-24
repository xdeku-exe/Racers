using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopContent", menuName = "Shop/ShopContent")]
public class ShopContent : ScriptableObject
{
    [SerializeField] private List<ShopItem> _cars;
    public IEnumerable<ShopItem> Items => _cars;

    // Вызывается при изменении скрипта (только в инспекторе)
    private void OnValidate()
    {
        var carItemDuplicates = _cars.GroupBy(item => item.carType).Where(array => array.Count() > 1);
        if (carItemDuplicates.Count() > 1) throw new InvalidOperationException(nameof(_cars));
    }

}
