using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{
    Renderer rend;
    Vector2 despl;
    float scrollSpeed;
    Inicio inicio;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        inicio = GameObject.Find("Variables").GetComponent<Inicio>();

    }

    // Update is called once per frame
    void Update()
    {
        Textura();
    }

    void Textura()
    {
        scrollSpeed = inicio.spaceship/20;
        float offset = Time.time * scrollSpeed;
        despl = new Vector2(0, -offset);
        rend.material.SetTextureOffset("_MainTex", despl);
        print(scrollSpeed);
    }
}
