using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    [Header("총알의 이동 속도")]
    int bulletSpeed;
    //이동에 사용할 리지드 바디 컴포넌트
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //리지드바디 컴포넌트 할당
        rb = GetComponent<Rigidbody>();
        //리지드바디의 속도= 앞쪽 방향*이동 속력
        rb.linearVelocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 3f);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            other.gameObject.GetComponent<PlayerController>().Die();
            


        }


       
    }



}
