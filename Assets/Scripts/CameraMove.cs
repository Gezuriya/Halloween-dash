using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{
    public GameObject Player;
    Vector3 Move;
    int i;
    private void Start()
    {
        i = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        Move = Player.transform.position + new Vector3(-2.5f, 2.6f, -11.55f);
        transform.position = Move;
    }

    public void STURTING() 
    {
        StartCoroutine(Retry());
    }
    IEnumerator Retry()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(i); 
    }
}
