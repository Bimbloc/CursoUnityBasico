using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playbutton : MonoBehaviour
{
    [SerializeField]
    string playlevel="";//nombre de la escena a la que cambiamos
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        GameManager.GetInstance().CambiaEscena(playlevel);// el game manager debe estar en un objeto en la escena y la  escena que 
        //queremos  cargar tiene que  estar incluida en lo Build Settings
    }
}
