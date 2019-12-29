using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    public static float speed = 1;
    public Vector2 velocity = new Vector2(-4, 0);
   
    public float range = 10f;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocity*speed;
        transform.position = new Vector3(transform.position.x - range * Random.value, transform.position.y - range * Random.value, 0);
        
        //for starts
        
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < 0)
        {
            Destroy(gameObject);
        }
	}
    
}
