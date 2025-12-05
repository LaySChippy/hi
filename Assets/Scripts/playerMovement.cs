using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private float xMove;

    private float yMove;

    private Rigidbody2D rb;

    private bool isGrounded;
    public float radius;
    public float jumpforce;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxis("Horizontal"));
        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * 10, rb.linearVelocity.y);
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, radius, LayerMask.GetMask("Ground"));
        if (Input.GetKeyDown(KeyCode.UpArrow)&& isGrounded)
        {
            rb.AddForce(transform.up*jumpforce);
        }
    }

    public void Resetplayer()
    {
        //transform.position = currentCheckpoint.position;
    }
    
}
