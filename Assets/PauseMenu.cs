using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    private bool pause = false;
    public GameObject Panelpause;
    public GameObject music;
    public GameObject video;
    //private PlayerMovement playerScript;

    void Start()
    {
       // playerScript = GameObject.FindGameObjectwithTag("Player").GetComponent<FirstPersonMovement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }
        if (pause)
        {
            Time.timeScale = 0;
            //playerScript.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Panelpause.SetActive(true);
            music.SetActive(false);
            video.SetActive(false);
        }
        else if (!pause)
        {
            Time.timeScale = 1;
            //playerScript.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Panelpause.SetActive(false);
            music.SetActive(true);
            video.SetActive(true);
        }
       
    }

    public void MenuP()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void ApplicationPause()
    {
        pause = !pause;
    }
}
