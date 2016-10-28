using System;
public class Game{

    public Game(){
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
    }

    //Runs at the start of the game
    public void Start (){
        Console.WriteLine("Please type in your name:");        
        name = Console.ReadLine();
        Console.WriteLine("Your player name is " + name);
        while(Program.canPlay){
            Walk();
        }
        Console.WriteLine("You died.");
    }

    private void Walk(){
        Random randomNum = new Random();
        Cave.Enter();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }

    //Game Levels
    private LevelBase Cave = new LevelBase();
    
    //Game power ups
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

    //Game weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();

    public string name;
    private int score;
}
        /*
        After prompt the game for a name we:
        Enter a cave
        find Health.
        Meet a dragon. (need an enemy class)
        Pick weapon.
        Battle dragon. (Battle class)
        If we win: get Health and ammo.
        If dragon wins: loose Health.
        */