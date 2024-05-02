using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoingBack : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Options Scene");
    }
}