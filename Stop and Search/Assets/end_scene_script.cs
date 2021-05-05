using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end_scene_script : MonoBehaviour
{

    public Text gameText;
    // Start is called before the first frame update
    void Start()
    {
        gameText.text = "You have ended the test with a points total of "+MatchingDescriptionsData.score+"/100";
	                        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
