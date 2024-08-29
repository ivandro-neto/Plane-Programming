using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //Getting the palyer from the Inspector
    public GameObject plane;

    //Setting a fixed position for the camara
    private readonly Vector3 _offset = new Vector3(30, 0, 10);

  
    void Update()
    {
        //Following the player along the z axis
        transform.position = plane.transform.position + _offset;
    }
}
