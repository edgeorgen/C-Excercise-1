// See https://aka.ms/new-console-template for more inform
using System;

Console.WriteLine("Enter your Arrowhead type:");
string arrowhead = Console.ReadLine();
Console.WriteLine("Enter your fletching type:");
string fletching = Console.ReadLine();
Console.WriteLine("Enter Arrow Length;");
double dlength = Convert.ToDouble(Console.ReadLine());
float length = (float)dlength;

Arrow first = new Arrow(arrowhead, fletching, length);
Console.WriteLine(first.GetCost());
class Arrow
{
    public string arrowhead;
    public string fletching;
    public float length;

    public Arrow(string arrowhead, string fletching, float length)
    {
        this.arrowhead = arrowhead;
        this.fletching = fletching;
        this.length = length;       
    }

    public float GetCost(){
        int arrowheadCost;
        int fletchCost;
        float lengthCost;

        if(arrowhead == "Steel")
        {
            arrowheadCost = 10;
        }
        else if(arrowhead == "Obsidian"){
            arrowheadCost = 5;
        }
        else if (arrowhead == "Wood")
        {
            arrowheadCost = 3;
        }
        else
        {
            arrowheadCost = 0;
        }

        if(fletching == "Plastic")
        {
            fletchCost = 10;
        }
        else if (fletching == "Goose Feathers")
        {
            fletchCost = 3;
        }
        else if (fletching == "Turkey Feathers")
        {
            fletchCost = 5;
        }
        else
        {
            fletchCost = 0;
        }

        lengthCost = length * (float).05;

        return arrowheadCost + lengthCost + fletchCost;
    }

}
