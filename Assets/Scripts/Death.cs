using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public PlayerManager player;
    public GameObject deathUi;
    bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        if (player.health <= 0f)
        {
            isDead = true;
        }

        if (isDead)
        {
            deathUi.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Ded();
        }
    }

    void Ded()
    {
        Debug.Log("Yo dead fool!");
        player.playerSpeed = 0f;
        player.stamina = 0f;
        player.sprintSpeed = 0f;
        player.jumpHeight = 0f;
    }
}
