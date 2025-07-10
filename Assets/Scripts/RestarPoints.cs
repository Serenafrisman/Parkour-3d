using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestarPoints : MonoBehaviour
{
        public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
          if (scoreManager == null)
            scoreManager = FindObjectOfType<ScoreManager>();
    }
      private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pinche"))
        {
            scoreManager.SubtractScore(10); // Resta 10 puntos al tocar un pinche
            Debug.Log("Tocado pinche, puntos restados.");
            // NO destruye el pinche
        }
    }
}