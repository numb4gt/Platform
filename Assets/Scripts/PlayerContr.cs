using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private bool faceRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * move * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 8500);
        }

        if (move > 0 && !faceRight)
            flip();
        else if (move < 0 && faceRight)
            flip();
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
