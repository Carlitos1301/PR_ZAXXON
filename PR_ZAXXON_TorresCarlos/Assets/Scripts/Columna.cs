using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    Inicio inicio;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        inicio = GameObject.Find("Variables").GetComponent<Inicio>();
        speed = inicio.spaceship;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        float posZ = transform.position.z;
        if (posZ < - 20)
        {
            Destroy(gameObject);
        }
    }
}
