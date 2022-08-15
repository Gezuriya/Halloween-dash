using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLevel : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        transform.Translate(-speed, 0, 0);
    }
}  
