using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void Empezar_Juego(string Juego)
    { 
    SceneManager.LoadScene(Juego);  
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Se cerro");
    }
}