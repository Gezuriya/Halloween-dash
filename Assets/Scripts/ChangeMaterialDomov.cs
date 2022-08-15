using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialDomov : MonoBehaviour
{

    public Material Mat1, Mat2, Mat3;
    int Rand;
    void Start()
    {
        Rand = Random.Range(0, 3);
        if(Rand == 0)
        {
            gameObject.GetComponent<MeshRenderer>().material = Mat1;
        }
        if(Rand == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = Mat2;
        }
        if (Rand == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material = Mat3;
        }
    }
}
