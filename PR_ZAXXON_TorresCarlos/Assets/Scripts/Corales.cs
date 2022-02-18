using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corales : MonoBehaviour
{
    bool hit = false;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Subma") && !hit)
        {
            Coger();
            hit = true;
        }
    }


    void Coger()
    {
        GameManager.globalscore++;
        Destroy(gameObject);
    }
}



