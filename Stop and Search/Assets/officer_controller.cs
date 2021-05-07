using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
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
    public Sound[] sounds;

    [System.Serializable]
    public class Sound{
        public string name;
        public AudioClip clip;
        public AudioSource source;
    };
    
    private void Awake(){
         animator = GetComponentInChildren<Animator>();

         foreach (Sound s in sounds){
             s.source = gameObject.AddComponent<AudioSource>();
             s.source.clip = s.clip;
         }
         
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
            timeInSequence = 5.7f;
            gameTextObject.SetActive(false);
            sequenceNumber =1;
            sounds[0].source.Play();
        }
            
            break;
            case 1:
            animator.Play("Walking");
            transform.position += transform.forward * Time.deltaTime * 2.0f;
            if(timeInSequence<=0){
                sequenceNumber = 2;
                sounds[1].source.Play();
            }
            break;
            case 2:
            
            
            if (!sounds[1].source.isPlaying)
        {
            animator.Play("Idle");
            
            gameText.text = "The officer must introduce himself with his name before explaining "+
	                        "what is going on to you ";
	                        
            gameTextObject.SetActive(true);
              if (Input.anyKey)
        {
            gameTextObject.SetActive(false);
            sequenceNumber =3;
            sounds[2].source.Play();
            
        }
        }
        else{
            animator.Play("Talking");
        }

        
            
            break;
            case 3:
            
           if (!sounds[2].source.isPlaying)
        {
            animator.Play("Idle");
            
            gameText.text = "The officer must state their police station to you. You should  "+
	                        "remember this information as it can be used to file a report "+
                            "on the officer in the case of any misconduct.";
	                        
            gameTextObject.SetActive(true);
              if (Input.anyKey)
        {
            gameTextObject.SetActive(false);
            sequenceNumber =4;
            sounds[3].source.Play();
            
        }
        }
        else{
            animator.Play("Talking");
        }

        
            break;
            case 4:
              if (!sounds[3].source.isPlaying)
        {
            animator.Play("Idle");
            
            gameText.text = "he officer must tell you why they are stopping you and what they "+
	                        "are looking for. If they don't then this is misconduct and you  "+
                            "can report them to their police station.";
	                        
            gameTextObject.SetActive(true);
              if (Input.anyKey)
        {
            gameTextObject.SetActive(false);
            sequenceNumber =5;
            sounds[4].source.Play();
            
        }
        }
        else{
            animator.Play("Talking");
        }
            break;
            case 5:
            
             if (!sounds[4].source.isPlaying)
        {
            if(timeInSequence<=0){

            animator.Play("Idle");
            gameText.text = "Once an officer has searched you, you are entitled to a copy of the "+
	                        "search record. A search record is a record that officers keep of "+
                            "what actions they performed. You can use this to qoute what was done if you decide to file a report";
	                        
            gameTextObject.SetActive(true);
              if (Input.anyKey)
        {
            gameTextObject.SetActive(false);
            sequenceNumber =6;
            sounds[5].source.Play();
            
        }
            }
            else{
animator.Play("Petting"); // make officer perform stom routine
            }
            
            
            
        }
        else{
            animator.Play("Talking");
            timeInSequence = 10.0f;
        }
            break;
            case 6:
            gameText.text = "This concludes your stop and search experience";
	                       
	                        
            gameTextObject.SetActive(true);
                  if (Input.anyKey)
        {
            gameTextObject.SetActive(false);
            //end scene
            
        }
            break;
            case 7:
            break;
            default:
            break;
            


        }
        
        


        
    }
}
