using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    [Header("�Ѿ��� �̵� �ӵ�")]
    int bulletSpeed;
    //�̵��� ����� ������ �ٵ� ������Ʈ
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //������ٵ� ������Ʈ �Ҵ�
        rb = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ�= ���� ����*�̵� �ӷ�
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
