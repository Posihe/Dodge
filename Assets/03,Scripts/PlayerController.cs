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
        //수평축과 수직축의 입력값을 저장
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");
        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xspeed = xinput * speed;
        float zspeed = zinput * speed;
        //vector3속도를 생성
        Vector3 a = new Vector3(xspeed, 0, zspeed);
        //리지드바디의 속도에 할당
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
