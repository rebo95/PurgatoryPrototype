using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource ButtonSFX;
    private AudioSource ArenaMusic;
    private AudioSource MenuMusic;

    public AudioClip LungeAttack;

    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        ButtonSFX = GameObject.FindGameObjectWithTag("AudioManager").gameObject.transform.GetChild(1).transform.GetChild(0).GetComponent<AudioSource>();
        ArenaMusic = GameObject.FindGameObjectWithTag("AudioManager").gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<AudioSource>();
        MenuMusic = GameObject.FindGameObjectWithTag("AudioManager").gameObject.transform.GetChild(0).transform.GetChild(1).GetComponent<AudioSource>();
        MenuMusic.Play();
    }

    public void MenuClickSFX()
    {
        ButtonSFX.pitch = Random.Range(0.7f, 0.9f);
        ButtonSFX.Play();
    }

    public void ArenaStart()
    {
        ArenaMusic.Play();
        MenuMusic.Stop();
    }

    //Attack-sounds

        //Lunge Attack
        public void LungeSFX()
    {
        gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<AudioSource>().PlayOneShot(LungeAttack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
