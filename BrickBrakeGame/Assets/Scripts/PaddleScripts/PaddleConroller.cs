using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleConroller : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float LeftTarget, RightTarget;

    GameManager gameManager;

    private void Awake()
    {

        gameManager = Object.FindObjectOfType<GameManager>();

    }


    void Update()
    {
        if (gameManager.gameOver)
        {
            return;
        }

        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * h * Time.deltaTime * speed);

        if (transform.position.x<LeftTarget)
        {
            transform.position = new Vector2(LeftTarget, transform.position.y);

        }
        if (transform.position.x > RightTarget)
        {
            transform.position = new Vector2(RightTarget, transform.position.y);

        }
        //***Burasýda Left, right sýnýrlamasý yapabilir***
        //Vector2 temp = transform.position;
        //temp.x = Mathf.Clamp(temp.x, LeftTarget, RightTarget);
        //transform.position = temp;



    }
}
