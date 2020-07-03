using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Car
{
    class CarFactory
    {
        public static Car getCar(String loaiXe, String maXe, String cauHinh, String nsx, string tinhNang)
        {
            if ("Honda".Equals(loaiXe))
                return new Honda(maXe, cauHinh, nsx, tinhNang);
            else if ("Nexus".Equals(loaiXe))
                return new Nexus(maXe, cauHinh, nsx, tinhNang);
            else if ("Toyota".Equals(loaiXe))
                return new Toyota(maXe, cauHinh, nsx, tinhNang);
            return null;
        }
    }
}
