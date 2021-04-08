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

    /*
    scenario codes
    
    */
    


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
