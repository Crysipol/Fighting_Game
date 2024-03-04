using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    public int lastPlayerAttackDamage;
    public int playerHP;
    public int enemyHP;
    public TextMeshProUGUI informationText;
    public bool hasGameEnded;
    public bool isPlayerTurn;
    public bool playerDefended;
    public bool skillAvailable;
    public Button attackButton;
    public Button defendButton;
    public Button skillButton;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = 1000;
        enemyHP = 1000;
        hasGameEnded = false;
        isPlayerTurn = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (hasGameEnded == false)
        {
            informationText.text = "Player HP: " + playerHP + "\nEnemy HP: " +enemyHP;
            
            if (isPlayerTurn == true)
            {
                Debug.Log("Player's turn!");

                attackButton.interactable = true;
                defendButton.interactable = true;

                if (skillAvailable == true)
                {
                    skillButton.interactable = true;
                }

                else if (skillAvailable == false)
                {
                    skillButton.interactable = false;
                }
            }

            else if (isPlayerTurn == false)
            {
                Debug.Log("Enemy's turn!");
                attackButton.interactable = false;
                defendButton.interactable = false;
                skillButton.interactable = false;
                EnemyAttack();
            }
        }
    }

    public void PlayerAttack()
    {
        Debug.Log("Player attacks!");
        lastPlayerAttackDamage = Random.Range(150,301);
        enemyHP -= lastPlayerAttackDamage;

        isPlayerTurn = false;
    }

    public void PlayerDefend()
    {
        Debug.Log("Player defends!");
        skillAvailable = true;
        playerDefended = true;
        isPlayerTurn = false;
    }

    public void PlayerSkill()
    {
        Debug.Log("Player uses a skill!");
        lastPlayerAttackDamage = Random.Range(300,501);
        enemyHP -= lastPlayerAttackDamage;
        skillAvailable = false;
        isPlayerTurn = false;
    }

    public void EnemyAttack()
    {
        if (playerDefended == false)
        {
            playerHP -= Random.Range(150,301);
        }
        
        else if (playerDefended == true)
        {
            playerHP -= Random.Range(50,101);
            playerDefended = false;
        }
        
        is PlayerTurn = true;
    }
}
