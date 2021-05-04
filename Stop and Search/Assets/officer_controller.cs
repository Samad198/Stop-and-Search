using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class officer_controller : MonoBehaviour
{
    private float timeInSequence;
    private Animator animator;
    public GameObject gameTextObject;
    public Text gameText;
    private Vector3 currentDirection;
    private Vector3 rotation;
    private int sequenceNumber;
    
    private void Awake(){
         animator = GetComponentInChildren<Animator>();
         
         //my_age_range = MatchingDescriptionsData.personDescriptors[0].age_range;
     }


    // Start is called before the first frame update
    void Start()
    {
        sequenceNumber = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeInSequence -= Time.deltaTime;
        switch(sequenceNumber){
            case 0:
            gameText.text = "The officer has identified you as a suspicious individual..."+
	                        "The best course of action is to let them approach you and see "+
	                        "What they have to say.";
            animator.Play("Idle");
            if (Input.anyKey)
        {
            timeInSequence = 5.0f;
            gameTextObject.SetActive(false);
            sequenceNumber =1;
        }
            
            break;
            case 1:
            animator.Play("Walking");
            transform.position += transform.forward * Time.deltaTime * 2.0f;
            if(timeInSequence<=0){
                sequenceNumber = 2;
            }
            break;
            case 2:
            animator.Play("Idle");
            break;
            case 3:
            break;
            case 4:
            break;
            case 5:
            break;
            case 6:
            break;
            case 7:
            break;
            case 8:
            break;
            case 9:
            break;
            case 10:
            break;
            case 11:
            break;
            case 12:
            break;
            case 13:
            break;
            case 14:
            break;
            case 15:
            break;
            default:
            break;
            


        }
        
        


        
    }
}
