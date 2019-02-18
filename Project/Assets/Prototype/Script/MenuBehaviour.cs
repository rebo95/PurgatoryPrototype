﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuBehaviour : MonoBehaviour
{
    public GameObject AudioManagerObject;
    private GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        AudioManagerObject = GameObject.FindGameObjectWithTag("AudioManager");
        
        if(GameObject.FindGameObjectWithTag("Menu_Pause").gameObject != null)
        {
            PauseMenu = GameObject.FindGameObjectWithTag("Menu_Pause").gameObject;
            PauseMenu.SetActive(false);
        }
    
    }
    
    //Button functions
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NextScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToArena()
    {
        SceneManager.LoadScene(3);
        AudioManagerObject.GetComponent<AudioManager>().ArenaStart();
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlaySFX()
    {
        AudioManagerObject.GetComponent<AudioManager>().MenuClickSFX();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
        }
    }
}
