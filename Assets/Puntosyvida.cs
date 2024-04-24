using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textopuntos;
    private int puntaje = 0;
    private float tiempo = 0f;
    private float interval = 2f;

    private void Update()
    {
        textopuntos.text = "Puntos: " + puntaje;
        UpdatePoints();
    }
    void UpdatePoints()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= interval)
        {
            puntaje = puntaje + 1;
            tiempo = 0f;
        }
    }
   
}
