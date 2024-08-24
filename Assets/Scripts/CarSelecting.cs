using UnityEngine;
using UnityEngine.UI;

public class CarSelecting : MonoBehaviour
{
    [SerializeField] private Button _previousButton;
    [SerializeField] private Button _nextButton;
    private int currentCar;

    private void Start()
    {
        currentCar = DataManager.Instance.currentCar;
        SelectCar(currentCar);
    }

    public void ChangeCar(int index)
    {
        _previousButton.interactable = (index != 0);
        _nextButton.interactable = (index != transform.childCount - 1);
    }

    public void SelectCar(int change)
    {
        currentCar += change;
        DataManager.Instance.currentCar = currentCar;
        DataManager.Instance.Save();
        ChangeCar(currentCar);
    }
    
}
