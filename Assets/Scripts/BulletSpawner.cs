using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // �Ѿ��� ������ ����� Transform ������Ʈ.
    public Transform target;

    // �Ѿ��� �����Ǵ� �ּ� �ð� ����.
    [SerializeField]
    [Range(1, 5)]
    float minTime;

    // �Ѿ��� �����Ǵ� �ִ� �ð� ����.
    [SerializeField]
    [Range(1, 5)]
    float maxTime;

    // �Ѿ��� �����Ǵ� �ð� ����.
    float spawnRate;

    // ���������� �Ѿ��� ������ �� ����� �ð�.
    float passTime;

    // ������ �Ѿ��� ������.
    public GameObject bullet;

    // Start�� ù ������ ������Ʈ ���� ȣ��˴ϴ�.
    void Start()
    {
        // passTime�� 0���� �ʱ�ȭ�մϴ�.
        passTime = 0;

        // �ʱ� spawnRate�� minTime�� maxTime ������ ���� ������ �����մϴ�.
        spawnRate = Random.Range(minTime, maxTime);
    }

    // Update�� �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        // �� �����Ӹ��� SpawnBullet �޼��带 ȣ���մϴ�.
        SpawnBullet();
    }

    // �Ѿ��� �����ϴ� �޼���.
    private void SpawnBullet()
    {
        // ���� ������ ���� ����� �ð��� passTime�� ���մϴ�.
        passTime += Time.deltaTime;

        // passTime�� spawnRate�� �ʰ��ߴ��� Ȯ���մϴ�.
        if (passTime > spawnRate)
        {
            // passTime�� 0���� �����մϴ�.
            passTime = 0;

            // ���� ��ġ�� ȸ���� �Ѿ��� �����մϴ�.
            GameObject bullets = Instantiate(bullet, transform.position, transform.rotation);

            // ����� �޽����� �ֿܼ� ����մϴ�.
            Debug.Log("�ݹ�");

            // �Ѿ��� Ÿ���� �ٶ󺸰� �մϴ�.
            bullets.transform.LookAt(target);

            // ���ο� ���� spawnRate�� minTime�� maxTime ���̿��� �����մϴ�.
            spawnRate = Random.Range(minTime, maxTime);
        }
    }
}
