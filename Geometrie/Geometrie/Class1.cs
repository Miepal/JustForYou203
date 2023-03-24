using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Geometrie
{
    public class modulGeometrie
    {
        //calculating circle with radius-value
        public double CalcCircle(double radius, double circumference, double surfaceArea)
        {
            //getting values for calculating
            radius = double.Parse(Console.ReadLine());

            //calculating circumference of circle
            circumference = 2 * Math.PI * radius;

            //calculating surfaceArea of circle
            surfaceArea = Math.PI * Math.Pow(radius, 2);

            //returning values
            return circumference + surfaceArea;
        }

        //???????????????????????????????????????????????????????????????????????????????????
        //public List<double> calcCircle(List<double> input)
        //{
        //    //getting values for calculating
        //    double radius = input[0];

        //    List<double> output = new List<double> { 2 * Math.PI * radius, Math.PI * Math.Pow(radius, 2) };
        //    return output;
        //}




        //calculating triangle with sides, baseLength and height
        public double CalcTriangle(double side1, double side2, double side3, double perimeter, double baseLength, double height, double surfaceArea)
        {
            //getting values for calculating
            side1 = double.Parse(Console.ReadLine());
            side2 = double.Parse(Console.ReadLine());
            side3 = double.Parse(Console.ReadLine());
            baseLength = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            //calculating perimeter of triangle
            perimeter = side1 + side2 + side3;

            //calculating surfaceArea of triangle
            surfaceArea = 0.5 * baseLength * height;

            //returning values
            return perimeter + surfaceArea;
        }

        //????????????????????????????????????????????????????????????????????????????????????????????
        //public List<double> calcTriangle(List<double> input)
        //{
        //    double side1 = input[0];
        //    double side2 = input[1];
        //    double side3 = input[2];
        //    double baseLength = input[3];
        //    double height = input[4];

        //    List<double> output = new List<double> { side1 + side2 + side3, 0.5 * baseLength * height };
        //    return output;
        //}

        //calculating parallelogram with baseLength and height
        public double CalcParallelogram(double baseLength, double height, double perimeter, double surfaceArea)
        {
            //getting values for calculating
            baseLength = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            //calculating perimeter of parallelogram
            perimeter = 2 * (baseLength + height);

            //calculating surfaceArea of parallelogram
            surfaceArea = baseLength * height;

            //returning values
            return perimeter + surfaceArea;
        }

        //?????????????????????????????????????????????????????????????????????????????
        //public List<double> calcParallelogram(List<double> input)
        //{
        //    double baseLength = input[0];
        //    double height = input[1];

        //    List<double> output = new List<double> { 2 * (baseLength + height), baseLength * height };
        //    return output;
        //}

    }
}