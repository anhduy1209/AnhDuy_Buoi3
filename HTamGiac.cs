using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class HTamGiac
    {
        private float ma;

        public float Ma
        {
            get { return ma; }
            set 
            {
                if (ma > 0)
                {
                    ma = value; 
                }
            }
        }

        private float mb;

        public float Mb
        {
            get { return mb; }
            set 
            {
                if (mb > 0)
                {
                    mb = value;
                }
            }
        }
        private float mc;

        public float Mc
        {
            get { return mc; }
            set 
            {
                if (mc > 0)
                {
                    mc = value;
                }
            }
        }

        public HTamGiac()
        {
            ma = 1;
            mb = 1;
            mc = 1;
        }
        public HTamGiac(float ma,float mb,float mc)
        {
            if (ma <= 0 || mb <=0 || mc<=0 || ma+mb<=mc || ma+mc<=mb||mb+mc<=ma)
            {
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }
            else
            {
                this.ma = ma;
                this.mb = mb;
                this.mc = mc;
            }
        }
        public double ChuVi()
        {
            return ma + mb + mc;
        }
        public double DienTich()
        {
            return 0.25*(Math.Sqrt((ma+mb+mc)*(ma+mb-mc)*(mb+mc-ma)*(mc+ma-mb)));
        }
        public string TTTamGiac()
        {
            if (ma == 0 && mb ==0 && mc ==0)
            {
                return "Khong phai tam giac!";
            }
            
            else if ((ma == mb && ma != mc ) || (ma == mc && ma != mb ) || (mc == mb && mc != ma ))
            {
                return "Tam giac can!";
            }
            else if ((ma == mb && ma == mc) || (ma == mc && ma == mb) || (mc == mb && mc == ma))
            {
                return "Tam giac deu!";
            }
            else
            {
                return "Tam giac thuong!";
            }
            
                
        }
        public void Xuat()
        {
            Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5:N2}",ma,mb,mc,TTTamGiac(),ChuVi(),DienTich());
        }
    }
}
