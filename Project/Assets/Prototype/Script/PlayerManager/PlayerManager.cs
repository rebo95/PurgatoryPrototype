using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float maxHealth;
    float currentHealth;
    public Image healthBarImage;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage()
    {
        currentHealth -= 10;

        if (currentHealth >= 0)
            healthBarImage.fillAmount = currentHealth / maxHealth;
    }
}
