using System.Collections.Generic;

public static class MatchingDescriptionsData
{


public class PersonDescriptor {
    public string age_range,gender, race, clothes_top,clothes_bottom, build,shoes,hair, description;
    
    public PersonDescriptor(string age_range,string gender,string race,string clothes_top,string clothes_bottom,string build,string shoes,string hair,string description) {
        this.age_range = age_range;
        this.gender = gender;
        this.race = race;
        this.clothes_top = clothes_top;
        this.clothes_bottom = clothes_bottom;
        this.build = build;
        this.shoes = shoes;
        this.description = description;
        this.hair = hair;
    }

    public PersonDescriptor() {
        this.age_range = "";
        this.gender = "";
        this.race = "";
        this.clothes_top = "";
        this.clothes_bottom = "";
        this.build = "";
        this.description = "A 25-30 year old IC1 slim male with blonde hair wearing a grey top, grey shorts and white trainers.";
        this.shoes = "";
        this.hair = "";
    }
}

    public static List <PersonDescriptor> personDescriptors;
    public static int score, testsLeft;
    public static PersonDescriptor currentPersonDescriptor;

    

   

 
}