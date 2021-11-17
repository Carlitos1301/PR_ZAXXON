using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{   
    public float spaceship;
    public int vidas;
   
    
    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        spaceship = 80f;
        StartCoroutine("Aumento");
    }

    // Update is called once per frame
    void Update()
    {


        
    }
    IEnumerator Aumento()
    {
        while (spaceship <= 250)
        {
            spaceship = spaceship + 5f;
            yield return new WaitForSeconds(5f);
        }
    }
}
