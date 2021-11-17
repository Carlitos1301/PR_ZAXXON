using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    Inicio inicio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inicio = GameObject.Find("Variables").GetComponent<Inicio>();
        
    }
    public IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==3 && inicio.vidas>0)
        {
            inicio.vidas--;
            print(inicio.vidas);
            yield return new WaitForSeconds(2);
           
        }
        else if (other.gameObject.layer == 6 && inicio.vidas > 0)
        {
            print("Tiempo");
            yield return new WaitForSeconds(2);
        }
        else if(inicio.vidas == 0)
        {

        }
           
    }
}
