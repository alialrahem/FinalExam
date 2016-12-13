
namespace ConsoleApplication29
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double MaxWeight)
        {
            this.MaxWeight = MaxWeight;
            this.Occupants = new Passenger[maxOccupants];
        }//.........   constructor method  and create meomry for arry Occupants ........   //

        public void AddOccupant(Passenger passenger,int index)
        {
            this.Occupants[index]=passenger;

        }//.........  set public method 1 which is void..........//
        public double GetCurrentWeight()
        {
            double currentWeight = 0;

            for(int i=0; i<Occupants.Length; i++)
            {
                currentWeight += this.Occupants[i].GetWeigth();

            }
            return currentWeight;
        }//......... set public method 2 which is double........//

        public bool IsOverMaxCapacity()
        {
            return this.GetCurrentWeight() > this.MaxWeight;
        }//.........set public methode 3 which bool...........//

      }
  }

