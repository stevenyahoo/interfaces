using Data;
using Data.Interfaces;

namespace BusinessLogic
{
    public class LCar : ICar 
    {
        public bool addCar(string marca, string modelo)
        {
            return true;
        }

        public List<string> carList()
        {
            throw new NotImplementedException();
        }
    }
}
