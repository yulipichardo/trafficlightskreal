using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carronegro2 : MonoBehaviour
{
    private float Speed = 1.5f;
    public bool Control1;
    public GameObject Estadosemaforo;

    // Start is called before the first frame update
    void Start()
    {
        Control1 = false;
        transform.position = new Vector2(-0.41f, 7.24f);
        transform.Rotate(0, 0, -180, Space.Self);
        Estadosemaforo = GameObject.Find("semaforocalle2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Estadosemaforo.GetComponent<semaforocalle2>().semaforo_Dosverde || Control1)
        {
            transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="destroyer")
        {
            Destroy(this.gameObject);
        }
   
        if (collision.tag == "Control1")

        {
            Control1 = true;

        }
    }
}
