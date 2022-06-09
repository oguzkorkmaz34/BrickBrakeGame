using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brickcontornur : MonoBehaviour
{
    [SerializeField]
    GameObject Brickeffeck;
    GameManager gameManager;

    private void Awake()
    {

        gameManager =Object.FindObjectOfType<GameManager>();

    }

    private void OnCollisionEnter2D(Collision2D target)
    {
       
        
        if (target.gameObject.tag == "Ball")
        {
            Instantiate(Brickeffeck, transform.position, transform.rotation);
            gameManager.UpdateScore(5);

            Destroy(gameObject);
        } 
    }
   
}
