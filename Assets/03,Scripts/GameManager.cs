using UnityEngine;
using UnityEngine.UI;//UI���� ���̺귯��
using UnityEngine.SceneManagement;//�� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;//���� ������ Ȱ��ȭ�Ǵ� �ؽ�Ʈ
    public Text timeText;//�����ð� ��� �ؽ�Ʈ
    public Text recordText;//�ְ� ��� ǥ�� �ؽ�Ʈ

    private float surviveTime;//���� �ð�
    private bool isGameover;//���� ���� ����
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time:" + (int)surviveTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);

            }


        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameOverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if(surviveTime>bestTime)
        {

            bestTime = surviveTime;

            PlayerPrefs.SetFloat("BestTime", bestTime);

        }
        recordText.text = "Best Time" + (int)bestTime;
    }
}
