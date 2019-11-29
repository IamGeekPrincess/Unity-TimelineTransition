using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeatStart : MonoBehaviour
{
    public LevelChanger levelchanger;
    // Start is called before the first frame update
    void Start()
    {
       // levelchanger.FadeToNextLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            levelchanger.FadeToNextLevel();
        }
    }
}
