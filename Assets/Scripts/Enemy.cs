using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int currentHP;
    public int maxHP;
    public int goldGive;
    public Image healthBarFill;

    public void Damage()
    {
        currentHP--;

        healthBarFill.fillAmount = (float)currentHP / (float)maxHP;

        if(currentHP <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        Debug.Log("defeated");
    }
}
