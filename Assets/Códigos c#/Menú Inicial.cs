using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jugar() 
    {

        SceneManager.LoadScene(0);
    
    }

    public void Salir() 
    {
        Debug.Log("Salir...");
        Application.Quit();
    
    
    }
}
