using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_PlayerFeedback : MonoBehaviour
{

    public AudioClip LungeAttack;
    public AudioClip SloppyStab;
    public AudioClip FerventAnger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Attack-sounds

    //Lunge Attack
    public void LungeSFX()
    {
        gameObject.transform.GetChild(3).transform.GetChild(0).GetComponent<AudioSource>().PlayOneShot(LungeAttack);
    }
    // Sloppy Stab
    public void SloppySFX()
    {
        gameObject.transform.GetChild(3).transform.GetChild(0).GetComponent<AudioSource>().PlayOneShot(SloppyStab);
    }

    // Fervent Anger
    public void FerventSFX()
    {
        gameObject.transform.GetChild(3).transform.GetChild(0).GetComponent<AudioSource>().PlayOneShot(FerventAnger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
