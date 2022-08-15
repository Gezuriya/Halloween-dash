using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReset2 : MonoBehaviour
{
    public GameObject Level0;
    void Start()
    {
        StartCoroutine(Level30Cont());
        StartCoroutine(Level3060Cont());
        StartCoroutine(Level60Cont());
    }
    IEnumerator Level30Cont()
    {
        yield return new WaitForSeconds(80f);
        Level0.SetActive(false);
    }
    public GameObject Level30, Level60;

    IEnumerator Level3060Cont()
    {
        yield return new WaitForSeconds(40f);
        Level30.SetActive(true);
    }
    IEnumerator Level60Cont()
    {
        yield return new WaitForSeconds(100f);
        Level60.SetActive(true);
    }
}
