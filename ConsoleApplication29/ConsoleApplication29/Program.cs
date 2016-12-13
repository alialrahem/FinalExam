
namespace ConsoleApplication29

{  
            // +=======================================+ //
            // + Course: IT 1050                       +
            // + Date: 12/13/2016                      +
            // + Assignment: Final Exam                +
            // + Name: ALi ALrahem                     +
            // +=======================================+ //
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elvator1 = new Elevator(2, 400); // .......... new elvater1...........//

            Passenger A1 = new Passenger("A1", 180); // ........... new passanger A1.......//
            elvator1.AddOccupant(A1, 0);             // ............Add passanger A1 to index 0.......//

            elvator1.AddOccupant(new Passenger("A2", 220), 1); //............create new passenger A2 and set value to elvater1 ...........//

            bool elevator11IsOverCapacity = elvator1.IsOverMaxCapacity();

            Elevator elvator2 = new Elevator(3, 600); //............new elvater2.............//

            elvator2.AddOccupant(new Passenger("A1",200),0);  //............new passenger & add values to elvater2....// 
            elvator2.AddOccupant(new Passenger("A2", 200), 1);  //..........new passenger & add values to elvater2 ...//   
            elvator2.AddOccupant(new Passenger("A3", 201), 2); //...........new passenger & add values to elvater2....//

            bool elevator2IsOverCapacity = elvator2.IsOverMaxCapacity();
   
 


            



        }
         
    }
}
