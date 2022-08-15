using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    int MusicOnOffer;
    public Sprite musicOff, musicOn;

    private void Awake()
    {
         MusicOnOffer = PlayerPrefs.GetInt("Music");
        if (MusicOnOffer == 1)
        {
            GetComponent<Image>().sprite = musicOff;
        }
        else
        {
            GetComponent<Image>().sprite = musicOn;
        }
    }
    void Update()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            MusicOnOffer = PlayerPrefs.GetInt("Music");
        }
        else
        {
            MusicOnOffer = 0;
            GetComponent<Image>().sprite = musicOn;
        }
        if (MusicOnOffer == 1)
        {
            GetComponent<Image>().sprite = musicOff;
        }
    }
    public void ClickOnButt()
    {
        if (MusicOnOffer == 0)
        {
            VIKL();
        }
        if (MusicOnOffer == 1)
        {
            VKL();
        }
    }
    public void VKL()
    {
        GetComponent<Image>().sprite = musicOn;
        PlayerPrefs.SetInt("Music", 0);
    }
    public void VIKL()
    {
        GetComponent<Image>().sprite = musicOff;
        PlayerPrefs.SetInt("Music", 1);
    }
}
