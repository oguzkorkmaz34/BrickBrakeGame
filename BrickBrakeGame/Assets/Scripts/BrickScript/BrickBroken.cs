using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBroken : MonoBehaviour
{
    [SerializeField]
    private Sprite Broken›mage;
    int count;
    [SerializeField]
  
    GameObject brickBrokenEffeck;

    GameManager gameManager;

    private void Awake()
    {

        gameManager = Object.FindObjectOfType<GameManager>();

    }

    private void Start()
    {
        count = 0;
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ball")
        {
            count++;

            if (count == 1)
            {
                GetComponent<SpriteRenderer>().sprite = Broken›mage;
                gameManager.UpdateScore(5);
            }
            else if (count == 2)
            {
                Instantiate(brickBrokenEffeck, transform.position, transform.rotation);
                gameManager.UpdateScore(5);
                Destroy(gameObject);
            }
        }
    }

}



