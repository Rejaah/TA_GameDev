using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadLoop : MonoBehaviour
{
    public GameObject _road;
    private GameObject Road;
    // Update is called once per frame
    void Update()
    {
        if( _road.transform.position == new Vector3(-18.98585f,0f,0f))
        {
            spawbroad();
        }
    }

    private void spawbroad()
    {
        Vector3 coor = new Vector3(-18.98585f, 339f, 0);
        Road = Instantiate(_road, coor, Quaternion.identity);

        Destroy(Road);
    }
}
