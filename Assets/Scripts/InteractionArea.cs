using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public MercaderiaScript mercaderia;
    public ScoreManager score;


    private void Start()
    {
        UIInteractionMessage.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                Destroy(mercaderia.gameObject);
                score.AddScore(mercaderia.scorePoints);
                EndInteraction();
            }
        }
    }
   

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        mercaderia = other.GetComponent<MercaderiaScript>();
        if (mercaderia)
        {
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
{
    if (mercaderia != null && other.gameObject == mercaderia.gameObject)
    {
        EndInteraction();
    }
}

    void EndInteraction()
    {
        mercaderia = null;
        canInteract = false;
        UIInteractionMessage.SetActive(false);
    }

}
