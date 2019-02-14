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
    //MOVEMENT STATE
    public float WSpeed = 3;
    //ATTACK STATE
    public int ComboIndex = 0;
    PlayerAttack[] C1;
    PlayerAttack[] C2;


    // Start is called before the first frame update
    void Start()
    {
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
                float h = Input.GetAxis("Horizontal") * WSpeed * Time.deltaTime;
                float v = Input.GetAxis("Vertical") * WSpeed * Time.deltaTime;
                transform.localPosition += transform.right * h;
                transform.localPosition += transform.forward * v;

                if (Input.GetButtonDown("Fire1"))
                {
                    attackStart(1);
                }
                else if (Input.GetButtonDown("Fire2"))
                {
                    attackStart(2);
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
        if (ComboIndex >= 5)
        {
            ComboIndex = 0;
        }

        PlayerAttack curAttack;
        if (comboNr == 1)
        {
            curAttack = C1[ComboIndex];
        }
        else
        {
            curAttack = C2[ComboIndex];
        }
        print(curAttack.Name);
        ComboIndex++;
    }
}
