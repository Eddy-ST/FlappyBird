using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI puntajeTexto;
    public TextMeshProUGUI mejorPuntajeTexto;
    public int puntaje = 0;
    public int mejorPuntaje = 0;
    public int currentLevel = 1;  

    private string MejorPuntajeKey;  

    private void Start()
    {
        
        MejorPuntajeKey = "MejorPuntaje_Nivel_" + currentLevel;
        CargarMejorPuntaje();
        ActualizarTextoPuntaje();
        ActualizarTextoMejorPuntaje();
    }

    public void IncrementarPuntaje()
    {
        puntaje += 1;
        ActualizarTextoPuntaje();
        if (puntaje > mejorPuntaje)
        {
            mejorPuntaje = puntaje;
            GuardarMejorPuntaje();
            ActualizarTextoMejorPuntaje();
        }
    }

    private void ActualizarTextoPuntaje()
    {
        puntajeTexto.text = puntaje.ToString();
    }

    private void ActualizarTextoMejorPuntaje()
    {
        mejorPuntajeTexto.text = mejorPuntaje.ToString();
    }

    private void GuardarMejorPuntaje()
    {
       
        PlayerPrefs.SetInt(MejorPuntajeKey, mejorPuntaje);
        PlayerPrefs.Save();
    }

    private void CargarMejorPuntaje()
    {
       
        if (PlayerPrefs.HasKey(MejorPuntajeKey))
        {
            mejorPuntaje = PlayerPrefs.GetInt(MejorPuntajeKey);
        }
    }
}