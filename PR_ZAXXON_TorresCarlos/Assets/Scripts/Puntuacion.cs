using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    Inicio inicio;
    public static float score;
    public Text puntuacion;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        StartCoroutine("Puntos");
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = score.ToString();
    }
    IEnumerator Puntos()
    {
        while (true)
        {
            inicio = GameObject.Find("Variables").GetComponent<Inicio>();
            speed = inicio.spaceship;
            score = score + 1 * speed;
            yield return new WaitForSeconds(0.5f);

        }
    }
}
