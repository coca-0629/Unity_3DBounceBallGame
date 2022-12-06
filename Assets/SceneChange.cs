using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private static float time_stop = 0.0f; 
    private bool is_Triggered = false;

    private int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;

        time_stop = 0.0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (is_Triggered == true) {
            time_stop += Time.deltaTime;
        }
        if ((time_stop) >= 5) {
            SceneManager.LoadScene(sceneIndex + 1);
        }
    }
    
    private void OnCollisionEnter(Collision other) {
        is_Triggered = true;
    }
}
