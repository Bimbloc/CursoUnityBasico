using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    //Este script  se encarga de dectectar los objetos que se chocan con la papelera y destruirlos
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        /*  GUIA DE COLISIONES
         *Objetos ESTÁTICOS:Tienen un collider pero NO TIENEN un RigidBody.NO DEBEN MOVERSE.Detectan colisiones en su posicion inicial.
         *Objetos KINEMATICOS:Tienen un collider y un RigidBody marcado como kinematic.Se mueven por codigo NO COLISIONAN CON OBJETOS ESTÁTICOS.
         *Objetos DINÁMICOS:Tienen un collider y un RigidBody NO marcado como kinematic.Colisionan con todo.
         
         
         */

        //other es lo que se choca con el objeto que tiene este script trashcan.
        //tenemos que asegurarnos que se ha chocado el objeto que queremos antes de  modificarlo

        if (other.gameObject.GetComponent<Donut>()!=null)//Como alternativa se pueden usar capas de colision
            Destroy(other.gameObject);
    }
}
