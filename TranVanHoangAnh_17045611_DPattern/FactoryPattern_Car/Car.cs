using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Car
{
    public abstract class Car
    {
        public abstract string getMaXe();
        public abstract string getCauHinhXe();
        public abstract string getNhaSanXuat();
        public abstract string getTinhNangKyThuat();
        
        public string toString()
        {
            return "Ma xe: "+this.getMaXe() + "\nCau hinh xe: " + this.getCauHinhXe() + "\nNha san xuat: "+this.getNhaSanXuat() +"\nTinh nang ky thuat: "+this.getTinhNangKyThuat()+"\n";
        }
    }
}
