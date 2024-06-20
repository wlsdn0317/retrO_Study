using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;


    public float speed = 10f;
    private Rigidbody playerRigidbody; 

    void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    
    }

    void Update()
    {
        if (gameManager.isGameOver == true)
        {
            return;
        }


        //-1 ~ +1
        //"Horizontal" 수평, A,D
        //true or false가 아닌 이유는 '조이스틱'때문에
        //조이스틱으로 살짝 미는 것이 가능하기 때문에
        //키보드는 -1,0,1 만가능
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y; 

        Vector3 velocity = new Vector3(inputX,0,inputZ);

        velocity *= 10;

        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;
    }
}
