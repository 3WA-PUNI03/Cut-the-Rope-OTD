using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] float _speed;

    Vector2 _direction;

    private void Update()
    {
        
        transform.Translate(_direction * _speed * Time.deltaTime);

    }

    public void SetDirection(Vector2 dir)
    {
        _direction = dir;
    }

}
