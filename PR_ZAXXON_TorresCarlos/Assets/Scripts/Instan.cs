using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour
{
    float intervalo;
    float speed;
    [SerializeField] Transform instantiatePos;
    [SerializeField] GameObject[] objetos;
    [SerializeField] float distancia ;
    Inicio inicio;

    // Start is called before the first frame update
    void Start()
    {
        distancia = 6f;
        inicio = GameObject.Find("Variables").GetComponent<Inicio>();
        speed = inicio.spaceship;
        intervalo = distancia / speed;



        StartCoroutine("Columna");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator Columna()
    {
        
        while (true)
        {
            int NumA = Random.Range(0, objetos.Length);


            float randomX = Random.Range(-15f, 15);
            Vector3 newPosX = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);         
            Instantiate(objetos[NumA], newPosX, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);

        }
    }
}
