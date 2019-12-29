using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Generate : MonoBehaviour
{
    public GameObject rocks;
    public GameObject stars;
    int score = 0;

    public Text scoretext;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 3f);
       
        scoretext.text = "0";
        Obstacle.speed = 1;

    }
    

    // Update is called once per frame
    void OnGUI()
    {
        //GUI.color = Color.black;
        //GUILayout.Label(" Score: " + score.ToString());
        scoretext.text = "Score : " + score.ToString();
        if (score > 10)
        {
            Obstacle.speed = 2;
          //  SceneManager.LoadScene(0);
        }
        if (score > 20) {
            Obstacle.speed = 3;

        }
        if (score > 30)
        {
            Obstacle.speed = 4;

        }
        if (score > 40)
        {
            Obstacle.speed = 5;

        }
        if (score > 50)
        {
            Obstacle.speed = 6;

        }
    }

    void CreateObstacle()
    {
        Instantiate(rocks);
//        Instantiate(stars);
        score++;

    }
    
    
    
    
}
