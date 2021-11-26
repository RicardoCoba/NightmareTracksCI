using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalFuncion : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Mapa");
    }

    public void EscenaContinuar()
    {
        SceneManager.LoadScene("MenuContinuar");
    }

    public void EscenaCreditos()
    {
        SceneManager.LoadScene("MenuCreditos");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
