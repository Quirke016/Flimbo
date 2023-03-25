using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;
    int keeps;
    // Start is called before the first frame update
    void Start()
    {
        selectWeapon();
        keeps = selectedWeapon;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            selectedWeapon = 0;
        }

        if (Input.GetKeyDown("2"))
        {
            selectedWeapon = 1;
        }

        if (Input.GetKeyDown("3"))
        {
            selectedWeapon = 2;
        }

        if (selectedWeapon != keeps || keeps != selectedWeapon)
        {
            selectWeapon();
            selectWeapon();
            keeps = selectedWeapon;
        }
    }

    void selectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
