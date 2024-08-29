using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropplerSpin : MonoBehaviour
{
    private readonly float _spinSpeed = 9000.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * _spinSpeed);
        
    }
}
