using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _carModels;

    private void Awake()
    {
        LoadCar(DataManager.Instance.currentCar);
    }

    private void LoadCar(int index)
    {
        Instantiate(_carModels[index], transform.position, Quaternion.identity);
    }
}
