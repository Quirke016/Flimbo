using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Slider healthSlider;
    public Slider staminaSlider;
    public Slider manaSlider;

    public void Maxstamina(float maxstamina)
    {
        staminaSlider.maxValue = maxstamina;
        staminaSlider.value = maxstamina;
    }
    public void Stamina(float stamina)
    {
         staminaSlider.value = stamina;
    }

    public void Maxmana(float maxmana)
    {
        manaSlider.maxValue = maxmana;
        manaSlider.value = maxmana;
    }
    public void Mana(float mana)
    {
        manaSlider.value = mana;
    }

    public void MaxHealth(float maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
    }
    public void Health(float health)
    {
        healthSlider.value = health;
    }

}
