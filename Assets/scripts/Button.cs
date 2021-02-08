using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button: MonoBehaviour
{

    public void Lento()
    {
        Time.timeScale = 0.5f;
    }

    public void Normal()
    {
        Time.timeScale = 1;
    }

    public void Rapido()
    {
        Time.timeScale = 3;
    }
}
