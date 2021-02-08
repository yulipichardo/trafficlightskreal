using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforocalle3 : MonoBehaviour
{
    public GameObject semaforotresverde;
    public GameObject semaforotresamarillo;
    public GameObject semaforotresrojo;
    public bool semaforo_Tresverde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficlight());
    }
    void tresverde()
    {
        semaforotresverde.SetActive(true);
        semaforotresamarillo.SetActive(false);
        semaforotresrojo.SetActive(false);
        semaforo_Tresverde = true;
    }
    void tresamarillo()
    {
        semaforotresverde.SetActive(false);
        semaforotresamarillo.SetActive(true);
        semaforotresrojo.SetActive(false);
        semaforo_Tresverde = true;
    }
    void tresrojo()
    {
        semaforotresverde.SetActive(false);
        semaforotresamarillo.SetActive(false);
        semaforotresrojo.SetActive(true);
        semaforo_Tresverde = false;
    }
    IEnumerator trafficlight()
    {
        while (true)
        {
            tresverde();
            yield return new WaitForSeconds(3);
            tresamarillo();
            yield return new WaitForSeconds(2);
            tresrojo();
            yield return new WaitForSeconds(5);

        }
    }
}
