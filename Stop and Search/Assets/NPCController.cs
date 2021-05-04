using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPCController : MonoBehaviour
{
    private float timeToChangeDirection;
    public float timeToStopLook;

    


    private Animator animator;
    //private Rigidbody rigidBody;
    public CanvasGroup canvasGroup;
    
    public Transform player;
    public bool isFocused;
    private Vector3 currentDirection;
    Vector3 rotation;
    public int personId;
    public string my_age_range,my_gender, my_race, my_clothes_top,my_clothes_bottom, my_build,my_shoes,my_hair;
    public class PD {
    public string age_range,gender, race, clothes_top,clothes_bottom, build,shoes,hair, description;
    
    public PD(string age_range,string gender,string race,string clothes_top,string clothes_bottom,string build,string shoes,string hair,string description) {
        this.age_range = age_range;
        this.gender = gender;
        this.race = race;
        this.clothes_top = clothes_top;
        this.clothes_bottom = clothes_bottom;
        this.build = build;
        this.shoes = shoes;
        this.hair = hair;
        this.description = description;
    }
}
    


    void OnCollisionEnter(Collision col){
   ChangeDirection();
 }
 


     // Use this for initialization
     private void Awake(){
         animator = GetComponentInChildren<Animator>();
         timeToStopLook = 100000;
     }
     public void Start () {
         //isFocused = false;
         ChangeDirection();
         canvasGroup.alpha = 0f;
        
         
         
            PD pd = null;
         switch(personId){
             case 1:
                pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 2:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 3:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 4:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 5:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 6:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 7:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 8:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 9:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 10:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 11:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 12:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 13:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 14:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 15:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 16:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 17:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 18:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 19:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 20:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 21:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 22:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 23:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 24:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 25:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 26:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 27:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 28:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             case 29:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             default:
             pd = new PD("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers");
             break;
             
         }

         my_age_range = pd.age_range;
         my_gender = pd.gender;
         my_race = pd.race;
         my_clothes_top = pd.clothes_top;
         my_clothes_bottom =pd.clothes_bottom;
         my_build = pd.build;
         my_shoes = pd.shoes;
         my_hair = pd.hair;

         
        
     }
     
     // Update is called once per frame
     public void Update () {
         timeToChangeDirection -= Time.deltaTime;
         //timeToStopLook -= Time.deltaTime;
 
        if( isFocused == true) // the character is focused
        {
            
                transform.LookAt(player);
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
            //transform.position += transform.forward * Time.deltaTime * 2.0f;
         
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
    if(MatchingDescriptionsData.currentPersonDescriptor.shoes != "" && my_shoes != MatchingDescriptionsData.currentPersonDescriptor.shoes ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.hair != "" && my_hair != MatchingDescriptionsData.currentPersonDescriptor.hair ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    MatchingDescriptionsData.testsLeft -= 1;

    if(MatchingDescriptionsData.testsLeft <= 0){
        // end game and show score
        SceneManager.LoadScene("EndScene");
    }
    else{
        // calculate the next person descriptor and start next scene
        int index = Random.Range (0, MatchingDescriptionsData.personDescriptors.Count);
        MatchingDescriptionsData.currentPersonDescriptor = MatchingDescriptionsData.personDescriptors[index];
        MatchingDescriptionsData.personDescriptors.RemoveAt(index);
        SceneManager.LoadScene("MatchingDescriptionsScene");
    }
    
     }



}
