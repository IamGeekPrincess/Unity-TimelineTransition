using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject sphere1,sphere2,sphere3;
    public GameObject[] sphere;
    string modelName;
    public float speed;
    public LevelChanger levelchanger;

    private static Orbit instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                modelName = Hit.transform.name;
                switch (modelName)
                {
                    case "0":
                        levelchanger.FadeToNextLevel();
                        DontDestroyOnLoad(sphere1.gameObject);
                        sphere1.transform.localPosition = new Vector3(0f, 0f, 0f);
                        sphere1.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);

                        break;
                    case "1":
                        levelchanger.FadeToNextLevel();
                        DontDestroyOnLoad(sphere2.gameObject);
                        sphere2.transform.localPosition = new Vector3(0f, 0f, 0f);
                        sphere2.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                        break;
                    case "2":
                        levelchanger.FadeToNextLevel();
                        DontDestroyOnLoad(sphere3.gameObject);
                        sphere3.transform.localPosition = new Vector3(0f, 0f, 0f);
                        sphere3.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                        break;
                   
                    default:
                        break;

                }
            }

        }
        OrbitAround();
    }
    
    

    void OrbitAround()
    {
        
        for (int i = 1; i < sphere.Length; i++)
        {         sphere[i].transform.RotateAround(sphere[i-1].transform.position, Vector3.up, speed * Time.deltaTime);  }
    } 
}
