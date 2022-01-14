using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadGameDelay = 4.3f;
    int currentSceneIndex = 0;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadScene(currentSceneIndex + 1));
        }
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        yield return new WaitForSeconds(loadGameDelay);

        SceneManager.LoadScene(sceneIndex);
    }

}
