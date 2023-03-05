using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

   
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);//al cargar otras escenas este objeto NO se  destruye
        }
        else
        { Destroy(this.gameObject); }
    }
    public static GameManager GetInstance()
    {
        return instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiaEscena(string escena)
    {
        changeScene(escena);
    }
    void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
