using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCController : MonoBehaviour
{
    private float timeToChangeDirection;
    private float timeToStopLook;
    private Animator animator;
    //private Rigidbody rigidBody;
    public CanvasGroup canvasGroup;
    public CanvasGroup collider;
    public Transform player;
    public bool isFocused;
    private Vector3 currentDirection;
    Vector3 rotation;
    
    

    public string my_age_range,my_gender, my_race, my_clothes_top,my_clothes_bottom, my_build;

    


    void OnCollisionEnter(Collision col){
   
   ChangeDirection();
 }
 
     // Use this for initialization

     private void Awake(){
         animator = GetComponentInChildren<Animator>();
         
         //my_age_range = MatchingDescriptionsData.personDescriptors[0].age_range;
     }
     public void Start () {
         //isFocused = false;
         ChangeDirection();
         canvasGroup.alpha = 0f;
         collider.alpha = 0f;
        
     }
     
     // Update is called once per frame
     public void Update () {
         timeToChangeDirection -= Time.deltaTime;
         timeToStopLook -= Time.deltaTime;
 
        if( isFocused == true) // the character is focused
        {
            
            //transform.LookAt(player);
                animator.Play("Idle");
                canvasGroup.alpha = 1f;
                
         
         if (timeToStopLook <= 0) {
             isFocused = false;
         }
    

        }

        else{
            animator.Play("Walking");
            
            canvasGroup.alpha = 0f;
         if (timeToChangeDirection <= 0) {
             ChangeDirection();
         }
 
            //transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
            transform.position += transform.forward * Time.deltaTime * 2.0f;
         
        }
     }
 
 
 
     private void ChangeDirection() {
         float angle = Random.Range(0f, 360f);

         rotation = new Vector3(0, angle, 0);
         this.transform.Rotate(rotation);
         
         
         timeToChangeDirection = 10.0f;
     }

    public void LookAtPerson(){
        isFocused = true;
        timeToStopLook = 10000000000000000000.0f;
    }
    public void StopLookAt(){
        timeToStopLook = 5.0f;
    }
     
     public void StopPerson(){
         
    if(MatchingDescriptionsData.currentPersonDescriptor.age_range != "" && my_age_range != MatchingDescriptionsData.currentPersonDescriptor.age_range ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 2;}
    if(MatchingDescriptionsData.currentPersonDescriptor.race != "" && my_race != MatchingDescriptionsData.currentPersonDescriptor.race  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;}
    if(MatchingDescriptionsData.currentPersonDescriptor.gender != "" && my_gender != MatchingDescriptionsData.currentPersonDescriptor.gender ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;}
    if(MatchingDescriptionsData.currentPersonDescriptor.clothes_top != "" && my_clothes_top != MatchingDescriptionsData.currentPersonDescriptor.clothes_top  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.clothes_bottom != "" && my_clothes_bottom != MatchingDescriptionsData.currentPersonDescriptor.clothes_bottom  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.build != "" && my_build != MatchingDescriptionsData.currentPersonDescriptor.build ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}


    if(MatchingDescriptionsData.testsLeft <= 0){
        // end game and show score
    }
    else{
        // calculate the next person descriptor and start next scene
    }
    
     }
}
