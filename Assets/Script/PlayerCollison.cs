using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement movement;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log(collision.collider.tag);
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
