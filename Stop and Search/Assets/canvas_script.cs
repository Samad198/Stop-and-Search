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

  switch (scenario_code)
      {
          case 0:
              SceneManager.LoadScene("UnlawfulStop");
              break;
          case 1:
              SceneManager.LoadScene("LawfulStop");
              break;
          case 2:
                MatchingDescriptionsData.PersonDescriptor description1 = new MatchingDescriptionsData.PersonDescriptor("coo","l","wha","t","s","d","f");
                MatchingDescriptionsData.PersonDescriptor description2 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description3 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description4 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description5 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description6 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description7 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description8 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description9 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description10 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description11 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description12 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description13 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description14 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description15 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description16 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description17 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description18 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description19 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description20 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description21 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description22 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description23 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description24 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description25 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description26 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description27 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description28 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description29 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
                MatchingDescriptionsData.PersonDescriptor description30 = new MatchingDescriptionsData.PersonDescriptor("","","","","","","");
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
                MatchingDescriptionsData.PersonDescriptor description50 = new MatchingDescriptionsData.PersonDescriptor();

                MatchingDescriptionsData.PersonDescriptor[ ] personDescriptors = new MatchingDescriptionsData.PersonDescriptor[]{
                    description1, description2, description3,description4,description5,
                    description6, description7, description8,description9,description10,
                    description11, description12, description13,description14,description15,
                    description16, description17, description18,description19,description20,
                    description21, description22, description23,description24,description25,
                    description26, description27, description28,description29,description30,
                    description31, description32, description33,description34,description35,
                    description36, description32, description38,description39,description40,
                    description41, description42, description43,description44,description45,
                    description46, description47, description48,description49,description50,
                    } ; 

              /*
              pass personDescriptors
              */
              MatchingDescriptionsData.score = 100;
              MatchingDescriptionsData.testsLeft = 10;
              MatchingDescriptionsData.personDescriptors = personDescriptors;

              SceneManager.LoadScene("MatchingDescriptions");
              break;
          case 3: 
              SceneManager.LoadScene("ReligiousItems");
              break;
          case 4: 
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
            genderText = "Male";
            configurationText.text = genderText+"\nSelect Occupation";
        }
        else{
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
