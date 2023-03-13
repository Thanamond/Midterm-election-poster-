using System;

namespace midterm028
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double w1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double w2 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());

            double w_max = Math.Abs(x1-x2); //ด้านกว้างที่มากที่สุดที่จะไม่ชน
            double bas = w1 +w2;  //ระยะกว้างทั้งสองรูป

            double h_max = Math.Abs(y1-y2);  //ความสูงที่สุดที่รูปจะไม่ชน
            double height = h1 + h2;  //ระยะสูงรวมทั้งสองรูป

            if (bas <= w_max || height <= h_max) //ไม่ทับ
            {
                Console.WriteLine("No Overlapping");
            }
            if (bas > w_max)
            {
                double A_base = (bas - w_max); //ฐานที่ซ้อน
                if (height > h_max)
                {
                    double A_height = (height - h_max); //สูงที่ซ้อน
                    double area = A_base * A_height;  //พื้นที่รูปที่ซ้อน
                    if (area > 8)
                    {
                        Console.WriteLine("Too Much Overlaping");
                    }
                    else
                    {
                        Console.WriteLine("Not Much Overlapping");
                    }
                }
            }    
        }
    }
}