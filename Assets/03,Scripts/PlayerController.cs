using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    [Range(1, 10)]
    int speed;
    //[SerializeField]
    //[Range(1, 30)]
    //int jumpPower;
   
    //[SerializeField]
    //int jumpCount;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
      
        
        //jumpCount = 1;
    }


    void Update()
    {
        Move();
       // Jump();

    }
    private void Move()
    {
        //������� �������� �Է°��� ����
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");
        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xspeed = xinput * speed;
        float zspeed = zinput * speed;
        //vector3�ӵ��� ����
        Vector3 a = new Vector3(xspeed, 0, zspeed);
        //������ٵ��� �ӵ��� �Ҵ�
        rb.linearVelocity = a;
    }

    public void Die()
    {

        gameObject.SetActive(false);
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.EndGame();

    }
    //private void Jump()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space) && jumpCount>0)
    //    {



    //        rb.AddForce(Vector3.up*jumpPower, ForceMode.Impulse); 
           

    //        jumpCount--; 
           

    //    }

    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
           
    //        jumpCount = 1;


    //    }
    //}
  
}
