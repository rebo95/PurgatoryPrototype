using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCode : MonoBehaviour
{
    [Header("Player One")]
    public GameObject PlayerOne;
    public PlayerAttack[] P1Combo1;
    public PlayerAttack[] P1Combo2;


    [Header("Player Two")]
    public GameObject PlayerTwo;
    public PlayerAttack[] P2Combo1;
    public PlayerAttack[] P2Combo2;

    


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        ////Populating Player 1 canvas with sprites from their equipped attacks.
        //GameObject.FindGameObjectWithTag("Player1System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.GetComponent<Image>().sprite = P1Combo1[0].AttackImage;
        //GameObject.FindGameObjectWithTag("Player1System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<Image>().sprite = P1Combo1[1].AttackImage;
        //GameObject.FindGameObjectWithTag("Player1System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.GetComponent<Image>().sprite = P1Combo2[0].AttackImage;
        //GameObject.FindGameObjectWithTag("Player1System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(1).transform.GetChild(1).transform.gameObject.GetComponent<Image>().sprite = P1Combo2[1].AttackImage;
        
        ////Populating Player 2 canvas with sprites from their equipped attacks.
        //GameObject.FindGameObjectWithTag("Player2System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.GetComponent<Image>().sprite = P2Combo1[0].AttackImage;
        //GameObject.FindGameObjectWithTag("Player2System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<Image>().sprite = P2Combo1[1].AttackImage;
        //GameObject.FindGameObjectWithTag("Player2System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.GetComponent<Image>().sprite = P2Combo2[0].AttackImage;
        //GameObject.FindGameObjectWithTag("Player2System").gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetChild(1).transform.GetChild(1).transform.gameObject.GetComponent<Image>().sprite = P2Combo2[1].AttackImage;
    }
}
