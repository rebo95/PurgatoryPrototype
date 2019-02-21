using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public Image healthBarImage;
    public int player_Id;


    public Text EndRoundText;
    public Button ReturnToMenuButton;


    //VARS
    PlayerMovement PMovement;
    private void Start()
    {
        PMovement = GetComponent<PlayerMovement>();
        currentHealth = maxHealth;
    }

    public void takeDamage(float Damage)
    {
        print(Damage.ToString());
        currentHealth -= Damage;
        PMovement.ComboIndex = 0;

        healthBarImage.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
            EndText();

        
    }


    void EndText()
    {
        if (player_Id == 1)
            EndRoundText.text = "Player 2 wins";
        else
            EndRoundText.text = "Player 1 wins";

        ShowReturnMenuButton();

    }

    void ShowReturnMenuButton()
    {
        ReturnToMenuButton.gameObject.SetActive(true);
    }
}
