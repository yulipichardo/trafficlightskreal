using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforocalle2 : MonoBehaviour
{

    public GameObject semaforodosverde;
    public GameObject semaforodosamarillo;
    public GameObject semaforodosrojo;
    public bool semaforo_Dosverde;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficlight());
    }
    void dosverde()
    {
        semaforodosverde.SetActive(true);
        semaforodosamarillo.SetActive(false);
        semaforodosrojo.SetActive(false);
        semaforo_Dosverde = true;
    }
    void dosamarillo()
    {
        semaforodosverde.SetActive(false);
        semaforodosamarillo.SetActive(true);
        semaforodosrojo.SetActive(false);
        semaforo_Dosverde = true;
    }
    void dosrojo()
    {
        semaforodosverde.SetActive(false);
        semaforodosamarillo.SetActive(false);
        semaforodosrojo.SetActive(true);
        semaforo_Dosverde = false;
    }
    IEnumerator trafficlight()
    {
        while (true)
        {
            dosrojo();
            yield return new WaitForSeconds(5);
            dosverde();
            yield return new WaitForSeconds(3);
            dosamarillo();
            yield return new WaitForSeconds(2);

        }
    }
}
