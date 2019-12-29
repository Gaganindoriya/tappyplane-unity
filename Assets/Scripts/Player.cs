using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Player : MonoBehaviour {
    public Vector2 jumpForce = new Vector2(0, 300);
    Rigidbody2D myPlayer;
    public AudioSource song,tap;
    public GameObject explosion;

    public static float dieAttempt = 1;
    public static bool isGameOverThreeTime=false;
	// Use this for initialization
	void Start () {
        
        myPlayer = GetComponent<Rigidbody2D>();
        song.Play();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            //for mobile
            //Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended;
            //for keyboard 
            //input.getKeyDown("space");
            //for acceleration input.acceleration.x  
            tap.Play();

            myPlayer.velocity = Vector2.zero;
            myPlayer.AddForce(jumpForce);
            
        }

        //Die by being OffMeshLink screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < 0 || screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            
            Die();

            

        }
       
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
       
       // Destroy(gameObject); 
        Destroy(expl, 3);
       // Die();
    }
    void Die()
    {
        dieAttempt++;
        Debug.Log("Die Time"+dieAttempt);
        if (dieAttempt > 5)
        {
            isGameOverThreeTime = true;
            dieAttempt = 1;
            Debug.Log("Game Over true");

        }
        else {
            SceneManager.LoadScene(1);

        }
        //Application.LoadLevel(Application.loadedLevel);
    }
   

}
