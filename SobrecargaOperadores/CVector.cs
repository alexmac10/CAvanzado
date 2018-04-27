using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    class CVector : IComparable
    {
        private double miX;
        private double miY;
        private double miM;

        public CVector(double x, double y)
        {
            this.miX = x;
            this.miY = y;
            this.Magnitud();
        }

        public double X
        {
            get { return this.miX; }
            set { this.miX = value; }
        }

        public double Y
        {
            get { return this.miY; }
            set { this.miX = value; }
        }

        public double M
        {
            get { return this.miM; }
            set { this.miM = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("({0},{1}) m={2}", this.miX,this.miY, this.miM);
        }

        public void Magnitud()
        {
            this.miM = Math.Sqrt(this.miX * this.miX + this.miY * this.miY);
        }

        public override string ToString()
        {
            return string.Format("({0},{1}) m={2}", this.miX, this.miY, this.miM);
        }

        public int CompareTo(object obj)
        {
            if (obj is CVector)
            {
                CVector temp = (CVector)obj;

                if (this.miM > temp.M)
                {
                    return 1;
                }
                else if (this.miM <temp.M)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException("No se estan comparando objetos de tipo CVector");
            }
        }

        //Sobre carga de operador suma (+)
        public static CVector operator +(CVector v1, CVector v2)
        {
            double tempX = v1.X + v2.X;
            double tempY = v1.Y + v2.Y;
            return new CVector(tempX,tempY);
        }

        //Sobrecarga de operador suma (-)
        public static CVector operator -(CVector v1, CVector v2)
        {
            return new CVector(v1.X - v2.X, v1.Y - v2.Y);
        }

        //Sobrecarga de operador incremento (++)
        public static CVector operator ++(CVector v1)
        {
            return new CVector(v1.X + 1, v1.Y + 1);
        }

        //Sobrecarga de operador decremento(--)
        public static CVector operator --(CVector v1)
        {
            return new CVector(v1.X - 1, v1.Y - 1);
        }

        //Sobrecarga operador == y !=
        public override bool Equals(object obj)
        {
            if (obj is CVector)
            {
                CVector temp = (CVector)obj;
                if (miM == temp.M)
                {
                    return true;
                }
            }

            return false;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(CVector v1, CVector v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(CVector v1, CVector v2)
        {
            return !(v1.Equals(v2));
        }


        //Sobrecarga de < y >
        public static bool operator <(CVector v1, CVector v2)
        {
            if (v1.CompareTo(v2) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(CVector v1, CVector v2)
        {
            if (v1.CompareTo(v2) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
