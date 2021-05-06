using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class description_canvas_script : MonoBehaviour
{
    public GameObject canvas;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "the person is " + MatchingDescriptionsData.currentPersonDescriptor.description;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.anyKey)
        {
            canvas.SetActive(false);
        }
    }
}
