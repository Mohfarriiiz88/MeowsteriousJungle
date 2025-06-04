using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunctionTask : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerHealth;
    public int playerArmor;
    public int playerDamage;
    void Start()
    {
        Debug.Log("Player Status: " + GetPlayerStatus());
        Debug.Log("Effective Damage: " + CalculateEffectiveDamage());
        Debug.Log("Is Player Alive? " + IsPlayerAlive());
    }
    string GetPlayerStatus()
    {
        if (playerHealth > 75)
            return "Sehat";
        else if (playerHealth > 40)
            return "Luka Ringan";
        else if (playerHealth > 0)
            return "Luka Parah";
        else
            return "Mati";
    }
    int CalculateEffectiveDamage()
    {
        int effectiveDamage = playerDamage - playerArmor;
        if (effectiveDamage < 0)
            effectiveDamage = 0;

        return effectiveDamage;
    }
    bool IsPlayerAlive()
    {
        return playerHealth > 0;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
