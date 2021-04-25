using System.Collections.Generic;

public static class MatchingDescriptionsData
{


public class PersonDescriptor {
    public string age_range,gender, race, clothes_top,clothes_bottom, build, description;
    
    public PersonDescriptor(string age_range,string gender,string race,string clothes_top,string clothes_bottom,string build,string description) {
        this.age_range = age_range;
        this.gender = gender;
        this.race = race;
        this.clothes_top = clothes_top;
        this.clothes_bottom = clothes_bottom;
        this.build = build;
        this.description = description;
    }

    public PersonDescriptor() {
        this.age_range = "";
        this.gender = "";
        this.race = "";
        this.clothes_top = "";
        this.clothes_bottom = "";
        this.build = "";
        this.description = "it was a rando";
    }
}

    public static List <PersonDescriptor> personDescriptors;
    public static int score, testsLeft;
    public static PersonDescriptor currentPersonDescriptor;

    

   

 
}