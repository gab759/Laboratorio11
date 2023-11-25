using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HeaderAttribute("Movement Variables in X")]
    public float speedX;
    public int directionX;
    [HeaderAttribute("Movement Variables in Y")]
    public float speedY;
    public int directionY;
    private Rigidbody2D _compRigidbody;
    private SpriteRenderer _compSpriteRenderer;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, speedY * directionY);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HorizontalWall")
        {
            if (directionX == 1)
            {
                directionX = -1;
                _compSpriteRenderer.flipX = true;
            }
            else if (directionX == -1)
            {
                directionX = 1;
                _compSpriteRenderer.flipX = false;
            }
        }
        if (collision.gameObject.tag == "VerticalWall")
        {
            if (directionY == 1)
            {
                directionY = -1;
                _compSpriteRenderer.flipY = true;
            }
            else if (directionY == -1)
            {
                directionY = 1;
                _compSpriteRenderer.flipY = false;
            }
        }
    }
}

