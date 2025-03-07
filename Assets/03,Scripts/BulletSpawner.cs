using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // 총알이 조준할 대상의 Transform 컴포넌트.
    public Transform target;
    
    // 총알이 생성되는 최소 시간 간격.
    [SerializeField]
    [Range(0.5f, 5)]
    float minTime;

    // 총알이 생성되는 최대 시간 간격.
    [SerializeField]
    [Range(1, 3)]
    float maxTime;

    // 총알이 생성되는 시간 간격.
    float spawnRate;

    // 마지막으로 총알이 생성된 후 경과된 시간.
    float passTime;

    // 생성할 총알의 프리팹.
    public GameObject bullet;

    // Start는 첫 프레임 업데이트 전에 호출됩니다.
    void Start()
    {
        //target = FindAnyObjectByType<PlayerController>().transform;
        //Collider[] a = FindObjectsByType<Collider>(FindObjectsSortMode.None);

        // passTime을 0으로 초기화합니다.
        passTime = 0;

        // 초기 spawnRate를 minTime과 maxTime 사이의 랜덤 값으로 설정합니다.
        spawnRate = Random.Range(minTime, maxTime);
        
    }

    // Update는 매 프레임마다 호출됩니다.
    void Update()
    {
        // 매 프레임마다 SpawnBullet 메서드를 호출합니다.
        SpawnBullet();
    }

    // 총알을 생성하는 메서드.
    private void SpawnBullet()
    {
        // 지난 프레임 이후 경과된 시간을 passTime에 더합니다.
        passTime += Time.deltaTime;

        // passTime이 spawnRate를 초과했는지 확인합니다.
        if (passTime >= spawnRate)
        {
            // passTime을 0으로 리셋합니다.
            passTime = 0;

            // 현재 위치와 회전에 총알을 생성합니다.
            GameObject bullets = Instantiate(bullet, transform.position, transform.rotation);

            

            // 총알이 타겟을 바라보게 합니다.
            bullets.transform.LookAt(target);

            // 새로운 랜덤 spawnRate를 minTime과 maxTime 사이에서 설정합니다.
            spawnRate = Random.Range(minTime, maxTime);
        }
    }
}
