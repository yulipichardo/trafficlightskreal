using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carroazul1 : MonoBehaviour
{
    public GameObject Estadosemaforo;
    private float Speed=1.3f;
    public bool Control1;

    // Start is called before the first frame update
    void Start()
    {
        Control1 = false;
        transform.position = new Vector2(-8.68f,0.28f);
        transform.Rotate(0,0,-90, Space.Self);
        Estadosemaforo = GameObject.Find("semaforocalle1");
    }

    // Update is called once per frame
    void Update()
    {
        if(Estadosemaforo.GetComponent<semaforocalle1>().semaforo_UnoyTresverde||Control1)
        {
            transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
        }

    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="destroyer")
        {
            Destroy(this.gameObject);
        }
  
    if(collision.tag=="Control1")

      {
        Control1= true;

      }
    }
}
