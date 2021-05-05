using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class canvas_script : MonoBehaviour
{
    bool male = false;
    string genderText, occupationText, scenarioText = "scenario";
    bool officer = false;
    public GameObject genderMenu;
    public GameObject launchMenu;
    public GameObject occupationMenu;
    public GameObject civilianMenu;
    public GameObject officerMenu;
    public Text configurationText;
    public int backState = 0;
    public int scenario_code = 0;
    /*backState codes
    0 = go back to gender screen
    1 = go back to occupation screen
    2 = go back to officer menu
    3 = go back to civilian Menu
    */

    

    // list of unused personDescriptors
    // list of used personDescriptors
    // score
    // currentPersonDescriptor = null
    


      public void LaunchScene(){


  MatchingDescriptionsData.PersonDescriptor description1 = new MatchingDescriptionsData.PersonDescriptor("25-30","male","IC1","grey top","grey shorts","slim","white trainers","blonde hair","A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers.");
                MatchingDescriptionsData.PersonDescriptor description2 = new MatchingDescriptionsData.PersonDescriptor("35-40","female","IC3","red and black top","burgundy jeans","plump","white boots","black hair","A 35-40 year old IC3 plump female with black hair wearing a red and black top, burgundy jeans, white boots and black leather jacket.");
                MatchingDescriptionsData.PersonDescriptor description3 = new MatchingDescriptionsData.PersonDescriptor("30-35","female","IC1","pink sweater vest","black shorts","","d3","flip-flops","A 30-35 IC1 skinny female with blonde hair wearing a white top, pink sweater vest, black shorts and flip-flops.");
                MatchingDescriptionsData.PersonDescriptor description4 = new MatchingDescriptionsData.PersonDescriptor("18-23","female","IC1","white top","blue jeans","","d4","white pumps","An 18-23 year old IC1 athletic female with black hair wearing a white top, blue jeans and white pumps.");
                MatchingDescriptionsData.PersonDescriptor description5 = new MatchingDescriptionsData.PersonDescriptor("40-45","female","IC1","blue shirt","brown jeans","","d5","slip-ons","A 40-45 year old IC1 slim female with dirty blonde hair wearing a blue shirt, brown jeans and brown slip-ons.");
                MatchingDescriptionsData.PersonDescriptor description6 = new MatchingDescriptionsData.PersonDescriptor("40-45","female","IC2","navy suit","navy suit","","d6","black heels","A 40-45 year old IC2 average-build female with black hair wearing a navy suit and black heels.");
                MatchingDescriptionsData.PersonDescriptor description7 = new MatchingDescriptionsData.PersonDescriptor("20-25","male","IC3","black hoodie","baggy black jeans","","d7","red trainers","A 20-25 year old IC3 muscular male with black hair wearing a black hoodie, baggy black jeans, red trainers, headphones and black cap.");
                MatchingDescriptionsData.PersonDescriptor description8 = new MatchingDescriptionsData.PersonDescriptor("35-40","male","IC1","black jumper","black jeans","","d8","black trainers","A 35-40 year old IC1 average-build male with black hair wearing a black jumper, white shirt, black jeans and black trainers.");
                MatchingDescriptionsData.PersonDescriptor description9 = new MatchingDescriptionsData.PersonDescriptor("30-35","female","IC3","orange vest","black jeans","","d9","khaki boots","A 30-35 year old IC3 curvy female with black hair wearing an orange vest, black jeans, khaki boots and grey bucket hat.");
                MatchingDescriptionsData.PersonDescriptor description10 = new MatchingDescriptionsData.PersonDescriptor("45-50","male","IC3","bright blue shirt","black trousers","","d10","black work shoes","A 45-50 year old IC3 stocky male with black hair wearing a bright blue shirt, black trousers and black work shoes.");
                MatchingDescriptionsData.PersonDescriptor description11 = new MatchingDescriptionsData.PersonDescriptor("35-40","female","IC1","patterned vest","denim shorts","","d11","","A 35-40 year old IC1 average-build female with blonde hair wearing a patterned vest, denim shorts and flip-flops.");
                MatchingDescriptionsData.PersonDescriptor description12 = new MatchingDescriptionsData.PersonDescriptor("20-25","male","IC2","red top","white shorts","d12","","white trainers","A 20-25 year old IC2 slim male with brunette hair wearing a red top, white shorts, white trainers and tattoos on both arms");
                MatchingDescriptionsData.PersonDescriptor description13 = new MatchingDescriptionsData.PersonDescriptor("45-50","male","IC1","black suit, white shirt, black tie","black suit","","d13","black smart shoes","A 45-50 year old IC1 slim male with black hair wearing a black suit, white shirt, black tie and black smart shoes.");
                MatchingDescriptionsData.PersonDescriptor description14 = new MatchingDescriptionsData.PersonDescriptor("40-45","female","IC3","striped blue and white sweater","blue jeans","","d14","red heels","A 40-45 year old IC3 average-build female with black hair wearing a striped blue and white sweater, blue jeans and red heels.");
                MatchingDescriptionsData.PersonDescriptor description15 = new MatchingDescriptionsData.PersonDescriptor("35-40","male","IC1","blue shirt, black leather jacket","dark grey jeans","","d15","black shoes","A 35-40 year old IC1 slim male with black hair wearing a blue shirt, black leather jacket, dark grey jeans and black shoes.");
                MatchingDescriptionsData.PersonDescriptor description16 = new MatchingDescriptionsData.PersonDescriptor("18-23","male","IC2","white tracksuit","white tracksuit","","d16","black trainers","An 18-23 year old bearded IC2 muscular male with brunette hair wearing a white tracksuit and black trainers.");
                MatchingDescriptionsData.PersonDescriptor description17 = new MatchingDescriptionsData.PersonDescriptor("18-23","female","IC2","orange jumper","denim shorts","","d17","orange trainers","An 18-23 year old IC2 athletic female with brunette hair wearing an orange jumper, denim shorts and orange trainers.");
                MatchingDescriptionsData.PersonDescriptor description18 = new MatchingDescriptionsData.PersonDescriptor("35-40","male","IC1","white top","blue jeans","","d18","white trainers","A 35-40 year old IC1 muscular bald male wearing a white top, blue jeans and white trainers.");
                MatchingDescriptionsData.PersonDescriptor description19 = new MatchingDescriptionsData.PersonDescriptor("25-30","male","IC1","red top","black jeans","","d19","black shoes","A 25-30 year old IC1 slim male wearing a red top, black jeans, black shoes and brown cap.");
                MatchingDescriptionsData.PersonDescriptor description20 = new MatchingDescriptionsData.PersonDescriptor("20-25","male","IC2","white football kit","white football kit","","d20","black trainers","A 20-25 year old IC2 athletic male with black hair wearing a white football kit and black trainers.");
                MatchingDescriptionsData.PersonDescriptor description21 = new MatchingDescriptionsData.PersonDescriptor("30-35","female","IC2","pink jumper","black leggings","","d21","white pumps","A 30-35 year old IC2 slim female with black hair wearing a pink jumper, black leggings and white pumps.");
                MatchingDescriptionsData.PersonDescriptor description22 = new MatchingDescriptionsData.PersonDescriptor("35-40","female","IC4","blue jacket, white top","","","d22","white heels","A 35-40 year old IC4 average-build female with black hair wearing a blue jacket, white top, khaki trousers and white heels.");
                MatchingDescriptionsData.PersonDescriptor description23 = new MatchingDescriptionsData.PersonDescriptor("25-30","male","IC3","black leather jacket","khaki trousers","","d23","black boots","A 25-30 year old IC3 muscular male with black hair wearing a black leather jacket, black trousers, black boots, black cap and black sunglasses.");
                MatchingDescriptionsData.PersonDescriptor description24 = new MatchingDescriptionsData.PersonDescriptor("35-40","female","IC2","white chef's jacket","black trousers","","d24","","A 35-40 year old IC2 average-build female with brunette hair wearing a white chef's jacket, black trousers and black slip-ons.");
                MatchingDescriptionsData.PersonDescriptor description25 = new MatchingDescriptionsData.PersonDescriptor("50-55","female","IC5","black and red dress","black and red dress","","d25","black slip-ons","A 50-55 year old IC5 average-build female with black hair wearing a white, black and red dress and red sandals.");
                MatchingDescriptionsData.PersonDescriptor description26 = new MatchingDescriptionsData.PersonDescriptor("40-45","female","IC4","white jacket","black trousers","","d26","black slip-ons","A 40-45 year old IC4 slim female with black hair wearing a white jacket, black trousers and black slip-ons.");
                MatchingDescriptionsData.PersonDescriptor description27 = new MatchingDescriptionsData.PersonDescriptor("18-23","male","IC3","black hoodie","black jeans","","d27","black trainers","An 18-23 year old IC3 athletic male with black hair wearing a black hoodie, black jeans and black trainers.");
                MatchingDescriptionsData.PersonDescriptor description28 = new MatchingDescriptionsData.PersonDescriptor("30-35","male","IC1","grey top","baggy black trousers","","d28","brown boots","A 30-35 year old bearded IC1 stocky male with black hair wearing a grey top, baggy black trousers, brown boots, orange vest and white helmet.");
                MatchingDescriptionsData.PersonDescriptor description29 = new MatchingDescriptionsData.PersonDescriptor("20-25","male","IC3","white shirt","black jeans","","d29","black shoes","A 20-25 year old IC3 slim male with black hair wearing a white shirt, black jeans and black shoes.");

                MatchingDescriptionsData.PersonDescriptor[ ] personDs = new MatchingDescriptionsData.PersonDescriptor[]{
                    description1, description2, description3,description4,description5,
                    description6, description7, description8,description9,description10,
                    description11, description12, description13,description14,description15,
                    description16, description17, description18,description19,description20,
                    description21, description22, description23,description24,description25,
                    description26, description27, description28,description29 ,/*description30,
                    description31, description32, description33,description34,description35,
                    description36, description32, description38,description39,description40,
                    description41, description42, description43,description44,description45,
                    description46, description47, description48,description49,description50, */
                    } ; 

                     List <MatchingDescriptionsData.PersonDescriptor> personDescriptors = new List<MatchingDescriptionsData.PersonDescriptor>();
                    for(int i=0; i<personDs.Length;i++){
                        personDescriptors.Add(personDs[i]);
                    }

                    MatchingDescriptionsData.score = 100;
                    MatchingDescriptionsData.personDescriptors = personDescriptors;
                    int index = Random.Range(0, MatchingDescriptionsData.personDescriptors.Count);
                    MatchingDescriptionsData.currentPersonDescriptor = MatchingDescriptionsData.personDescriptors[index];
                    MatchingDescriptionsData.personDescriptors.RemoveAt(index);





  switch (scenario_code)
      {
              
          case 0:
              SceneManager.LoadScene("CivillianScene");
              break;
          case 1:
              SceneManager.LoadScene("CivillianScene");
              break;
          case 2:
               
               /*  MatchingDescriptionsData.PersonDescriptor description30 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description31 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description32 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description33 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description34 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description35 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description36 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description37 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description38 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description39 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description40 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description41 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description42 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description43 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description44 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description45 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description46 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description47 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description48 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description49 = new MatchingDescriptionsData.PersonDescriptor();
                MatchingDescriptionsData.PersonDescriptor description50 = new MatchingDescriptionsData.PersonDescriptor(); */

                

                   

              /*
              pass personDescriptors
              */
              
              MatchingDescriptionsData.testsLeft = 3;
              SceneManager.LoadScene("MatchingDescriptionsScene");
              break;
          case 3:
              MatchingDescriptionsData.firstTest=true; 
              
              MatchingDescriptionsData.testName = "ReligiousItem";
              SceneManager.LoadScene("ReligiousItems");
              break;
          case 4:
              
              MatchingDescriptionsData.firstTest=true;
              MatchingDescriptionsData.testName = "General";
              SceneManager.LoadScene("General");
              break;
          default:
              break;
      }

        
        }
    public void ShowOccupationMenu(bool gender){
        male = gender;
        backState = 0;
        genderMenu.SetActive(false);
        occupationMenu.SetActive(true);
        if(male == true){
            MatchingDescriptionsData.gender="male"; 
            genderText = "Male";
            configurationText.text = genderText+"\nSelect Occupation";
        }
        else{
            MatchingDescriptionsData.gender="female"; 
            genderText = "Female";
            configurationText.text = genderText+"\nSelect Occupation";
        }


    }
    public void ShowCivilianMenu(){
        officer = false;
        backState = 1;
        occupationText = "civilian";
        occupationMenu.SetActive(false);
        civilianMenu.SetActive(true);
        configurationText.text = genderText+","+occupationText+"\nSelect Scenario";
    }
    public void ShowOfficerMenu(){
        officer = true;
        backState = 1;
        occupationText = "officer";
        occupationMenu.SetActive(false);
        officerMenu.SetActive(true);
        configurationText.text = genderText+","+occupationText+"\nSelect Scenario";
    
    }
    public void ShowLaunchMenu(int scenarioCode){
        if(officer == true){backState = 2;}
        else{backState = 3;}

        switch (scenarioCode)
      {
          case 0:
              scenarioText = "Lawful Search";
              break;
          case 1:
              scenarioText = "Unlawful Search";
              break;
          case 2:
              scenarioText = "Matching Descriptions";
              break;
          case 3: 
              scenarioText = "Religious bias";
              break;
          case 4: 
              scenarioText = "General";
              break;
          default:
              
              break;
      }
        
        scenario_code = scenarioCode;
        civilianMenu.SetActive(false);
        officerMenu.SetActive(false);
        launchMenu.SetActive(true);
        configurationText.text = genderText+","+occupationText+","+scenarioText;
    }
    public void GoBack(){
        switch (backState)
      {
          case 0:
              configurationText.text = "Select Gender";
              occupationMenu.SetActive(false);
              civilianMenu.SetActive(false);
              launchMenu.SetActive(false);
              officerMenu.SetActive(false);
              genderMenu.SetActive(true);
              break;
          case 1:
              configurationText.text = genderText+"\nSelect Occupation";
              occupationMenu.SetActive(true);
              civilianMenu.SetActive(false);
              launchMenu.SetActive(false);
              officerMenu.SetActive(false);
              genderMenu.SetActive(false);
              backState = 0;
              break;
          case 2:
              configurationText.text = genderText+","+occupationText+"\nSelect Scenario";
              occupationMenu.SetActive(false);
              civilianMenu.SetActive(false);
              launchMenu.SetActive(false);
              officerMenu.SetActive(true);
              genderMenu.SetActive(false);
              backState = 1;
              break;
          case 3: 
              configurationText.text = genderText+","+occupationText+"\nSelect Scenario";
              occupationMenu.SetActive(false);
              civilianMenu.SetActive(true);
              launchMenu.SetActive(false);
              officerMenu.SetActive(false);
              genderMenu.SetActive(false);
              backState = 1;
              break;
          default:
              
              break;
      }
    }

    void Awake(){
    
    genderMenu = GameObject.Find ("Gender Menu");
    occupationMenu = GameObject.Find ("Occupation Menu");
    civilianMenu = GameObject.Find ("Civilian Menu");
    launchMenu = GameObject.Find ("Launch Menu");
    officerMenu = GameObject.Find ("Officer Menu");
    configurationText = GameObject.Find ("Configuration Text").GetComponent<Text>();
    
    occupationMenu.SetActive(false);
    civilianMenu.SetActive(false);
    launchMenu.SetActive(false);
    officerMenu.SetActive(false);

    }





     public void Exit()
	{
		Application.Quit ();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
