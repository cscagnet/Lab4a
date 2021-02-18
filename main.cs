using System;

class MainClass {
  public static void Main (string[] args) {


  int counter = 0;
  double total = 0;

  while (counter < 7)

  {
    int carnumber = counter + 1;

    Console.WriteLine ("Enter the distance covered by Car #" + carnumber);
    double distance = Convert.ToDouble(Console.ReadLine());
    
    
    Console.WriteLine ("Enter the time taken by Car #" + carnumber);
    double time = Convert.ToDouble(Console.ReadLine());
    

    double speed = distance / time;
    Console.WriteLine ("The speed of this car is " + speed + " miles per hour");
    total = total + speed;
    counter++;

    
  }

  double average = total / counter;
  Console.WriteLine ("The average speed of the cars is " + average + " miles per hour");
  
  }
}