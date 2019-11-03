using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Menu Controller Instantiated!");
    }

    public void startGame()
    {
        Debug.Log("Start Game called!");
        SceneManager.LoadScene(1);
    }

    public void endGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
