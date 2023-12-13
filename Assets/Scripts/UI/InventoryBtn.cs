using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBtn : MonoBehaviour
{
    public GameObject newbow_unequipped;
    public GameObject dagger_unequipped;
    public GameObject shield_unequipped;
    public GameObject armor_unequipped;

    public GameObject newbow_equipped;
    public GameObject dagger_equipped;
    public GameObject shield_equipped;
    public GameObject armor_equipped;

    public GameObject equip_newbow;
    public GameObject equip_dagger;
    public GameObject equip_shield;
    public GameObject equip_armor;

    // Start is called before the first frame update
    void Start()
    {
        equip_newbow.SetActive(false);
        equip_dagger.SetActive(false);
        equip_shield.SetActive(false);
        equip_armor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickNewbow()
    {
        if (equip_newbow.activeSelf == false)
        {
            newbow_unequipped.SetActive(true);
        }
        else
        {
            newbow_equipped.SetActive(true);
        }
    }

    public void OnClickEquip_NewBow()
    {
        equip_newbow.SetActive(true);
        newbow_unequipped.SetActive(false); 
    }

    public void OnClickUnequip_NewBow()
    {
        equip_newbow.SetActive(false);
        newbow_equipped.SetActive(false);
    }


    public void OnClickDagger()
    {
        if (equip_dagger.activeSelf == false)
        {
            dagger_unequipped.SetActive(true);
        }
        else
        {
            dagger_equipped.SetActive(true);
        }
    }

    public void OnClickEquip_Dagger()
    {
        equip_dagger.SetActive(true);
        dagger_unequipped.SetActive(false);
    }

    public void OnClickUnequip_Dagger()
    {
        equip_dagger.SetActive(false);
        dagger_equipped.SetActive(false);
    }

    public void OnClickShield()
    {
        if (equip_shield.activeSelf == false)
        {
            shield_unequipped.SetActive(true);
        }
        else
        {
            shield_equipped.SetActive(true);
        }
    }
    public void OnClickEquip_Shield()
    {
        equip_shield.SetActive(true);
        shield_unequipped.SetActive(false);
    }

    public void OnClickUnequip_Shield()
    {
        equip_shield.SetActive(false);
        shield_equipped.SetActive(false);
    }

    public void OnClickArmor()
    {
        if (equip_armor.activeSelf == false)
        {
            armor_unequipped.SetActive(true);
        }
        else
        {
            armor_equipped.SetActive(true);
        }
    }

    public void OnClickEquip_Armor()
    {
        equip_armor.SetActive(true);
        armor_unequipped.SetActive(false);
    }

    public void OnClickUnequip_Armor()
    {
        equip_armor.SetActive(false);
        armor_equipped.SetActive(false);
    }


    public void OnClickQuit()
    {
        newbow_equipped.SetActive(false);
        dagger_equipped.SetActive(false);
        shield_equipped.SetActive(false);
        armor_equipped.SetActive(false);

        newbow_unequipped.SetActive(false);
        dagger_unequipped.SetActive(false);
        shield_unequipped.SetActive(false);
        armor_unequipped.SetActive(false);
    }
}
