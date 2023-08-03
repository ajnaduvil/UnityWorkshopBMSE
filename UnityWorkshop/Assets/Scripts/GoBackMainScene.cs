using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackMainScene : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoBack();
        }
    }
}
