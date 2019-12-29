using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public void playGame(string newgameleve) {
        SceneManager.LoadScene(newgameleve);
    }
    public void exitGame(string exit)
    {
        Application.Quit();
    }
    public void coseGame(string menu)
    {
        SceneManager.LoadScene(menu);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
