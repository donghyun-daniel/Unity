using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(Character target)
    {
        Debug.Log(target.playerName + "의 체력 강화!");
        target.hp += 10;
    }

    public void SheildBoost(Character target)
    {
        Debug.Log(target.playerName + "의 방어력 강화!");
        target.defense += 10;
    }

    public void DmgBoost(Character target)
    {
        Debug.Log(target.playerName + "의 공격력 강화!");
        target.dmg += 10;
    }
}
