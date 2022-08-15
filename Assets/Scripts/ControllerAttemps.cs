using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControllerAttemps : MonoBehaviour
{
    public TextMeshPro Temp;
    public PlayerControl PlayerControl;
    int i, j;
    void Start()
    {
        i = SceneManager.GetActiveScene().buildIndex;
        if (i == 1)
        {
            j = PlayerControl.CountAtt1;
        }
        if (i == 2)
        {
            j = PlayerControl.CountAtt2;
        }
        if (i == 3)
        {
            j = PlayerControl.CountAtt3;
        }
        if (i == 4)
        {
            j = PlayerControl.CountAtt4;
        }
        if (i == 5)
        {
            j = PlayerControl.CountAtt5;
        }
        Temp.GetComponent<TextMeshPro>();
        Temp.text = "Attempt " + j.ToString();
    }
}
