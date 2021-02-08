using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforocalle1 : MonoBehaviour
{
    public GameObject semaforoUnoytresverde;
    public GameObject semaforoUnoytresamarillo;
    public GameObject semaforoUnoytresrojo;
    public bool semaforo_UnoyTresverde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficlight());
    }
    void Unoytresverde()
    {
        semaforoUnoytresverde.SetActive(true);
        semaforoUnoytresamarillo.SetActive(false);
        semaforoUnoytresrojo.SetActive(false);
        semaforo_UnoyTresverde = true;
    }
    void Unoytresamarillo()
    {
        semaforoUnoytresverde.SetActive(false);
        semaforoUnoytresamarillo.SetActive(true);
        semaforoUnoytresrojo.SetActive(false);
        semaforo_UnoyTresverde = true;
    }
    void Unoytresrojo()
    {
        semaforoUnoytresverde.SetActive(false);
        semaforoUnoytresamarillo.SetActive(false);
        semaforoUnoytresrojo.SetActive(true);
        semaforo_UnoyTresverde = false;
    }
    IEnumerator trafficlight()
    {
        while (true)
        {
            Unoytresverde();
            yield return new WaitForSeconds(3);
            Unoytresamarillo();
            yield return new WaitForSeconds(2);
            Unoytresrojo();
            yield return new WaitForSeconds(5);

        }
    }
}

