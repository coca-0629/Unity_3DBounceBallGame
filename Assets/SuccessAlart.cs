using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessAlart : MonoBehaviour
{
    public Texture2D icon = null;
    public Text startText;
    public Text successText;
    private static float time_record = 0.0f; 

    private int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        startText.enabled = true;
        successText.enabled = false;
        time_record = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - time_record) >= 2)
            startText.enabled = false;
    }
    
    private void OnCollisionEnter(Collision other) {
        successText.enabled = true;
    }

    void OnGUI() {
        GUI.DrawTexture (new Rect(Screen.width - 64, Screen.height - 64, 64, 64), icon);
        GUI.Label(new Rect(Screen.width - 185, Screen.height - 40, 128, 32), "Time : " + (Time.time - time_record).ToString());
    }
}
