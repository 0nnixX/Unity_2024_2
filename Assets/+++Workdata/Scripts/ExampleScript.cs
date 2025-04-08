using UnityEngine;

public class ExampleSccript : MonoBehaviour
{
    private bool myFirstBoolean;
    private int myFirstInteger;
    private int mySecondInteger;
    private int counter = 0;
    private string myFirstString;
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(message: "Das Program ist gestartet");
        
        myFirstBoolean = true;
        myFirstInteger = 8;
        mySecondInteger = 5;
        myFirstString = "Hello";

        int result= myFirstInteger + mySecondInteger;
        
        
        Debug.Log(message: "myFirstBool is:" + myFirstBoolean);
        Debug.Log(message: "myFirstInteger is:" + myFirstInteger);
        Debug.Log(message: "myFirstString is:" + myFirstString);
        
        Debug.Log(message:"int1 + int2 = " + result);

        //result = result + 1;
        result++;
        //result += 1;
        
        Debug.Log("result + 1 =" + result);

       //MyFirstFunction(); //hier rufen wir unsre erste eigene Function auf
        //es geht erst weiter, wenn die Function komplett abgeschlossen wurde
        
        
            
        Debug.Log(message: "Start ist zu Ende");    
    }


// Update is called once per frame
    void Update()
    {
        
        Debug.Log(message: "Das Program läuft");

        counter++;
        Debug.Log(message: "counter = " + counter);
    }
    
    
    //unsere erste Funktion
    //Namen können wir frei aussuchen-sollte aber natürlich irgendwie die Funktion beschreiben
    //Funktion werden groß geschrieben
    
    //public, wenn sie von anderen Scripten oder z.B. von Buttons verwendet werden sollten
     public void MyFirstFunction() 
    {
        Debug.Log(message: "Meine Function wurde aufgerufen!");
    }

}
