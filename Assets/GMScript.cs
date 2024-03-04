using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GMScript : MonoBehaviour
{
    public int lastPlayerAttackDamage;
    public int playerHP;
    public int enemyHP;
    public TextMeshProUGUI informationText;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = 1000;
        enemyHP = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        informationText.text = "Player HP: " + playerHP + "\nEnemy HP: " +enemyHP;
    }

    public void PlayerAttack()
    {
        Debug.Log("Player attacks!");
        enemyHP -= 100;
    }

    public void PlayerDefend()
    {
        Debug.Log("Player defends!");
    }

    public void PlayerSkill()
    {
        Debug.Log("Player uses a skill!");
    }
}
