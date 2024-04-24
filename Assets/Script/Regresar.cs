using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Regresar : MonoBehaviour
{
  public void cambiarnivel()
    {
        SceneManager.LoadScene("Nivel");
    }
}
