using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReset : MonoBehaviour
{
    public GameObject Level0;
    void Start()
    {
        StartCoroutine(Level30Cont());
    }
    IEnumerator Level30Cont()
    {
        yield return new WaitForSeconds(80f);
        Level0.SetActive(false);
    }
}
