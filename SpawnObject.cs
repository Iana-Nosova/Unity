using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var g01 = Instantiate(Cube, Position.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
