using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    [Range(1, 10)]
    int speed;
    [SerializeField]
    [Range(1, 30)]
    int jumpPower;
    bool isGround;
    [SerializeField]
    int jumpCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
        isGround = true;
        jumpCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }
    private void Move()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");
        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        Vector3 a = new Vector3(xspeed, 0, zspeed);
        rb.linearVelocity = a;
    }
    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount>0)
        {



            //rb.AddForce(Vector3.up*jumpPower, ForceMode.Impulse); 
            rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);

            jumpCount--; 
           

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround=true;
            jumpCount = 1;


        }
    }
  
}
