using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP_Code_Starter
{

    public class City
    {
        public int CityName { get; set; }
        public int X { get; set; }
        public int Y {get; set;}


    }

    public class CityList
    {
        private volatile static CityList _uniqueInstance;
        private static readonly object _syncLock = new object();
        static Random _random = new Random();
        private int _NumberOfCities;
        private int _MaxX;
        private int _MaxY;
        public City[] Cities;

        private CityList(int pNumberOfCities, int pMaxX, int pMaxY, bool pCircle)
        {
            _NumberOfCities = pNumberOfCities;
            _MaxX = pMaxX;
            _MaxY = pMaxY;
            Cities = new City[_NumberOfCities];

            if (pCircle == false)
            {


                for (int i = 0; i < _NumberOfCities; i++)
                {
                    City TempCity = new City();
                    TempCity.CityName = i + 1;
                    TempCity.X = _random.Next(0, _MaxX + 1);
                    TempCity.Y = _random.Next(50, _MaxY + 1);
                    Cities[i] = TempCity;
                }

            }
            else
            {
                // We're not going for a "perfect circle here" We're going for cities that are mostly in a circle
                //The circle's drawing will be centered on point (1100,500) and all cities must be 400 points from there
                //because I used an offset of 600 on the X-axis when drawing, I will correct for that here. Thus, all cities centre around (500,500)
                //We'll use pythagoras to calculate Y once X has been generated. Angles will be more elegant but we don't want to use "real" math

                for (int i = 0; i < _NumberOfCities; i++)
                {
                    int LengthX = 0;

                    City TempCity = new City();
                    TempCity.CityName = i + 1;
                    TempCity.X = _random.Next(100, 900);
                    LengthX = Math.Abs(TempCity.X - 500);
                    if (_random.Next(0, 2) == 0)
                    {
                        //Draw Y above point 1100,500
                        TempCity.Y = 500 - (int)Math.Sqrt(160000 - LengthX * LengthX);
                    }
                    else
                    {
                        TempCity.Y = 500 + (int)Math.Sqrt(160000 - LengthX * LengthX);
                    }
                    Cities[i] = TempCity;
                }
            }
        }

        public static CityList getInstance(int NumberOfCities, int MaxX, int MaxY, bool Circle)
        {           


            if (_uniqueInstance == null)
            {
                // Lock area where instance is created
                lock (_syncLock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new CityList(NumberOfCities, MaxX, MaxY , Circle);

                    }
                }
            }
            return _uniqueInstance;
        }


    }

    public class Genome
    {// In this case a genome is a route 
        public City[] Cities;
        static Random _random = new Random();
        public double distance;
        public double fitness;


        public Genome(int NumberOfCities, int MaxX, int MaxY, bool Circle)
        {
            Cities = new City[NumberOfCities]; 
            CityList TheMasterList = CityList.getInstance(NumberOfCities,MaxX,MaxY,Circle);

            for (int i = 0; i < NumberOfCities ; i++)
            {
               City TempCity = new City();
                TempCity.CityName = TheMasterList.Cities[i].CityName;
                TempCity.X = TheMasterList.Cities[i].X;
                TempCity.Y = TheMasterList.Cities[i].Y;
                Cities[i] = TempCity; 
            }

           Shuffle(NumberOfCities); 

        }

        public Genome(Genome fittest, int numOfCities)
        {
            Cities = new City[numOfCities];
            fitness = fittest.fitness;
            distance = fittest.distance;
            for (int i = 0; i <= fittest.Cities.GetUpperBound(0); i++)
            {
                Cities[i] = fittest.Cities[i];
            }
        }
        private void Shuffle(int NumberOfCities)
        {
            for (int i = 0; i < NumberOfCities ; i++)
            {
                Swap(_random.Next(0,NumberOfCities),_random.Next(0,NumberOfCities));
                
            }

        }

        private void Swap(int PosX, int PosY)
        {
            City temp = Cities[PosX];
            Cities[PosX] = Cities[PosY];
            Cities[PosY] = temp;
        }
           
        }


    }

