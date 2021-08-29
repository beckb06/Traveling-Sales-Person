using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TSP_Code_Starter
{

    #region CrossOver
    public interface ICrossOver
    {
        void CrossOver( ref Genome Parent1, ref Genome Parent2, int _numberofCities);
       
    }

    public class SimpleCrossOver : ICrossOver
    {
        static Random _random = new Random();
        int start = 0;
        int end = 0;


        public void CrossOver(ref Genome Parent1, ref Genome Parent2, int _numberofCities)
        {

            //based on a PMX but my own simpler version, hence SimpleCrossOver
            start = _random.Next(0, _numberofCities);
            end = _random.Next(start, _numberofCities);

            int CrossPoint = 0;
            //Cross parent1, at the random point
            for (int i = start; i <= end; i++)
            {
                CrossPoint = _random.Next(0, _numberofCities);
                City Temp = Parent1.Cities[CrossPoint];
                Parent1.Cities[CrossPoint] = Parent1.Cities[CrossPoint];
                Parent1.Cities[CrossPoint] = Temp;

            }
            //Cross parent2, at the random point
            for (int i = start; i <= end; i++)
            {
                CrossPoint = _random.Next(0, _numberofCities);
                City Temp = Parent2.Cities[CrossPoint];
                Parent2.Cities[CrossPoint] = Parent2.Cities[CrossPoint];
                Parent2.Cities[CrossPoint] = Temp;
               



            }
            
        }

    }


    public class OrderCrossover : ICrossOver
    {
        static Random _random = new Random();
       
        
        
        int Pos = 0;
       //HashTables make storing and searching for parents alot easier
        Hashtable ParentHash1 = new Hashtable();
        Hashtable ParentHash2 = new Hashtable();

        public void CrossOver(ref Genome Parent1, ref Genome Parent2, int _numberofCities)
        {
            Pos = _random.Next(0, _numberofCities);

           
            int Point = Pos + 1;

            if (Point >= _numberofCities)
            {
                Point = 0;
            }
            for (int i = Pos; i < _numberofCities; i++)
            {
                //Checks to make sure the Parent isnt in the hashtable
                if (ParentHash1.Contains(Parent2.Cities[i].CityName) != true)
                {
                    //swaps cities at the point and increments from pos to number of cities
                    Parent1.Cities[Point].CityName = Parent2.Cities[i].CityName;
                    ParentHash1.Add(Parent2.Cities[i].CityName, null);

                    Point += 1;

                    //Checks whether the point is not at the end, and starts back at 0 if it is
                    if (Point == _numberofCities)
                    {
                        Point = 0;
                    }
                }
  
            }
            //takes the stored Parent1 and moves it to the start of the array
            for (int i = 0; i < Pos; i++)
            {
                if (ParentHash1.Contains(Parent2.Cities[i].CityName) != true)
                {
                    Parent1.Cities[Point].CityName = Parent2.Cities[i].CityName;
                    ParentHash1.Add(Parent2.Cities[i].CityName, null);

                    Point += 1;
                    if (Point == _numberofCities)
                    {
                        Point = 0;
                    }
                }

            }
            Point = Pos + 1;

            if (Point > _numberofCities)
            {
                Point = 0;
            }
            for (int i = Pos; i < _numberofCities; i++)
            {
                if (ParentHash2.Contains(Parent1.Cities[i].CityName) != true)
                {
                    Parent2.Cities[Point].CityName = Parent1.Cities[i].CityName;
                    ParentHash2.Add(Parent1.Cities[i].CityName, null);

                    Point += 1;
                    if (Point == _numberofCities)
                    {
                        Point = 0;
                    }
                }

            }
            for (int i = 0; i < Pos; i++)
            {
                if (ParentHash2.Contains(Parent1.Cities[i].CityName) != true)
                {
                    Parent2.Cities[Point].CityName = Parent1.Cities[i].CityName;
                    ParentHash2.Add(Parent1.Cities[i].CityName, null);

                    Point += 1;
                    if (Point == _numberofCities)
                    {
                        Point = 0;
                    }
                }
            }
            

           
        }
    }

   
    public class PMX : ICrossOver
    {
        static Random _random = new Random();
        int start = 0;
        int end = 0;

        //This is based on the PMX that was done in class
        void Swap(ref Genome Current, int Pos1, int Pos2)
        {
            City Temp = Current.Cities[Pos1];
            Current.Cities[Pos1] = Current.Cities[Pos2];
            Current.Cities[Pos2] = Temp;

        }
        int Find(ref Genome Current)
        {
            
            for (int i = 0; i < Current.Cities.Length; i++)
            {
                if (Current.Cities[i].CityName == i)
                {

                    return i;
                }

            }

            return 0;
        }
        public void CrossOver(ref Genome Parent1, ref Genome Parent2, int _numberofCities)
        {
            start = _random.Next(0, _numberofCities);
            end = _random.Next(start, _numberofCities);


            for (int i = start; i <= end; i++)
            {
                
                int Pos1 = Find(ref Parent1);
                int Pos2 = Find(ref Parent1);
                Swap(ref Parent1, Pos1, Pos2);
                Pos1 = Find(ref Parent2);
                Pos2 = Find(ref Parent2);
                Swap(ref Parent2, Pos1, Pos2);



            }
        }
    }
    #endregion

    #region Mutation
    public interface IMutator
    {
        
        void Mutate(ref Genome Parent1, int MutationRate, int _numberofCities);
        
    }

    public class SimpleMutate : IMutator
    {
       
        static Random _random = new Random();
        static int count = 0;

        public void Mutate(ref Genome Parent1, int MutationRate, int _numberofCities)
        {

            int MutateCheck = _random.Next(0, MutationRate + 1);
           

            if (MutateCheck == MutationRate)
            {

                int MutatePoint = _random.Next(0, _numberofCities);
                int MutatePoint2 = _random.Next(0, _numberofCities);

                City tempCity = Parent1.Cities[MutatePoint];
                Parent1.Cities[MutatePoint] = Parent1.Cities[MutatePoint2];
                Parent1.Cities[MutatePoint2] = tempCity;
            }
            count++;
           

        }
    }


    public class ReverseMutate : IMutator
    {
        static Random _random = new Random();

        public void Mutate(ref Genome Parent1, int MutationRate, int _numberofCities)
        {
            int MutateCheck = _random.Next(0, MutationRate + 1);
            

            if (MutateCheck == MutationRate)
            {
                int Length = 0;
                int Point = 0;
                City[] tempCity;


                int Pos1 = _random.Next(0, _numberofCities / 2);
                int Pos2 = _random.Next(Pos1 + 1, _numberofCities);
                Length = Pos2 - Pos1;

                tempCity = new City[Length];
                for (int i = Pos1; i < Pos2; i++)
                {
                    tempCity[Point] = Parent1.Cities[i];
                    Point++;
                }

                Point--;
                for (int i = Pos1; i < Pos2; i++)
                {
                    Parent1.Cities[i] = tempCity[Point];
                    Point--;
                }
            }
        }
    }
        
    

    public class DisplacementMutate : IMutator
    {

        static Random _random = new Random();
        int Pos = 0;       
        int iTemp = 0;
        int Length = 0;
        int count = 0;

        //Very inificient mutate but it does work if the code is stepped through
        public void Mutate(ref Genome Parent1, int MutationRate, int _numberofCities)
        {
             int MutateCheck = _random.Next(0, MutationRate + 1);
           

             if (MutateCheck == MutationRate)
             {
                 //I set it 5 as default because the higher the number, the more inificient it becomes
                 Length = 5;
                 int[] temp1 = new int[Length];
                 int[] temp2 = new int[Length];

                 Pos = _random.Next(0, _numberofCities / 2);



                 int Point = Pos + Length;

                 //if point + length is higher than numberOfcities then it will run over and create an error, so I set it back to  0
                 if (Point + Length >= _numberofCities)
                 {
                     Pos = 0;
                     Point = Pos + Length;
                 }
                 
                 iTemp = Point;
                 
                 for (int i = Pos; i < Point; i++)
                 {
                     temp1[count] = Parent1.Cities[i].CityName;

                     Parent1.Cities[i].CityName = Parent1.Cities[iTemp].CityName;
                     count++;
                     iTemp++;
                 }
                 count = 0;
                 for (int i = Point; i < Point + Length; i++)
                 {

                     Parent1.Cities[i].CityName = temp1[count];
                     count++;
                     
                 }
                 count = 0;
                
             }

        }
    }

    public class Insertion : IMutator
    {

        static Random _random = new Random();
        
        public void Mutate(ref Genome Parent1, int MutationRate, int _numberofCities)
        {


            int MutateCheck = _random.Next(0, MutationRate + 1);

           
            if (MutateCheck == MutationRate)
            {
                List<City> ParentTemp = new List<City>();
                int Point = _random.Next(1, _numberofCities);
                int Insert = _random.Next(1, _numberofCities);
                
                for(int i = 0; i < _numberofCities; i++)
                {
                    ParentTemp.Add(Parent1.Cities[i]);
                }
                //removes the chosen point from Temp
                ParentTemp.RemoveAt(Point);
                // inserts it back into the list at the next chosen point
                ParentTemp.Insert(Insert, Parent1.Cities[Point]);

                //parent1 is then loaded again with the new temp
                for (int i = 0; i < _numberofCities; i++)
                {
                    Parent1.Cities[i] = ParentTemp[i];
                }
                
            }
            
   
        }
    }
                  

    #endregion

    #region Select
   
    public interface ISelect
    {
        Genome Select(Genome[] Pop, double fitness);
        
    }

    public class RouletteWheelSelect : ISelect
    {
        static Random random = new Random();

        // simple rouletteWheelSelect
        public Genome Select(Genome[] Population, double fitness)
        {
            double SelectedValue = random.NextDouble() * fitness;
            double CurrentValue = Population[0].fitness;
            int CurrentPosition = 0;
            while (CurrentValue < SelectedValue)
            {
                CurrentPosition++;
                CurrentValue += Population[CurrentPosition].fitness;
            }

            return Population[CurrentPosition];
        }


    }
    public class RankSelect : ISelect
    {

        static Random rand = new Random();

        public Genome Select(Genome[] Population, double fitness)
        {
            List<Genome> population = new List<Genome>();
            List<Genome> sortedPopulation = new List<Genome>();
            //fills the population list with the Population array
            for (int i = 0; i <= Population.GetUpperBound(0); i++)
            {
                population.Add(Population[i]);
            }
            //sorts the list into the new list sortedPopulation
            sortedPopulation = population.OrderBy(genome => genome.fitness).ToList();

            //a random point is chosen where the parent will be selected
            int Point = rand.Next(0, sortedPopulation.Count);

            return sortedPopulation[Point];
        }
    }
    


    
    public class TournamentSelect : ISelect
    {
        static Random random = new Random();
        public Genome Select(Genome[] Population, double fitness)
        {
            int best = 0;
            for (int i = 1; i < 2; i++)
            {
                int Point = random.Next(1, Population.GetUpperBound(0));
                //if best is 0 or fitness is better than the previous best
                if (best == 0 || Population[Point].fitness > Population[best].fitness)
                {
                    //new best gest saved
                    best = Point;
                }

            }
            return Population[best];
        }


    }



    #endregion




    class GA
    {
        public Genome CurrentFittest;
        public int _NumberOfCities;
        public bool _CircleOfCities = false;
        // For now I hardcoded these to work with my display. However, they can easily be changed if you want to rewrite the display logic
        public int _MaxX = 900;
        public int _MaxY = 800;
        public int _PopulationSize;

        public Genome[] Population;
        public double _TotalFitness = 0;
        public int _CrossOverRate = 80;
        public int _MutationRate;
        public int _GenerationCounter = 0;
        ICrossOver _CrossOver;
        IMutator _Mutaror;
        ISelect _Select;
        static Random _random = new Random();

        public bool Elitism;
        public int EliteAmount = 0;

        
      


        public GA(int NumberOfCities, int PopulationSize, int MutateRate, ICrossOver CrossOver, IMutator Mutator, bool CircleOfCities, ISelect Select, bool elitism, int eliteAmount)
        {
            _CrossOver = CrossOver;
            _Mutaror = Mutator;
            _NumberOfCities = NumberOfCities;
            _PopulationSize = PopulationSize;
            _CrossOver = CrossOver;
            _Mutaror = Mutator;
            _Select = Select;
            _MutationRate = MutateRate;
                
            _CircleOfCities = CircleOfCities;
            Elitism = elitism;
            EliteAmount = eliteAmount;
            CreatePopulation();
        }


        public void CreatePopulation()
        {

           
            Population = new Genome[_PopulationSize];
            for (int i = 0; i < _PopulationSize; i++)
            {

                Genome TempGenome = new Genome(_NumberOfCities, _MaxX, _MaxY, _CircleOfCities);
                Population[i] = TempGenome;

            }

            
            calcFitness();
        }

        public void NextGen()
        {
            Genome[] nextgen = new Genome[_PopulationSize];

            if (Elitism)
            {
                for (int i = 0; i < EliteAmount; i++)
                {
                    nextgen[i] = CurrentFittest;
                }
            }
            for (int i = EliteAmount; i < _PopulationSize; i++)
            {
                Genome Parent1 = _Select.Select(Population, _TotalFitness);
                Genome Parent2 = _Select.Select(Population, _TotalFitness);
                _CrossOver.CrossOver(ref Parent1, ref Parent2, _NumberOfCities);
                _Mutaror.Mutate(ref Parent1, _MutationRate, _NumberOfCities);
                nextgen[i] = Parent1;

            }
            //copying the nextgen over the new population
            for (int i = 0; i < _PopulationSize; i++)
            {

                Population[i] = nextgen[i];
            }

           calcFitness();

        }

        public void calcFitness()
        {
            
            double current = 0;
            double totalPopulationDistance = 0;
            double longestDistance = 0;
            _TotalFitness = 0;
            
           



            for (int i = 0; i < Population.Length; i++)
            {
                current = 0;
                for (int j = 1; j <= Population[j].Cities.GetUpperBound(0); j++)
                {
                    //Adding the distance between all the cities to get the total distance
                    current += Math.Sqrt(Math.Pow(Math.Abs((double)(Population[i].Cities[j - 1].X - Population[i].Cities[j].X)), 2D) + Math.Pow((Math.Abs((double)(Population[i].Cities[j - 1].Y - Population[i].Cities[j].Y))), 2D));
                }
                Population[i].distance = current;

                //Finding the longest(worst) Distance
                if (Population[i].distance > longestDistance)
                {
                    longestDistance = Population[i].distance;
                }
               
                totalPopulationDistance += current;

            }

            //Calculating the fitness
            for (int i = 0; i <= Population.GetUpperBound(0); i++)
            {
                Population[i].fitness = (longestDistance - Population[i].distance) / totalPopulationDistance;
                
                _TotalFitness += Population[i].fitness;
              

            }

            double fittest = 0;
            for (int i = 0; i < _PopulationSize; i++)
            {
                if (Population[i].fitness > fittest)
                {
                    CurrentFittest = new Genome(Population[i], _NumberOfCities);
                    fittest = Population[i].fitness;
                }
            }

           
        }
       
      

        
    }
}
    

