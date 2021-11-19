using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    Inicio inicio;
    [SerializeField] Image vidasImagen;
    [SerializeField] Sprite [] vidasSprite;
    int vidas;

    // Start is called before the first frame update
    void Start()
    {
        
        if(Juego.vidasJugador == 0)
        {
            Juego.vidasJugador = 3;
        }
        print(Juego.vidasJugador);
        vidas = Juego.vidasJugador;
        vidasImagen.sprite = vidasSprite[vidas];
    }

    // Update is called once per frame
    void Update()
    {
        inicio = GameObject.Find("Variables").GetComponent<Inicio>();
       if(vidas==0)
        {
            SceneManager.LoadScene(3);
            new WaitForSeconds(10);
        }
        
        
    }
    public IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==3 && inicio.vidas>0)
        {
            inicio.vidas--;
            vidas--;
            vidasImagen.sprite = vidasSprite[vidas];
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
