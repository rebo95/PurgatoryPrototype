using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCode : MonoBehaviour
{
    PlayerAttack attackMove;
    public PlayerManager PM;


    public void FireTheAttack(PlayerAttack atk)
    {
        StartCoroutine("ColliderOn", atk);
        attackMove = atk;

    }

    IEnumerator ColliderOn(PlayerAttack a)
    {

        yield return new WaitForSeconds(a.PointOfNoReturn);


        yield return new WaitForSeconds(a.EndOfTheAttack);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerManager>().player_Id != PM.player_Id)
            {
                other.GetComponent<PlayerManager>().takeDamage();
            }
        }

    }
}
