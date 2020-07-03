using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Car
{
    public class Honda : Car
    {
        private string maXe;
        private string cauHinh;
        private string nsx;
        private string tinhNang;

        public Honda(string maXe, string cauHinh, string nsx, string tinhNang)
        {
            this.maXe = maXe;
            this.cauHinh = cauHinh;
            this.nsx = nsx;
            this.tinhNang = tinhNang;
        }

        public override string getMaXe()
        {
            return this.maXe;
        }

        public override string getCauHinhXe()
        {
            return this.cauHinh;
        }

        public override string getNhaSanXuat()
        {
            return this.nsx;
        }

        public override string getTinhNangKyThuat()
        {
            return this.tinhNang;
        }
    }
}
