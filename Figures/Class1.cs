using System.Runtime.CompilerServices;

namespace Figures
{
    public abstract class Figure
    {
        protected double S { get; set; }
        protected double P { get; set; }
        protected string description { get; set; }

        public double GetS()
        {
            return S;
        }
        public string GetDescription()
        {
            return description;
        }
    }
    public interface IFigure
    {
        protected void GetS();
    }

    public class Triangle : Figure, IFigure
    {
        private bool check;
        double sideA, sideB, sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB)
            {
                this.sideA = sideB;
                this.sideB = sideA;
            }
            else
            {
                this.sideA = sideA;
                this.sideB = sideB;
            }
            if (this.sideB > sideC)
            {
                this.sideC = this.sideB;
                this.sideB = sideC;
            }
            else
            {
                this.sideC = sideC;
            }
            check = CheckTriangle();
            GetP();
            GetS();
        }

        private void GetP()
        {
            P = (sideA + sideB + sideC) / 2;
        }
        public void GetS()
        {
            if (check)
            {
                S = Math.Sqrt(P * (P - sideA) * (P - sideB) * (P - sideC));
            }
            else
            {
                S = Math.Sqrt(P * (P - sideA) * (P - sideB));
            }
        }

        private bool CheckTriangle()
        {
            double check = Math.Pow(sideC, 2) - Math.Pow(sideA, 2) - Math.Pow(sideB, 2);
            if (check == 0)
            {
                description = "Прямоугольный треугольник";
                return true;
            }
            else
            {
                description = "Непрямоугольный треугольник";
                return false;
            }
        }
    }
    public class Circle : Figure, IFigure
    {
        int R;

        public void GetS()
        {
            S = Math.PI * Math.Pow(R, 2);
        }
    }
}