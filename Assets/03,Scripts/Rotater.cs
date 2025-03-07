using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        rotationSpeed = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed*Time.deltaTime, 0f);
    }
}
