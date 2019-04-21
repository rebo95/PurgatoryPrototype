using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Scene_SFX_Audio_Manager : MonoBehaviour
{
    public AudioSource aaron1;
    public AudioSource aaron2;
    public AudioSource aaron3;
    public AudioSource aaron4;
    public AudioSource aaron5;
    public AudioSource aaron6;
    public AudioSource aaron7;
    public AudioSource aaron8;
    public AudioSource aaron9;
    public AudioSource aaron10;


    public AudioSource pablo1;
    public AudioSource pablo2;
    public AudioSource pablo3;
    public AudioSource pablo4;
    public AudioSource pablo5;
    public AudioSource pablo6;
    public AudioSource pablo7;
    public AudioSource pablo8;
    public AudioSource pablo9;

    // Start is called before the first frame update
    void Start()
    {
        playAaronAudio1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playAaronAudio1()
    {
        aaron1.Play();
        Invoke("playPabloAudio1", aaron1.clip.length + 0.05f);
    }

    void playAaronAudio2()
    {
        aaron2.Play();
        Invoke("playPabloAudio2", aaron2.clip.length + 0.05f);
    }

    void playAaronAudio3()
    {
        aaron3.Play();
        Invoke("playPabloAudio3", aaron3.clip.length + 0.05f);
    }

    void playAaronAudio4()
    {
        aaron4.Play();
        Invoke("playPabloAudio4", aaron4.clip.length + 0.05f);
    }

    void playAaronAudio5()
    {
        aaron5.Play();
        Invoke("playPabloAudio5", aaron5.clip.length + 0.05f);
    }

    void playAaronAudio6()
    {
        aaron6.Play();
        Invoke("playPabloAudio6", aaron6.clip.length + 0.05f);
    }

    void playAaronAudio7()
    {
        aaron7.Play();
        Invoke("playPabloAudio7", aaron7.clip.length + 0.05f);
    }

    void playAaronAudio8()
    {
        aaron8.Play();
        Invoke("playPabloAudio8", aaron8.clip.length + 0.05f);
    }

    void playAaronAudio9()
    {
        aaron9.Play();
        Invoke("playPabloAudio9", aaron9.clip.length + 0.05f);
    }

    void playAaronAudio10()
    {
        aaron10.Play();
    }



    void playPabloAudio1()
    {
        pablo1.Play();
        Invoke("playAaronAudio2", pablo1.clip.length + 0.05f);
    }

    void playPabloAudio2()
    {
        pablo2.Play();
        Invoke("playAaronAudio3", pablo2.clip.length + 0.05f);
    }

    void playPabloAudio3()
    {
        pablo3.Play();
        Invoke("playAaronAudio4", pablo3.clip.length + 0.05f);
    }

    void playPabloAudio4()
    {
        pablo4.Play();
        Invoke("playAaronAudio5", pablo4.clip.length + 0.05f);
    }

    void playPabloAudio5()
    {
        pablo5.Play();
        Invoke("playAaronAudio6", pablo5.clip.length + 0.05f);
    }

    void playPabloAudio6()
    {
        pablo6.Play();
        Invoke("playAaronAudio7", pablo6.clip.length + 0.05f);
    }

    void playPabloAudio7()
    {
        pablo7.Play();
        Invoke("playAaronAudio8", pablo7.clip.length + 0.05f);
    }

    void playPabloAudio8()
    {
        pablo8.Play();
        Invoke("playAaronAudio9", pablo8.clip.length + 0.05f);
    }

    void playPabloAudio9()
    {
        pablo9.Play();
        Invoke("playAaronAudio10", pablo9.clip.length + 0.05f);
    }
}
