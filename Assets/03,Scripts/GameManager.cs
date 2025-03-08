using UnityEngine;
using UnityEngine.UI;//UI관련 라이브러리
using UnityEngine.SceneManagement;//씬 관리 관련 라이브러리

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;//게임 오버시 활성화되는 텍스트
    public Text timeText;//생존시간 기록 텍스트
    public Text recordText;//최고 기록 표시 텍스트

    private float surviveTime;//생존 시간
    private bool isGameover;//게임 오버 상태
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
