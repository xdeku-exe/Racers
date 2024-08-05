using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 finalPosition;
    [SerializeField] private float _rotationSpeed;
    private Vector3 disabledPosition;

    private void Awake()
    {
        disabledPosition = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, finalPosition, 0.1f);
        transform.RotateAround(gameObject.transform.position, Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    private void OnDisable()
    {
        transform.position = disabledPosition;
    }
}
