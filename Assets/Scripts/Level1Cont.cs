using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Cont : MonoBehaviour
{
    int Level1;
    public Text LevelTxt, LevelTxt2;
    void Start()
    {
        if (PlayerPrefs.HasKey("Level1"))
        {
            Level1 = PlayerPrefs.GetInt("Level1");
        }
        else
        {
            Level1 = 0;
        }
        
        if(Level1 == 0)
        {
            LevelTxt.text = "Complited < 30%";
            LevelTxt2.text = "Complited < 30%";
        }
        if (Level1 == 30)
        {
            LevelTxt.text = "Complited > 30%";
            LevelTxt2.text = "Complited > 30%";
        }
        if (Level1 == 60)
        {
            LevelTxt.text = "Complited > 60%";
            LevelTxt2.text = "Complited > 60%";
        }
        if (Level1 == 100)
        {
            LevelTxt.text = "Level complited";
            LevelTxt2.text = "Level complited";
        }
    }
}
