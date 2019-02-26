using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum PlayerState
    {
        Walking, Attacking, stunn, Oofing
    }
    public PlayerState CurState;
    //Refence
    GameCode GC;
    Animator anim;
    public CameraController CC;
    public WeaponCode weapon;
    //MOVEMENT STATE
    public float WSpeed = 3;
    //ATTACK STATE
    public int ComboIndex = 0;
    PlayerAttack[] C1;
    PlayerAttack[] C2;
    //COMBO TIME
    float ResetTime = 0.5f;
    float curTime;


    public int Player_Id = 1;
    public char inputController = 'K';



    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetChild(0).GetComponent<Animator>();
        GC = GameObject.FindGameObjectWithTag("GM").GetComponent<GameCode>();
        updateAttacks();
    }

    public void updateAttacks()
    {
        C1 = GC.P1Combo1;
        C2 = GC.P1Combo2;
    }

    // Update is called once per frame
    void Update()
    {

        switch (CurState)
        {
            case PlayerState.Walking:
                float h = Input.GetAxis("Horizontal_P" + Player_Id + inputController) * WSpeed * Time.deltaTime;
                float v = Input.GetAxis("Vertical_P" + Player_Id + inputController) * WSpeed * Time.deltaTime;
                transform.localPosition += transform.right * h;
                transform.localPosition += transform.forward * v;

                if (h == 0 && v == 0)
                {
                    anim.SetBool("Walking",false);
                }
                else
                {
                    anim.SetBool("Walking", true);

                }

                if (Input.GetButtonDown("Fire1" + inputController))
                {
                    attackStart(1);
                    anim.SetBool("Walking", false);

                }
                else if (Input.GetButtonDown("Fire2" + inputController))
                {
                    attackStart(2);
                    anim.SetBool("Walking", false);

                }
                // COMBO TIMER
                if (ComboIndex != 0)
                {
                    curTime -= Time.deltaTime;
                    if (curTime <= 0)
                    {
                        ComboIndex = 0;
                    }
                }
  

                break;
            case PlayerState.Attacking:
                break;
            case PlayerState.stunn:
                break;
            case PlayerState.Oofing:
                break;
            default:
                break;
        }

    }
    void attackStart(int comboNr)
    {

        curTime = ResetTime;
        CC.enabled = false;
        CurState = PlayerState.Attacking;

        PlayerAttack curAttack;
        if (comboNr == 1)
        {
            if (ComboIndex >= C1.Length)
            {
                ComboIndex = 0;
            }
            curAttack = C1[ComboIndex];
        }
        else
        {
            if (ComboIndex >= C2.Length)
            {
                ComboIndex = 0;
            }
            curAttack = C2[ComboIndex];
        }
        anim.SetTrigger(curAttack.AnimationKey);




        //curAttack.Damage = curAttack.Damage * (((ComboIndex + 1)) + 1); // COMBO REWARD

        weapon.FireTheAttack(curAttack);


        ComboIndex++;
    }
}
