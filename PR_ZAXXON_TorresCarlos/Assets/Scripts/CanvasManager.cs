using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasManager : MonoBehaviour
{
    public void IniciarJuego()
    {
        Juego.vidasJugador = 3;
        SceneManager.LoadScene(1);
    }
}
