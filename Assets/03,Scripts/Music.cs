using System.Collections;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource audioSource;
    public float duration = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(VolumDownRoutine());
    }

    // Update is called once per frame
    IEnumerator VolumDownRoutine()
    {
        float elapsedTime = 0;
        elapsedTime += Time.deltaTime;
        audioSource.Play();
        while (elapsedTime <= duration)
        {
            audioSource.volume = Mathf.Lerp(1f, 0f, elapsedTime / duration);
        }

        yield return new WaitForSeconds(duration);

    }
}
