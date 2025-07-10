using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pinche: " + other.gameObject.name);
        if (other.gameObject.name == "SimpleFPSController")
        {
            Destroy(gameObject);
            scoreManager.DoDamage(10);
        }
    }
}
