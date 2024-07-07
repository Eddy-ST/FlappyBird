using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
    
{
public Animator canvasAnimator;
public GameObject CanvasPerder;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Perdiste()
    {
        CanvasPerder.SetActive(true);
        Time.timeScale = 0;
    }
    public void ReiniciarNivel1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
        
    }
    public void ReiniciarNivel2()
    {
        SceneManager.LoadScene(3);
    }
    public void ReiniciarNivel3()
    {
        SceneManager.LoadScene(4);
    }
    public void ReiniciarNivel4()
    {
        SceneManager.LoadScene(5);
    }
    public void ReiniciarNivel5()
    {
        SceneManager.LoadScene(6);
    }
    public void ReiniciarNivel6()
    {
        SceneManager.LoadScene(7);
    }
    public void ReiniciarNivel7()
    {
        SceneManager.LoadScene(8);
    }
    public void ReiniciarNivel8()
    {
        SceneManager.LoadScene(9);  
    }
    public void ReiniciarNivel9()
    {
        SceneManager.LoadScene(10);  
    }
    public void ReiniciarNivel10()
    {
        SceneManager.LoadScene(11);
    }
    public void Menu()
    {
        if (canvasAnimator != null)
        {
            canvasAnimator.Play("AnimacionMenuDeFondo", -1, 0f); 
        }
        SceneManager.LoadScene(0);
    }
    public void salir()
    {
        
        Application.Quit();
    }

}