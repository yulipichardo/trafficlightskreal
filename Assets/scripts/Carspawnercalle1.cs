using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carspawnercalle1 : MonoBehaviour
{
    public float randomizer;
    public GameObject carroazul1;
    public GameObject carronegro2;
    public GameObject carroblanco3;
    public GameObject busamarillo4;
    public semaforocalle1 semaforo1;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createcarroazul1", 0, 4.7f);
     
    }

    // Update is called once per frame
    void Update()
    {
        print(randomizer);
    }

    void createcarroazul1()
    {
        Instantiate(carroazul1, transform.position, Quaternion.identity);
        Instantiate(carronegro2, transform.position, Quaternion.identity);
        Instantiate(carroblanco3, transform.position, Quaternion.identity);
        Instantiate(busamarillo4, transform.position, Quaternion.identity);
    }
}
