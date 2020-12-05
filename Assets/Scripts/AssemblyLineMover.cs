using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyLineMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void Start()
    {
        _speed = 1.0f;
        _direction = Vector3.right;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out CubeMover cubeMover))
        {
            cubeMover.SetMoverParamentr(_speed, _direction);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out CubeMover cubeMover))
        {
            cubeMover.SetMoverParamentr(0, Vector3.zero);
        }
    }

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }
}
