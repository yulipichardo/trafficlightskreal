using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busamarillo4 : MonoBehaviour
{
    private float Speed = 1.5f;
    public bool Control1;
    public GameObject Estadosemaforo;

    // Start is called before the first frame update
    void Start()
    {
        Control1 = false;
        transform.position = new Vector2(0.38f,-7.38f);
        transform.Rotate(0, 0, 360, Space.Self);
        Estadosemaforo = GameObject.Find("semaforocalle4");
    }

    // Update is called once per frame
    void Update()
    {
        if (Estadosemaforo.GetComponent<semaforocalle4>().semaforo_Cuatroverde || Control1)
        {
            transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="destroyer")
        {
            Destroy(this.gameObject);
            print("destruido");
        }
        if (collision.tag == "Control1")

        {
            Control1 = true;

        }
    }
}