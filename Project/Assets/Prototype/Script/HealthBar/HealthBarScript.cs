using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    private float currentHealth;
    public float CurrentHealth { get { { return this.currentHealth; } } set { this.currentHealth = value; } }

    private Image healthBarImage;

    private void Start()
    {
        healthBarImage = GetComponent<Image>();
        currentHealth = maxHealth;
    }

    private void Update()
    {
        healthBarImage.fillAmount = currentHealth / maxHealth;
    }
}
