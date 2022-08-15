using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject PanPause;
    int i;
    public GameObject PanYesNo;
    public GameObject LevelChanger, PlaySpr;

    private void Start()
    {
        i = SceneManager.GetActiveScene().buildIndex;
    }
    public void PauseButt()
    {
        PanPause.SetActive(true);
        Time.timeScale = 0;
    }
    public void GoHomeButt()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        Time.timeScale = 2;
        PanPause.SetActive(false);
    }
    public void RestartButt()
    {
        SceneManager.LoadScene(i);
    }
    public void OnExitButt()
    {
        PanYesNo.SetActive(true);
    }
    public void Yes()
    {
        Application.Quit();
    }
    public void No()
    {
        PanYesNo.SetActive(false);
    }

    public void LevelChoose()
    {
        LevelChanger.SetActive(true);
        PlaySpr.SetActive(false);
    }
    public void BackOnScroll()
    {
        PlaySpr.SetActive(true);
        LevelChanger.SetActive(false);
    }
}
