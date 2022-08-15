using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotation : MonoBehaviour
{   
    public int Rand;
    private void Start()
    {
        Rand = Random.Range(0, 2);
    }
    void Update()
    {
       if(Time.timeScale >= 1)
        {
            if(Rand == 0)
            {
                transform.rotation *= Quaternion.Euler(0, 0, 1);
            }
            else
            {
                transform.rotation *= Quaternion.Euler(0, 0, -1);
            }
        } 
    }
}
