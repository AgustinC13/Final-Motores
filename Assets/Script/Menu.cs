using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar ()
    {
        SceneManager.LoadScene("Juego");
    }
    public void Instrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }
    
    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Salir ()
    {
        Application.Quit ();
    }
}
