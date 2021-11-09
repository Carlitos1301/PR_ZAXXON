using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{   
    public float spaceship;
   
    
    // Start is called before the first frame update
    void Start()
    {
        spaceship = 30f;
        StartCoroutine("Aumento");
    }

    // Update is called once per frame
    void Update()
    {


        
    }
    IEnumerator Aumento()
    {
        while (spaceship <= 150)
        {
            spaceship = spaceship + 5f;
            yield return new WaitForSeconds(5f);
        }
    }
}
