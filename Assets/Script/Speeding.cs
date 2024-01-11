using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeding : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed = 0.65f;

    private void Update()
    {
        transform.position += Vector3.down * _speed * Time.deltaTime;
    }
}
