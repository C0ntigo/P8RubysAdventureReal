using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");

    }
     void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime; ;

        rigidbody2D.MovePosition(position);
    }
}
