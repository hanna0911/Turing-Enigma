using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public string answer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onChange()
    {
        answer = GetComponent<InputField>().text;
        Debug.Log("new text: " + answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
