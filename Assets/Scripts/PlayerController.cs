using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    [Range(1, 10)]
    int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");
        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        Vector3 a = new Vector3(xspeed, 0, zspeed);
        rb.linearVelocity = a;
    }
}
