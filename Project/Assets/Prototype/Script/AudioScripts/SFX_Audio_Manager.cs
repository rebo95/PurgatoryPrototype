using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Audio_Manager : MonoBehaviour
{

    public AudioSource warrior1;
    public AudioSource warrior2;

    // Start is called before the first frame update
    void Start()
    {
        playWarrior1Audio();
        Invoke("playWarrior2Audio", warrior1.clip.length + 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playWarrior1Audio()
    {
        warrior1.Play();
    }

    void playWarrior2Audio()
    {
        warrior2.Play();
    }
}
