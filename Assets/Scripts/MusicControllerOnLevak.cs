using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControllerOnLevak : MonoBehaviour
{
    int MusicNum;
    public GameObject MusicCont;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            MusicNum = PlayerPrefs.GetInt("Music");
        }
        else
        MusicNum = 0;

        if(MusicNum == 0)
        {
            MusicCont.SetActive(true);
        }
        if(MusicNum == 1)
        {
            MusicCont.SetActive(false);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            MusicNum = PlayerPrefs.GetInt("Music");
        }
        if (MusicNum == 0)
        {
            MusicCont.SetActive(true);
        }
        if (MusicNum == 1)
        {
            MusicCont.SetActive(false);
        }
    }
}
