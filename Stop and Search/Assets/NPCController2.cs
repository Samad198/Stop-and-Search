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
    public int answersToPick;


    private Animator animator;
   
    public CanvasGroup canvasGroup;
    public GameObject religiousItem;
    public GameObject answerButtons;
    public GameObject answer1,answer2,answer3,answer4,answer5,answer6,answer7,answer8,answer9,answer10,answer11,answer12,answer13,answer14;
    
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
             pd = new PD("35-40","female","IC3","red and black top","burgundy jeans","plump","white boots","black hair","A 35-40 year old IC3 plump female with black hair wearing a red and black top, burgundy jeans, white boots and black leather jacket.");
             break;
             case 3:
             pd = new PD("30-35","female","IC1","pink sweater vest","black shorts","","d3","flip-flops","A 30-35 IC1 skinny female with blonde hair wearing a white top, pink sweater vest, black shorts and flip-flops.");
             break;
             case 4:
             pd = new PD("18-23","female","IC1","white top","blue jeans","","d4","white pumps","An 18-23 year old IC1 athletic female with black hair wearing a white top, blue jeans and white pumps.");
             break;
             case 5:
             pd = new PD("40-45","female","IC1","blue shirt","brown jeans","","d5","slip-ons","A 40-45 year old IC1 slim female with dirty blonde hair wearing a blue shirt, brown jeans and brown slip-ons.");
             break;
             case 6:
             pd = new PD("40-45","female","IC2","navy suit","navy suit","","d6","black heels","A 40-45 year old IC2 average-build female with black hair wearing a navy suit and black heels.");
             break;
             case 7:
             pd = new PD("20-25","male","IC3","black hoodie","baggy black jeans","","d7","red trainers","A 20-25 year old IC3 muscular male with black hair wearing a black hoodie, baggy black jeans, red trainers, headphones and black cap.");
             break;
             case 8:
             pd = new PD("35-40","male","IC1","black jumper","black jeans","","d8","black trainers","A 35-40 year old IC1 average-build male with black hair wearing a black jumper, white shirt, black jeans and black trainers.");
             break;
             case 9:
             pd = new PD("30-35","female","IC3","orange vest","black jeans","","d9","khaki boots","A 30-35 year old IC3 curvy female with black hair wearing an orange vest, black jeans, khaki boots and grey bucket hat.");
             break;
             case 10:
             pd = new PD("45-50","male","IC3","bright blue shirt","black trousers","","d10","black work shoes","A 45-50 year old IC3 stocky male with black hair wearing a bright blue shirt, black trousers and black work shoes.");
             break;
             case 11:
             pd = new PD("35-40","female","IC1","patterned vest","denim shorts","","d11","","A 35-40 year old IC1 average-build female with blonde hair wearing a patterned vest, denim shorts and flip-flops.");
             break;
             case 12:
             pd = new PD("20-25","male","IC2","red top","white shorts","d12","","white trainers","A 20-25 year old IC2 slim male with brunette hair wearing a red top, white shorts, white trainers and tattoos on both arms");
             break;
             case 13:
             pd = new PD("45-50","male","IC1","black suit, white shirt, black tie","black suit","","d13","black smart shoes","A 45-50 year old IC1 slim male with black hair wearing a black suit, white shirt, black tie and black smart shoes.");
             break;
             case 14:
             pd = new PD("40-45","female","IC3","striped blue and white sweater","blue jeans","","d14","red heels","A 40-45 year old IC3 average-build female with black hair wearing a striped blue and white sweater, blue jeans and red heels.");
             break;
             case 15:
             pd = new PD("35-40","male","IC1","blue shirt, black leather jacket","dark grey jeans","","d15","black shoes","A 35-40 year old IC1 slim male with black hair wearing a blue shirt, black leather jacket, dark grey jeans and black shoes.");
             break;
             case 16:
             pd = new PD("18-23","male","IC2","white tracksuit","white tracksuit","","d16","black trainers","An 18-23 year old bearded IC2 muscular male with brunette hair wearing a white tracksuit and black trainers.");
             break;
             case 17:
             pd = new PD("18-23","female","IC2","orange jumper","denim shorts","","d17","orange trainers","An 18-23 year old IC2 athletic female with brunette hair wearing an orange jumper, denim shorts and orange trainers.");
             break;
             case 18:
             pd = new PD("35-40","male","IC1","white top","blue jeans","","d18","white trainers","A 35-40 year old IC1 muscular bald male wearing a white top, blue jeans and white trainers.");
             break;
             case 19:
             pd = new PD("25-30","male","IC1","red top","black jeans","","d19","black shoes","A 25-30 year old IC1 slim male wearing a red top, black jeans, black shoes and brown cap.");
             break;
             case 20:
             pd = new PD("20-25","male","IC2","white football kit","white football kit","","d20","black trainers","A 20-25 year old IC2 athletic male with black hair wearing a white football kit and black trainers.");
             break;
             case 21:
             pd = new PD("30-35","female","IC2","pink jumper","black leggings","","d21","white pumps","A 30-35 year old IC2 slim female with black hair wearing a pink jumper, black leggings and white pumps.");
             break;
             case 22:
             pd = new PD("35-40","female","IC4","blue jacket, white top","","","d22","white heels","A 35-40 year old IC4 average-build female with black hair wearing a blue jacket, white top, khaki trousers and white heels.");
             break;
             case 23:
             pd = new PD("25-30","male","IC3","black leather jacket","khaki trousers","","d23","black boots","A 25-30 year old IC3 muscular male with black hair wearing a black leather jacket, black trousers, black boots, black cap and black sunglasses.");
             break;
             case 24:
             pd = new PD("35-40","female","IC2","white chef's jacket","black trousers","","d24","","A 35-40 year old IC2 average-build female with brunette hair wearing a white chef's jacket, black trousers and black slip-ons.");
             break;
             case 25:
             pd = new PD("50-55","female","IC5","black and red dress","black and red dress","","d25","black slip-ons","A 50-55 year old IC5 average-build female with black hair wearing a white, black and red dress and red sandals.");
             break;
             case 26:
             pd = new PD("40-45","female","IC4","white jacket","black trousers","","d26","black slip-ons","A 40-45 year old IC4 slim female with black hair wearing a white jacket, black trousers and black slip-ons.");
             break;
             case 27:
             pd = new PD("18-23","male","IC3","black hoodie","black jeans","","d27","black trainers","An 18-23 year old IC3 athletic male with black hair wearing a black hoodie, black jeans and black trainers.");
             break;
             case 28:
             pd = new PD("30-35","male","IC1","grey top","baggy black trousers","","d28","brown boots","A 30-35 year old bearded IC1 stocky male with black hair wearing a grey top, baggy black trousers, brown boots, orange vest and white helmet.");
             break;
             case 29:
             pd = new PD("20-25","male","IC3","white shirt","black jeans","","d29","black shoes","A 20-25 year old IC3 slim male with black hair wearing a white shirt, black jeans and black shoes.");
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
             case "General":
                answersToPick =10;
                correctAnswersStack.Add(1); // answer 1
                correctAnswersStack.Add(4); // answer 2
                correctAnswersStack.Add(3); // answer 3
                correctAnswersStack.Add(2); // answer 4
                correctAnswersStack.Add(5); // answer 5
                correctAnswersStack.Add(7); // answer 6
                correctAnswersStack.Add(9); // answer 7
                correctAnswersStack.Add(14); // answer 8
                correctAnswersStack.Add(12); // answer 9
             if(MatchingDescriptionsData.gender == my_gender){
              correctAnswersStack.Add(6); // answer 10
             }
             else{ 
              correctAnswersStack.Add(8); // answer 10
             }
             break;
             case "ReligiousItem":
             answersToPick =11;
                correctAnswersStack.Add(1); // answer 1
                correctAnswersStack.Add(4); // answer 2
                correctAnswersStack.Add(3); // answer 3
                correctAnswersStack.Add(2); // answer 4
                correctAnswersStack.Add(5); // answer 5
                correctAnswersStack.Add(7); // answer 6
                correctAnswersStack.Add(9); // answer 7
                correctAnswersStack.Add(14); // answer 8
                correctAnswersStack.Add(12); // answer 9
                correctAnswersStack.Add(10); // answer 10
              if(MatchingDescriptionsData.gender == my_gender){
               correctAnswersStack.Add(6); // answer 11
             }
             else{
                 correctAnswersStack.Add(8); // answer 11
             }
             break;
             default:

             break;

         }
        
     }
     
     // Update is called once per frame
     public void Update () {
         timeToChangeDirection -= Time.deltaTime;
         timeToStopLook -= Time.deltaTime;

        
          if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            chooseOption5();
           chooseOption6();
           chooseOption7();
           chooseOption8();
           chooseOption9();
           chooseOption10();
           chooseOption1();
           chooseOption2();
           chooseOption3();
           chooseOption4();
          
        }
        
 
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
     
     
public void StopPersonGeneral(){
         
    if(MatchingDescriptionsData.currentPersonDescriptor.age_range != "" && my_age_range != MatchingDescriptionsData.currentPersonDescriptor.age_range ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 2;}
    if(MatchingDescriptionsData.currentPersonDescriptor.race != "" && my_race != MatchingDescriptionsData.currentPersonDescriptor.race  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;}
    if(MatchingDescriptionsData.currentPersonDescriptor.gender != "" && my_gender != MatchingDescriptionsData.currentPersonDescriptor.gender ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 5;}
    if(MatchingDescriptionsData.currentPersonDescriptor.clothes_top != "" && my_clothes_top != MatchingDescriptionsData.currentPersonDescriptor.clothes_top  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.clothes_bottom != "" && my_clothes_bottom != MatchingDescriptionsData.currentPersonDescriptor.clothes_bottom  ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.build != "" && my_build != MatchingDescriptionsData.currentPersonDescriptor.build ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.shoes != "" && my_shoes != MatchingDescriptionsData.currentPersonDescriptor.shoes ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    if(MatchingDescriptionsData.currentPersonDescriptor.hair != "" && my_hair != MatchingDescriptionsData.currentPersonDescriptor.hair ){MatchingDescriptionsData.score = MatchingDescriptionsData.score - 1;}
    MatchingDescriptionsData.testsLeft -= 1;

    canvasGroup.alpha = 0f;
    canvasGroup.interactable = false;
    
        
    answerButtons.SetActive(true);
    if(MatchingDescriptionsData.testName != "General"){ 
        religiousItem.SetActive(true);
        }  
        
  
    
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
                    if(answer == correctAnswer){                                            //difference between i and j max 5 tho
                        MatchingDescriptionsData.score = MatchingDescriptionsData.score - Mathf.Min(Mathf.Abs(i - j), 5);
                        break;
                    }
                    if(j==answersStack.Count-1){
                        MatchingDescriptionsData.score = MatchingDescriptionsData.score - 10;
                        
                    }
                }
            }
        }
        

     public void chooseOption1(){
        answersStack.Add(1);
        answer1.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            // calculate the users points, set it to the static script, send them to end scene or to the same scene but for girl
            // this time
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender); 
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
        
    }
    public void chooseOption2(){
          
        answersStack.Add(2);
        answer2.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption3(){
        answersStack.Add(3);
        answer3.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption4(){
        answersStack.Add(4);
        answer4.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption5(){
        answersStack.Add(5);
        answer5.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption6(){
        answersStack.Add(6);
        answer6.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption7(){
        answersStack.Add(7);
        answer7.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        MatchingDescriptionsData.firstTest = false;
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption8(){
        answersStack.Add(8);
        answer8.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption9(){
        answersStack.Add(9);
        answer9.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
    public void chooseOption10(){
        answersStack.Add(10);
        answer10.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }

    public void chooseOption11(){
        answersStack.Add(11);
        answer10.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }

    public void chooseOption12(){
        answersStack.Add(12);
        answer10.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }

    public void chooseOption13(){
        answersStack.Add(13);
        answer10.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }

    public void chooseOption14(){
        answersStack.Add(14);
        answer10.SetActive(false);
        answersToPick-=1;
        if(answersToPick<=0){
            
            markTest();
            
            if(MatchingDescriptionsData.firstTest==true){
                MatchingDescriptionsData.firstTest = false;
        chooseOtherGender(my_gender);    
        if(MatchingDescriptionsData.testName == "General"){ 
        SceneManager.LoadScene("General");
        }  
        else{
            SceneManager.LoadScene("ReligiousItems");
        }
        }
        else{
            SceneManager.LoadScene("EndScene");
        }
        }
    }
}
