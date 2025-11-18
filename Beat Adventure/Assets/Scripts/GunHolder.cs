using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHolder : MonoBehaviour
{
    public GameObject[] weapons;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        EquipWeapon(currentIndex);
    }

    public void EquipWeapon(int index)
    {
        if (index < 0 || index >= weapons.Length) return;

        for (int i = 0; i < weapons.Length; i++)
            weapons[i].SetActive(i == index);

        currentIndex = index;
    }

    public void SwitchToNextWeapon()
    {
        int nextIndex = (currentIndex + 1) % weapons.Length;
        EquipWeapon(nextIndex);
    }

}
