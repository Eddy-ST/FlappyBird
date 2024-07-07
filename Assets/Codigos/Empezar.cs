
using UnityEngine;
using UnityEngine.SceneManagement;

public class Empezar: MonoBehaviour
{
   
    public void menuNiveles()
    {
        
        SceneManager.LoadScene(1);

    }
    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void nivel1()
    {

    SceneManager.LoadScene(2);
    }
    public void nivel2()
    {

    SceneManager.LoadScene(3);
    }
    public void nivel3()
    {
        SceneManager.LoadScene(4);
    }
    public void nivel4()
    {
        SceneManager.LoadScene(5);
    }
    public void nivel5() 
    { SceneManager.LoadScene(6);
    }
    public void nivel6()
    {
        SceneManager.LoadScene(7);
    }
    public void nivel7()
    {

    SceneManager.LoadScene(8);
    }
    public void nivel8()
    {
        SceneManager.LoadScene(9);
    }
    public void nivel9()
    {
        SceneManager.LoadScene(10); 
    }
    public void nivel10()
    {
        SceneManager.LoadScene(11);
    }
    public void Salir()
    {
        Application.Quit();
    }
   
}