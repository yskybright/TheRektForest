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

    void Start()
    {
        equip_newbow.SetActive(false);
        equip_dagger.SetActive(false);
        equip_shield.SetActive(false);
        equip_armor.SetActive(false);
    }

    // 각 item별로 장착/해제 팝업이 나오도록 설정
    #region _NewBow
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
    #endregion

    #region _Dagger
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
    #endregion

    #region _Shield
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
    #endregion

    #region _Armor
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
    #endregion

    // quit 버튼을 누르면 어떤 창이든 꺼짐
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
