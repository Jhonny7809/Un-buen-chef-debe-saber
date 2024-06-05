using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    public GameObject Object,perilla,boton;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Exitoso"))
        {
            Object.SetActive(true);
            boton.SetActive(true);
            
            perilla.GetComponent<RotacionPerilla>().enabled = false;
        }
    }
}
