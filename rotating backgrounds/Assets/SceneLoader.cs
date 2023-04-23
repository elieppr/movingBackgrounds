using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public List<string> scenes; // list of scene names
    private int currentSceneIndex = 0; // current index in list of scenes

    public float timeUntilSceneChange = 30f; // Time until scene change in seconds
    private float elapsedTime = 0f; // Elapsed time since scene start
    private Fader fader;

    private void Start()
    {
        fader = FindObjectOfType<Fader>();
        Debug.Log("??");
        StartCoroutine(ChangeScene());
    }
    void Update()
    {
        // Check if space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ChangeScene());
        }

        elapsedTime += Time.deltaTime;

        if (elapsedTime >= timeUntilSceneChange)
        {
            elapsedTime = 0f;
            StartCoroutine(ChangeScene());

        }
    }

    IEnumerator ChangeScene()
    {
        currentSceneIndex++;
        if (currentSceneIndex >= scenes.Count)
        {
            currentSceneIndex = 0;
        }

        yield return fader.FadeIn(0.3f);
        SceneManager.LoadScene(scenes[currentSceneIndex]);
        yield return fader.FadeOut(0.3f);
        elapsedTime = 0f;
    }
}
