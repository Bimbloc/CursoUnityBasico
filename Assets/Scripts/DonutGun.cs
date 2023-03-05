using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutGun : MonoBehaviour
{
    //el punto  donde se generan los proyectiles 
    [SerializeField]
    GameObject cannon = null;
    //el prefab del proyectil que queremos 
    [SerializeField]
    GameObject bullet = null;

    Transform cannonTransform = null;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

  public   void Dispara()
    {
        //generamos el prefab de proyectil
        Instantiate(bullet, cannon.transform.position,   cannon.transform.rotation);
    
    }

}
