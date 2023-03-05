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
        //other es lo que se choca con el objeto que tiene este script trashcan.
        //tenemos que asegurarnos que se ha chocado el objeto que queremos antes de  modificarlo
        
        if(other.gameObject.GetComponent<Donut>()!=null)//Como alternativa se pueden usar capas de colision
            Destroy(other.gameObject);
    }
}
