using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collsion)
    {
        if (collsion.tag == "border")
        {
            Destroy(this.gameObject);
        }
        else if (collsion.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}
