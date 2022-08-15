using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelControllerMainMen : MonoBehaviour
{
    public SnapScrolling Snap;
    int i;
    public GameObject SnapScr;
    void Update()
    {
        i = Snap.selectedPanID;
    }
    public void OnStartClick()
    {
        if (i == 0)
        {
            //SnapScr.SetActive(false);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        if (i == 1)
        {
              //  SnapScr.SetActive(false);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        if (i == 2)
        {
          //  SnapScr.SetActive(false);
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        if (i == 3)
        {
              //  SnapScr.SetActive(false);
            SceneManager.LoadScene(4, LoadSceneMode.Single);
        }
        if (i == 4)
        {
         //   SnapScr.SetActive(false);
            SceneManager.LoadScene(5, LoadSceneMode.Single);
        }
    }
}
