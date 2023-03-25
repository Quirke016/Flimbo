using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public CharacterController controller;
    public Transform floorCheck;
    public float playerSpeed = 6f;
    public float gravity = -21f;
    public float jumpHeight = 1.2f;
    public float floorDistance = 0.2f;
    public float stamina;
    public float maxStamina = 100.0f;
    public float minStamina = 0.0f;
    public float sprintSpeed = 11.5f;
    public float critDmg = 1.5f;
    public float critChance = 0.5f;
    public float agility;
    public float intelligence;
    public float strength;
    public float timeToRegenEquals = 3f;
    public float staminaRegenTimer = 0.0f;
    public float regSpeed;
    public int additionalPoints = 11;
    public int jumps = 1;
    public float maxHealth = 100f;
    public float health = 100f;
    public int attackDmg;
    public int armour;
    public bool levellingUp;
    public bool sprinting = false;
    public bool hasStamina;
    bool isOnFloor;
    bool isReadyToJump;
    public const float staminaDecRate = 2.2f;
    public const float timeToRegen = 0.5f;
    public const float staminaIncRate = 5f;
    public KeyCode sprintKey = KeyCode.LeftShift;
    public LayerMask ground;
    Vector3 velocity;
    public PlayerUI healthBar;
    public PlayerUI staminaBar;
    public bool exhausted;
    public float CAI;


    private void Start()
    {
        regSpeed = playerSpeed;
        health = maxHealth;
        stamina = maxStamina;

        healthBar.MaxHealth(maxHealth);
        staminaBar.Maxstamina(maxStamina);
    }

    void Update()
    {
        if (stamina < minStamina)
        {
            playerSpeed = regSpeed;
        }

        isOnFloor = Physics.CheckSphere(floorCheck.position, floorDistance, ground);
        if (isOnFloor && velocity.y < 0)
        {
            velocity.y = -2f;
            isReadyToJump = true;
            jumps = 1;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * playerSpeed * Time.deltaTime);
        if (Input.GetKeyDown("space") && isOnFloor && isReadyToJump && jumps >= 1)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isReadyToJump = false;
            jumps = jumps - 1;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
        if (stamina <= minStamina)
        {
            exhausted = true;
        }

        if (stamina >= (maxStamina * 0.2f))
        {
            exhausted = false;
        }

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        if (isRunning && exhausted ==  false)
        {
            stamina = Mathf.Clamp(stamina - (staminaDecRate * Time.deltaTime), 0.0f, maxStamina);
            staminaRegenTimer = 0.0f;
            playerSpeed = sprintSpeed;
            staminaBar.Stamina(stamina);
        }
        else if (stamina < maxStamina)
        {
            if (staminaRegenTimer >= timeToRegenEquals)
            {
                stamina = Mathf.Clamp(stamina + (staminaIncRate * Time.deltaTime), 0.0f, maxStamina);
            }
            
            else
            {
                staminaRegenTimer += Time.deltaTime;
                playerSpeed = regSpeed;
            }
            staminaBar.Stamina(stamina);
        }

        if (Input.GetKeyDown("k"))
        {
            TakeDevDamage();
        }
    }
    public void TakeDevDamage()
    {
        TakeDamage(Random.Range(0.1f, 10f));
    }
    public void haveingStamina()
    {
        if (stamina == minStamina)
        {
            hasStamina = false;
        }

        if (stamina > minStamina)
        {
            hasStamina = true;
        }
    }
    public void TakeDamage(float amount)
    {
        health -= amount - (amount * armour / 100);

        if (health <= 0)
        {
            SceneManager.LoadScene("deathScreenTemp");
        }

        healthBar.Health(health);
    }
    private void Sprint()
    {
        if (Input.GetKey(sprintKey))
        {
            sprinting = true;
        }

        else if (!Input.GetKey(sprintKey))
        {
            sprinting = false;
            playerSpeed = regSpeed;
        }
    }
}
