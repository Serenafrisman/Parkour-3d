using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int HealthPoints;
    public int maxHealthPoints;
    public UIManager uiManager;
    
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        HealthPoints = maxHealthPoints;
    }

    public void AddScore()
    {
        HealthPoints--;
        uiManager.UpdateHealth(HealthPoints);
    }

    public void TakeDamage(int damagePoints)
    {
        if (HealthPoints <= damagePoints)
        {
            // Game over
            return;
        }
        HealthPoints -= damagePoints;
        uiManager.UpdateHealth(HealthPoints);
        Debug.Log("Damage");
    }
}