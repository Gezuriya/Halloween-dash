using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    public float ForceJump = 10f;

    public static int CountAtt1, CountAtt2, CountAtt3, CountAtt4, CountAtt5;
    [SerializeField]
    private float fallMult = 2.5f;

    [SerializeField]
    private float lowJumpMult = 2f;

    int Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10;
    public int i;
    public int ki;
    Rigidbody Rigid;
    private bool DoJump = false;
    private bool IsJumping = false;
    public CameraMove CamMove;

    public GameObject Part, Player, PanelFinish;

    private void Awake()
    {
        Rigid = gameObject.GetComponent<Rigidbody>();
    }
    private void Start()
    {
       /* if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4426841", false);
        }*/
        if (PlayerPrefs.HasKey("Reklama"))
        {
            ki = PlayerPrefs.GetInt("Reklama");
        }
        else
        {
            ki = 0;
        }

        Time.timeScale = 2;
        i = SceneManager.GetActiveScene().buildIndex;
        if (PlayerPrefs.HasKey("Level1"))
        {
            Level1 = PlayerPrefs.GetInt("Level1");
        }
        else
        {
            Level1 = 0;
        }

        if (PlayerPrefs.HasKey("Level2"))
        {
            Level2 = PlayerPrefs.GetInt("Level2");
        }
        else
        {
            Level2 = 0;
        }

        if (PlayerPrefs.HasKey("Level3"))
        {
            Level3 = PlayerPrefs.GetInt("Level3");
        }
        else
        {
            Level3 = 0;
        }

        if (PlayerPrefs.HasKey("Level4"))
        {
            Level4 = PlayerPrefs.GetInt("Level4");
        }
        else
        {
            Level4 = 0;
        }

        if (PlayerPrefs.HasKey("Level5"))
        {
            Level5 = PlayerPrefs.GetInt("Level5");
        }
        else
        {
            Level5 = 0;
        }

        if (PlayerPrefs.HasKey("Level6"))
        {
            Level6 = PlayerPrefs.GetInt("Level6");
        }
        else
        {
            Level6 = 0;
        }

        if (PlayerPrefs.HasKey("Level7"))
        {
            Level7 = PlayerPrefs.GetInt("Level7");
        }
        else
        {
            Level7 = 0;
        }

        if (PlayerPrefs.HasKey("Level8"))
        {
            Level8 = PlayerPrefs.GetInt("Level8");
        }
        else
        {
            Level8 = 0;
        }

        if (PlayerPrefs.HasKey("Level9"))
        {
            Level9 = PlayerPrefs.GetInt("Level9");
        }
        else
        {
            Level9 = 0;
        }

        if (PlayerPrefs.HasKey("Level10"))
        {
            Level10 = PlayerPrefs.GetInt("Level10");
        }
        else
        {
            Level10 = 0;
        }
    }
    void Update()
    {
        if(Input.GetMouseButton(0) && !IsJumping)
        { 
            DoJump = true;
            IsJumping = true;
        }
        if (PlayerPrefs.HasKey("Reklama"))
        {
            ki = PlayerPrefs.GetInt("Reklama");
        }
        if (ki == 13)
        {
            PlayReklama();
        }
    }
    private void FixedUpdate()
    {
        if (DoJump)
        {
            Rigid.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
            DoJump = false;
        }
        if(Rigid.velocity.y < 0)
        {
            Rigid.velocity += Vector3.up * Physics.gravity.y * (fallMult - 1) * Time.deltaTime;
        }
        else if(Rigid.velocity.y > 0 && !IsJumping)
        {
            Rigid.velocity += Vector3.up * Physics.gravity.y * (lowJumpMult - 1) * Time.deltaTime;
        }
        transform.rotation *= Quaternion.Euler(0, 1f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            IsJumping = false;
        }
        if(collision.collider.tag == "Finish")
        {
            if (i == 1 && Level1 < 100)
            {
                PlayerPrefs.SetInt("Level1", 100);
            }
            if (i == 2 && Level2 < 100)
            {
                PlayerPrefs.SetInt("Level2", 100);
            }
            if (i == 3 && Level3 < 100)
            {
                PlayerPrefs.SetInt("Level3", 100);
            }
            if (i == 4 && Level4 < 100)
            {
                PlayerPrefs.SetInt("Level4", 100);
            }
            if (i == 5 && Level5 < 100)
            {
                PlayerPrefs.SetInt("Level5", 100);
            }
            if (i == 6 && Level6 < 100)
            {
                PlayerPrefs.SetInt("Level6", 100);
            }
            if (i == 7 && Level7 < 100)
            {
                PlayerPrefs.SetInt("Level7", 100);
            }
            if (i == 8 && Level8 < 100)
            {
                PlayerPrefs.SetInt("Level8", 100);
            }
            if (i == 9 && Level9 < 100)
            {
                PlayerPrefs.SetInt("Level9", 100);
            }
            if (i == 10 && Level10 < 100)
            {
                PlayerPrefs.SetInt("Level10", 100);
            }
            StartCoroutine(LevelIsPassed());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            ki++;
            ShowAd();
            PlayerPrefs.SetInt("Reklama", ki);
            Part.SetActive(true);
            Player.SetActive(false);
            Time.timeScale = 0;
            if(i == 1)
            {
                CountAtt1++;
            }
            if (i == 2)
            {
                CountAtt2++;
            }
            if (i == 3)
            {
                CountAtt3++;
            }
            if (i == 4)
            {
                CountAtt4++;
            }
            if (i == 5)
            {
                CountAtt5++;
            }
            CamMove.STURTING();
        }

        if(other.gameObject.tag == "30%")
        {
            if(i == 1 && Level1 <30)
            {
                PlayerPrefs.SetInt("Level1", 30);
            }
            if (i == 2 && Level2 < 30)
            {
                PlayerPrefs.SetInt("Level2", 30);
            }
            if (i == 3 && Level3 < 30)
            {
                PlayerPrefs.SetInt("Level3", 30);
            }
            if (i == 4 && Level4 < 30)
            {
                PlayerPrefs.SetInt("Level4", 30);
            }
            if (i == 5 && Level5 < 30)
            {
                PlayerPrefs.SetInt("Level5", 30);
            }
            if (i == 6 && Level6 < 30)
            {
                PlayerPrefs.SetInt("Level6", 30);
            }
            if (i == 7 && Level7 < 30)
            {
                PlayerPrefs.SetInt("Level7", 30);
            }
            if (i == 8 && Level8 < 30)
            {
                PlayerPrefs.SetInt("Level8", 30);
            }
            if (i == 9 && Level9 < 30)
            {
                PlayerPrefs.SetInt("Level9", 30);
            }
            if (i == 10 && Level10 < 30)
            {
                PlayerPrefs.SetInt("Level10", 30);
            }
        }

        if (other.gameObject.tag == "60%")
        {
            if (i == 1 && Level1 < 60)
            {
                PlayerPrefs.SetInt("Level1", 60);
            }
            if (i == 2 && Level2 < 60)
            {
                PlayerPrefs.SetInt("Level2", 60);
            }
            if (i == 3 && Level3 < 60)
            {
                PlayerPrefs.SetInt("Level3", 60);
            }
            if (i == 4 && Level4 < 60)
            {
                PlayerPrefs.SetInt("Level4", 60);
            }
            if (i == 5 && Level5 < 60)
            {
                PlayerPrefs.SetInt("Level5", 60);
            }
            if (i == 6 && Level6 < 60)
            {
                PlayerPrefs.SetInt("Level6", 60);
            }
            if (i == 7 && Level7 < 60)
            {
                PlayerPrefs.SetInt("Level7", 60);
            }
            if (i == 8 && Level8 < 60)
            {
                PlayerPrefs.SetInt("Level8", 60);
            }
            if (i == 9 && Level9 < 60)
            {
                PlayerPrefs.SetInt("Level9", 60);
            }
            if (i == 10 && Level10 < 60)
            {
                PlayerPrefs.SetInt("Level10", 60);
            }
        }
    }
    void PlayReklama()
    {
        if (Advertisement.IsReady())
        {
           // Advertisement.Show("Interstitial_Android");
            //PlayerPrefs.SetInt("Reklama", 0);
        }
    }
    public void ShowAd()
    {
        Application.ExternalCall("ShowAd");
    }
    IEnumerator LevelIsPassed()
    {
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 0;
        ShowAd();
        PanelFinish.SetActive(true);
    }
}
