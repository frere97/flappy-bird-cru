using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float Score;
    public bool PlayerVivo = true;
    public GameObject GameMenu;
    public Text ScoreTXT;
    
    // Start is called before the first frame update
    void Awake()
    {
        
        Instance = this;
        GameMenu.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerVivo) { 
        Time.timeScale += .0001f;
            ScoreTXT.text = "" + Score;
        }

    }

    public void KillPlayer()
    {
        Time.timeScale = 0;
        PlayerVivo = false;
        GameMenu.SetActive(true);
    }

    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
