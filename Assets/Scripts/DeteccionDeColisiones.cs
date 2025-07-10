using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    public MercaderiaScript mercaderiaScript;
    
    void Start()
    {
          if(scoreManager == null)
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScript>();
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
       
        if(scoreManager != null)
        {
          scoreManager.SubtractScore(10);
        }
        else
        {
          Debug.LogError("ScoreManager es null, no está asignado");
        }
        if (col.gameObject.name == "Player")
        {
            //Destroy(gameObject)
        }
        if(mercaderiaScript != null)
            scoreManager.AddScore(mercaderiaScript.scorePoints);
        else
            Debug.LogWarning("MercaderiaScript no asignado");

    }
    }

