using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour
{
    int creationTime = 0;//lo vamos a hacer con corrutina asi qeu no nos hace falta
    int lifeTIme = 5;
    int velocidad = 4;
    //temprizadores 
    //if time <0 o corrutinas ???
    //en general el coste de comprobar algo en el update y una corrutina  es muy parecido 
    //en este caso nos da exactametne lo  mismo cuadno se  acabe la corrutina el donut se  muere y el update se acabaria tambien.
    Rigidbody rb = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("CuentaAtras");
        //Destroy tiene su propio countdown pero asi tenemos un ejemplo sencillo de una corrutina en le proyecto
        //Destroy(gameObject , countdown)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rb.velocity = -transform.right * velocidad;
    }
    IEnumerator CuentaAtras()
    {
        while (lifeTIme>0)
        {
            // Debug.Log("contando");
            lifeTIme--;
            yield return new WaitForSeconds(1);
        }
        //despues de lifeTime segundos se acaba
        Destroy(gameObject);
    }
}
