using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene(1);
    }
    public void Sonido()
    {
        SceneManager.LoadScene(2);
    }
    public void Atras()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
        Application.Quit();
    }

}
