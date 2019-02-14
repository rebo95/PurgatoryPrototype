using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuBehaviour : MonoBehaviour
{
    public GameObject AudioManagerObject;

    // Start is called before the first frame update
    void Start()
    {
        AudioManagerObject = GameObject.FindGameObjectWithTag("AudioManager");
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

    public void PlaySFX()
    {
        AudioManagerObject.GetComponent<AudioManager>().MenuClickSFX();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
