
namespace ConsoleApplication29
{
    class Passenger
    {
        private string Name;
        private double Weigth;

        public Passenger(string Name,double Weigth)
        {
            this.Name = Name;
            this.Weigth = Weigth;
        } //.........   constructor method ........   //

        public string GetName()
        {

            return this.Name;
        } //............ public method to set Name...........//
        
        public double GetWeigth()
        {

            return this.Weigth;
        } //...........public methode to set GetWeigth.........//
    }
}
