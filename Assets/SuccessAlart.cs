using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessAlart : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other) {
        text.enabled = true;
        //Debug.Log(other.gameObject.tag);
    }
}
