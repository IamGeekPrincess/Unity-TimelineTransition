using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    public int index;
    private GameObject sphere;

    private void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("sphere");
        if (sphere != null)
        {
            sphere.transform.localPosition = new Vector3(0f, 0f, 0f);
            sphere.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    private void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(index);
        if (sphere != null)
        {
            Destroy(sphere);
        }
    }
}
