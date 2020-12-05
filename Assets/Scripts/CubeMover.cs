using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void Start()
    {
        _speed = 0;
        _direction = Vector3.zero;
    }

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }

    public void SetMoverParamentr(float speed, Vector3 direction)
    {
        _speed = speed;
        _direction = direction;
    }
}
