using UnityEngine;
using UnityEngine.UI;

public class ShopItemView : MonoBehaviour
{
    [SerializeField] private Image _lockImage;
    [SerializeField] private Button _buyItemButton;
    public ShopItem Item { get; private set; }
    public bool isLock { get; private set; }
    public int CarPrice => Item.Price;
    public GameObject CarModel => Item.Model;

    public void Initialize(ShopItem item)
    {
        Item = item;
        _buyItemButton.GetComponent<Text>().text = CarPrice.ToString();
    }

    public void Lock()
    {
        isLock = true;
        _lockImage.gameObject.SetActive(isLock);
        _buyItemButton.gameObject.SetActive(isLock);
        _buyItemButton.GetComponent<Text>().text = CarPrice.ToString();
    }

    public void Unlock() 
    {
        isLock = false;
        _lockImage.gameObject.SetActive(isLock);
        _buyItemButton.gameObject.SetActive(isLock);
    }
}
