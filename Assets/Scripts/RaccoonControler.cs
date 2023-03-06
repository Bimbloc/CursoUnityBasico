using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonControler : MonoBehaviour
{
  //En este  Script vamos a :
  // recoger el input del jugador
    //con el sistema de input de unity 
    // y con los codigos de las  teclas tbm
  //Usar ese input para mover al mapache
    //movimiento por fisicas
    //movimiento sin fisicas
    Rigidbody rb = null;
    
    float velocidadH = 0;
    float velocidadV = 0;
    float velocidadlineal = 0.2f;
    float velocidadangular = 0.2f;
    int fuerzasalto = 5;
    Quaternion myrotacion = new Quaternion();
    Vector3 direccion = new Vector3();
   DonutGun gun;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myrotacion = rb.rotation;
        gun = GetComponent<DonutGun>();
    }

    // Update is called once per frame
    void Update()
    {
        //input de unity 
        // estos ejes se corresponde a WASD , a los cursores del teclado y al joystick de un mando
        //el sistema de input Manager de unity se puede modificar :
        // Edit > Project Settings > Input Manager
        velocidadH = Input.GetAxis("Horizontal");
        velocidadV = Input.GetAxis("Vertical");
        direccion.x = -velocidadV;
        direccion.z = -velocidadH;


        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            rb.AddForce(transform.up*fuerzasalto , ForceMode.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
          
            gun.Dispara();
        
        }

        //Movimiento  sin fisicas
        //El objecto se va teletransportando a grandes velocidades puede llegar a  ignorar todas las colisiones
      /*
        transform.Translate((direccion) * velocidadlineal*Time.deltaTime);
        transform.Rotate(0, direccion.z * velocidadangular, 0);
        Quaternion rot = transform.rotation;
        rot.x = 0;
        rot.z = 0;
        transform.rotation = rot;
      */
    }

    void FixedUpdate()
    {
        direccion.x = -velocidadV;
        direccion.z = velocidadH;
        direccion.Normalize();
        float angulo = Mathf.Atan2(direccion.x, direccion.y)*Mathf.Rad2Deg;

        //movimiento por fuerzas
        //Se pueden añadir aceleraciones y fuerzas lineales con AddForce
        //Se pueden añadir fuerzas de rotacion con AddTorque
        /*
          rb.AddForce(direccion.normalized * velocidadlineal, ForceMode.Acceleration);
          rb.AddRelativeTorque(new Vector3(0, direccion.z, 0).normalized * velocidadangular, ForceMode.Force);
        
         */

        //movimiento por propiedades fisicas
        //podemos cambiar la velocidad y la rotacion del rigidbody directamente
        /*   
         rb.velocity = transform.right * direccion.x*velocidadlineal;
        transform.Rotate(0, direccion.z * velocidadangular,0);
      */

        //Translate rigidbodyversion
        // A grandes velocidades puede llegar a ignorar todas las colisiones
        rb.MovePosition(transform.position + transform.right*(direccion.x) * velocidadlineal);
        Quaternion rot = transform.rotation;
        rot.x = 0;
        rot.z = 0;
        rot.y += direccion.normalized.z * velocidadangular;
        rb.MoveRotation(rot.normalized);

       
    }
}
