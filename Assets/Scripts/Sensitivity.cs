using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensitivity : MonoBehaviour
{
    public PlayerLook player;
    Slider sensSlider;
    public void Sens(float sensitivity)
    {
        player.playerSensitivity = sensitivity;
    }
}
