using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;
    private GameObject jugador;
    public int rapidez;

    void Start()
    {
        hp = 100;
        jugador = GameObject.Find("Jugador");
    }

    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp<=0)
        {
            this.desaparecer();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
    }
}
