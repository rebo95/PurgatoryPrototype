using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCode : MonoBehaviour
{
    PlayerAttack attackMove;
    public PlayerManager PManager;
    public PlayerMovement PMovement;
    public Collider col;
    
    public void FireTheAttack(PlayerAttack atk)
    {
        StartCoroutine("ColliderOn", atk);
        attackMove = atk;

    }

    IEnumerator ColliderOn(PlayerAttack a)
    {

        yield return new WaitForSeconds(a.PointOfNoReturn);
        col.enabled = true;

        yield return new WaitForSeconds(a.EndOfTheAttack);
        col.enabled = false;

        PMovement.CurState = PlayerMovement.PlayerState.Walking;
        PMovement.CC.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {


            if (other.GetComponent<PlayerManager>().player_Id != PManager.player_Id)
            {
                col.enabled = false;
                other.GetComponent<PlayerManager>().takeDamage(attackMove.Damage);
            }
        }
    }
}
