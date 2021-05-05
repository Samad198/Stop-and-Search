using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPCController2 : MonoBehaviour
{
    private float timeToChangeDirection;
    public float timeToStopLook;

    private List<int> answersStack = new List<int>();
    private List<int> correctAnswersStack = new List<int>();
    private int answersToPick;


    private Animator animator;
   
    public CanvasGroup canvasGroup;
    public GameObject answerButtons;
    public GameObject answer1,answer2,answer3,answer4,answer5,answer6,answer7,answer8,answer9,answer10;
    
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
         answerButtons.SetActive(false);
         
         
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

         switch(MatchingDescriptionsData.testName){
             case "MatchingDescriptions":
             break;
             case "General":
             if(MatchingDescriptionsData.gender == my_gender){
              correctAnswersStack.Add(1); // answer 1
              correctAnswersStack.Add(2); // answer 2
              correctAnswersStack.Add(3); // answer 3
              correctAnswersStack.Add(4); // answer 4
              correctAnswersStack.Add(5); // answer 5
              correctAnswersStack.Add(6); // answer 6
              correctAnswersStack.Add(7); // answer 7
              correctAnswersStack.Add(8); // answer 8
              correctAnswersStack.Add(9); // answer 9
              correctAnswersStack.Add(10); // answer 10
             }
             else{
                 correctAnswersStack.Add(1); // answer 1
              correctAnswersStack.Add(2); // answer 2
              correctAnswersStack.Add(3); // answer 3
              correctAnswersStack.Add(4); // answer 4
              correctAnswersStack.Add(5); // answer 5
              correctAnswersStack.Add(6); // answer 6
              correctAnswersStack.Add(7); // answer 7
              correctAnswersStack.Add(8); // answer 8
              correctAnswersStack.Add(9); // answer 9
              correctAnswersStack.Add(10); // answer 10
             }
             break;
             case "ReligiousItem":
              if(MatchingDescriptionsData.gender == my_gender){
              correctAnswersStack.Add(1); // answer 1
              correctAnswersStack.Add(2); // answer 2
              correctAnswersStack.Add(3); // answer 3
              correctAnswersStack.Add(4); // answer 4
              correctAnswersStack.Add(5); // answer 5
              correctAnswersStack.Add(6); // answer 6
              correctAnswersStack.Add(7); // answer 7
              correctAnswersStack.Add(8); // answer 8
              correctAnswersStack.Add(9); // answer 9
              correctAnswersStack.Add(10); // answer 10
             }
             else{
                 correctAnswersStack.Add(1); // answer 1
              correctAnswersStack.Add(2); // answer 2
              correctAnswersStack.Add(3); // answer 3
              correctAnswersStack.Add(4); // answer 4
              correctAnswersStack.Add(5); // answer 5
              correctAnswersStack.Add(6); // answer 6
              correctAnswersStack.Add(7); // answer 7
              correctAnswersStack.Add(8); // answer 8
              correctAnswersStack.Add(9); // answer 9
              correctAnswersStack.Add(10); // answer 10
             }
             break;
             default:
             break;

         }
        
     }
     
     // Update is called once per frame
     public void Update () {
         timeToChangeDirection -= Time.deltaTime;
         //timeToStopLook -= Time.deltaTime;

        /*   if (Input.GetKeyDown("space"))
        {
            StopPersonGeneral();
        } */
 
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
     
     
public void StopPersonGeneral(){
         
    /* if(MatchingDescriptionsData.currentPersonDescriptor.age_range != "" && my_age_range != MatchingDescriptionsData.currentPersonDescriptor.age_range ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 2;}
    if(MatchingDescriptionsData.currentPersonDescriptor.race != "" && my_race != MatchingDescriptionsData.currentPersonDescriptor.race  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;}
    if(MatchingDescriptionsData.currentPersonDescriptor.gender != "" && my_gender != MatchingDescriptionsData.currentPersonDescriptor.gender ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;}
    if(MatchingDescriptionsData.currentPersonDescriptor.clothes_top != "" && my_clothes_top != MatchingDescriptionsData.currentPersonDescriptor.clothes_top  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.clothes_bottom != "" && my_clothes_bottom != MatchingDescriptionsData.currentPersonDescriptor.clothes_bottom  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.build != "" && my_build != MatchingDescriptionsData.currentPersonDescriptor.build ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.shoes != "" && my_shoes != MatchingDescriptionsData.currentPersonDescriptor.shoes ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.hair != "" && my_hair != MatchingDescriptionsData.currentPersonDescriptor.hair ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    MatchingDescriptionsData.testsLeft -= 1;

    canvasGroup.alpha = 0f;
    canvasGroup.interactable = false; */
    
        
         answerButtons.SetActive(true);
    
  
    
     }

        public void chooseOtherGender(string gen){
        int index = Random.Range (0, MatchingDescriptionsData.personDescriptors.Count);
        if(MatchingDescriptionsData.personDescriptors[index].gender != gen){
        MatchingDescriptionsData.currentPersonDescriptor = MatchingDescriptionsData.personDescriptors[index];
        MatchingDescriptionsData.personDescriptors.RemoveAt(index);
        }
        else{chooseOtherGender(gen);}
        }

        public void markTest(){
            for(int i=0; i<correctAnswersStack.Count;i++){
                int correctAnswer = correctAnswersStack[i];
                for(int j=0;j<answersStack.Count;j++){
                    int answer = answersStack[j];
                    if(answer == correctAnswer){
                        MatchingDescriptionsData.score = MatchingDescriptionsData.score - Mathf.Min(Mathf.Abs(i - j), 5);//difference between i and j max 5 tho
                        break;
                    }
                    if(j==answersStack.Count-1){
                        MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;
                        
                    }
                }
            }
        }
        /* public void chooseOption1(){}
        public void chooseOption2(){}
        public void chooseOption3(){}
        public void chooseOption4(){}
        public void chooseOption5(){}
        public void chooseOption6(){}
        public void chooseOption7(){}
        public void chooseOption8(){}
        public void chooseOption9(){}
        public void chooseOption10(){} */

     public void chooseOption1(){
        answersStack.Add(1);
        answer1.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            // calculate the users points, set it to the static script, send them to end scene or to the same scene but for girl
            // this time
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
        
    }
    public void chooseOption2(){
          Debug.Log("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
        answersStack.Add(2);
        answer2.SetActive(false);
        /* if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        } */
    }
    public void chooseOption3(){
        answersStack.Add(3);
        answer3.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption4(){
        answersStack.Add(4);
        answer4.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption5(){
        answersStack.Add(5);
        answer5.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption6(){
        answersStack.Add(6);
        answer6.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption7(){
        answersStack.Add(7);
        answer7.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption8(){
        answersStack.Add(8);
        answer8.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption9(){
        answersStack.Add(9);
        answer9.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption10(){
        answersStack.Add(10);
        answer10.SetActive(false);
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==false){
        chooseOtherGender(my_gender);    
        SceneManager.LoadScene("MatchingDescriptionsScene");
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
}
