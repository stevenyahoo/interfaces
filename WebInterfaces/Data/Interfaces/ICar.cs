using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ICar
    {
       bool addCar(string marca, string modelo);

        List<string> carList(); 

    }
}
