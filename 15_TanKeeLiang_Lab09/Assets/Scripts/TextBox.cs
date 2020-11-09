using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public GameObject position;
    // Start is called before the first frame update
    void Start()
    {
        position.GetComponent<Text>().text = "Position: " + GameObject.FindGameObjectWithTag("Character").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.GetComponent<Text>().text = "Position: " + GameObject.FindGameObjectWithTag("Character").transform.position;
    }
}
