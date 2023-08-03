using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneLevelSelection : MonoBehaviour
{
    public void SelectPlayerMovement()
    {
        SceneManager.LoadScene("PlayerMovement");
    }

    public void SelectRotateCube()
    {
        SceneManager.LoadScene("RotateCube");
    }
}
