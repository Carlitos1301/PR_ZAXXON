using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;

    //Variables para restricción
    float limiteH = 15f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;   
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento de la nave
      
        float desplX = Input.GetAxis("Horizontal") * speed;
        float posX = transform.position.x;

        if ((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
        {
            transform.Translate(Vector3.right * desplX * Time.deltaTime * speed, Space.World);
        }
       












    }
}
