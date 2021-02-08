using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforocalle4 : MonoBehaviour
{

    public GameObject semaforocuatroverde;
    public GameObject semaforocuatrosamarillo;
    public GameObject semaforocuatrorojo;
    public bool semaforo_Cuatroverde;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficlight());
    }
    void cuatroverde()
    {
        semaforocuatroverde.SetActive(true);
        semaforocuatrosamarillo.SetActive(false);
        semaforocuatrorojo.SetActive(false);
        semaforo_Cuatroverde = true;
    }
    void cuatroamarillo()
    {
        semaforocuatroverde.SetActive(false);
        semaforocuatrosamarillo.SetActive(true);
        semaforocuatrorojo.SetActive(false);
        semaforo_Cuatroverde = true;
    }
    void cuatrorojo()
    {
        semaforocuatroverde.SetActive(false);
        semaforocuatrosamarillo.SetActive(false);
        semaforocuatrorojo.SetActive(true);
        semaforo_Cuatroverde = false;
    }
    IEnumerator trafficlight()
    {
        while (true)
        {
            cuatrorojo();
            yield return new WaitForSeconds(5);
            cuatroverde();
            yield return new WaitForSeconds(3);
            cuatroamarillo();
            yield return new WaitForSeconds(2);

        }
    }
}
