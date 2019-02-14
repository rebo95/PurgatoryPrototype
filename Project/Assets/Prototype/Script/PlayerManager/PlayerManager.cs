using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float maxHealth;
    float currentHealth;
    public Image healthBarImage;
    public int player_Id;


    public Text EndRoundText;
    public Button ReturnToMenuButton;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage()
    {
        currentHealth -= 10;

        healthBarImage.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
            EndText();

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Weapon")
        {
            takeDamage();
        }
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
