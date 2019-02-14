using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
