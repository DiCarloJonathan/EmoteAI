using System;


namespace  EmotionEnums
{
public enum Fear
{
    none = 0,
    apprehention = 1,
    fear = 2,
    terror = 3, 
    overpowering = 4
}
public enum Surprise
{
    none = 0,
    distraction = 1,
    surprise = 2,
    amazement = 3, 
    overpowering = 4
}
public enum Sadness
{
    none = 0,
    pensivness = 1,
    sadness = 2,
    grief = 3, 
    overpowering = 4
}
public enum Disgust
{
    none = 0,
    boredom = 1,
    disgust = 2,
    loathing = 3, 
    overpowering = 4
}
public enum Anger
{
    none = 0,
    annoyance = 1,
    anger = 2,
    rage = 3, 
    overpowering = 4
}
public enum Anticipation
{
    none = 0,
    interest = 1,
    anticipation = 2,
    vigilance = 3, 
    overpowering = 4
}
public enum Joy
{
    none = 0,
    serenity = 1,
    joy = 2,
    ecstasy = 3, 
    overpowering = 4
}
public enum Trust
{
    none = 0,
    acceptance = 1,
    trust = 2,
    admiration = 3, 
    overpowering = 4
}

public class FeelingTowardEntity
{
    public List<Enums> EmoteMatrix { get; set; }
    int Fear_lv { get; set; }
    int Surprise_lv { get; set; }
    int Sadness_lv { get; set; } 
    int Disgust_lv { get; set; }
    int Anger_lv { get; set; }
    int Anticipation_lv { get; set; }
    int Joy_lv { get; set; },
    int Trust_lv { get; set; }

    public void AlterFeelingTowardEntity(int fear_lv_delta, int surprise_lv_delta, int sadness_lv_delta, int disgust_lv_delta, int anger_lv_delta, int anticipation_lv_delta, int joy_lv_delta, int trust_lv_delta)
    {
      
      
      amsdjasd

        EmoteMatrix = new List<Enum>()
        {
            (Fear)fearLV, (Surprise)surpriseLV, (Sadness)sadnessLV, (Disgust)disgustLV, (Anger)angerLV, (Anticipation)anticipationLV, (Joy)joyLV, (Trust)trustLV
        };
        hhkk
    }

    
    



}


}