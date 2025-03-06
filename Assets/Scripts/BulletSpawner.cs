using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    float minTime;
    [SerializeField]
    float maxTime;
    float spawnRate;
    float passTime;
    public GameObject bullet;
    void Start()
    {
        passTime = 0;
        spawnRate = Random.Range(minTime, maxTime);
       
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBullet();
    }

    private void SpawnBullet()
    {
        passTime += Time.deltaTime;
        if (passTime > spawnRate)
        {
            passTime = 0;
            GameObject bullets= Instantiate(bullet, transform.position, transform.rotation);
            Debug.Log("°Ý¹ß");
            bullets.transform.LookAt(target);
            spawnRate = Random.Range(minTime, maxTime);
        }
    }
}
