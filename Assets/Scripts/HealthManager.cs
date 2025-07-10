using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager: MonoBehaviour
{
    public int score;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        score = 0;
    }

    public void AddScore()
    {
        score++;
        if(uiManager)
        uiManager.UpdateScore(score);
    }

    public void AddScore(int scorePoints)
    {
        score += scorePoints;
        if(uiManager)
        uiManager.UpdateScore(score);
    } 
    public void SubtractScore(int points)
{
    score -= points;
    if (score < 0)
        score = 0;  // Evitar score negativo

    if (uiManager)
        uiManager.UpdateScore(score);
}
    public void TakeDamage(int damage)
{
    SubtractScore(damage);
}
}
