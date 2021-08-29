using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TSP_Code_Starter
{
    public partial class frmMain : Form
    {
        GA theGA;
        Genome CurrentBest;
        int NumberOfCities;
        int MutationRate;
        double CurrentBestdbl;
        ICrossOver CrossOverChoice = null;
        IMutator MutatorChoice = null;
        ISelect SelectChoice = null;
        bool Cross = false;
        bool Mutate = false;
        bool Selection = false;
        int GenCount = 0;

        
        
        public frmMain()
        {
            InitializeComponent();
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            






        }

        private void DrawPaint(object sender, PaintEventArgs e)
        {


            //VERY untidy code to draw the current best genome to the screen. Please clean this up a bit.
            
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);


            //Draw a "Box" arounf the drawing area

            for (int i = 0; i < NumberOfCities ; i++)
            {

                e.Graphics.DrawRectangle(new Pen(Color.Green, 2f),500, 50,1050,900);


                 e.Graphics.DrawEllipse(
                new Pen(Color.Red, 2f),
               CurrentBest.Cities[i].X  + 600, CurrentBest.Cities[i].Y, 2, 2);

                

                 e.Graphics.DrawString(
                     CurrentBest.Cities[i].CityName.ToString() , drawFont, drawBrush, (float)CurrentBest.Cities[i].X + 600, (float)CurrentBest.Cities[i].Y);
            }


            for (int i = 0; i < NumberOfCities ; i++)
            {
                if (i == NumberOfCities-1)
                {
                    e.Graphics.DrawLine(
        new Pen(Color.Red, 2f),
        new Point(CurrentBest.Cities[0].X + 600, CurrentBest.Cities[0].Y),
        new Point(CurrentBest.Cities[i].X + 600, CurrentBest.Cities[i].Y));
                }
                else
                {
                    e.Graphics.DrawLine(
        new Pen(Color.Red, 2f),
        new Point(CurrentBest.Cities[i+1].X+600, CurrentBest.Cities[i+1].Y),
        new Point(CurrentBest.Cities[i].X+600, CurrentBest.Cities[i].Y));
                }
            }
            


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            NumberOfCities = int.Parse(txtCities.Text);
            int PopulationSize = int.Parse(txtPop.Text);
            bool Layout = false;
            MutationRate = int.Parse(txtMutationRate.Text);
            int NumOfGen = int.Parse(txtGen.Text);
            double TempFit = 10000000;
            bool EliteAnswer = false;
            int EliteAmount = 0;

            if (Cross == false || Mutate == false || Selection == false)
            {
                MessageBox.Show("Please make sure you have selected a crossover, mutate and select from the menubar above");
            }
            else
            {


                if (cbxLayout.SelectedItem.ToString() == "Random")
                {
                    Layout = false;
                }
                else if (cbxLayout.SelectedItem.ToString() == "Circle")
                {
                    Layout = true;
                }

                if (rdbOn.Checked == true)
                {
                    EliteAnswer = true;
                    EliteAmount = int.Parse(txtElitismAmount.Text);

                }
                else
                {
                    EliteAnswer = false;

                }

                //All the parameters need to be set via the menu on the form. It is your job to change the menu so that this will work.
                // The crossover and mutate are added using a strategy pattern. You should have at least three different ones of each.
                //Note that you have to ask the user if they want a circle of cities or a random list and set the bool for that before doing the call to instantiate the GA
                theGA = new GA(NumberOfCities, PopulationSize, MutationRate, CrossOverChoice, MutatorChoice, Layout, SelectChoice, EliteAnswer, EliteAmount);
                CurrentBest = theGA.CurrentFittest;
                CurrentBestdbl = CurrentBest.distance;



                Graphics Draw = this.CreateGraphics();
                Rectangle R = new Rectangle();
                PaintEventArgs Paint = new PaintEventArgs(Draw, R);



                for (int i = 0; i <= NumOfGen; i++)
                {
                    theGA.NextGen();
                    CurrentBest = theGA.CurrentFittest;

                    if (CurrentBest.distance < TempFit)
                    {

                        TempFit = CurrentBest.distance;
                        Draw.Clear(Color.White);
                        DrawPaint(this, Paint);
                        lbxOutput.Items.Add(theGA.CurrentFittest.distance.ToString());
                        Application.DoEvents();
                        WriteToTextFile();
                    }
                    lblGeneration.Text = i.ToString();
                    Application.DoEvents();
                    GenCount = i;

                }
                lbxOutput.Items.Add("Complete!");
                DrawPaint(this, Paint);
                MessageBox.Show("Please restart the program if values need to be changed e.g: Number of Cities."+ "\n" +"This is to ensure that fresh data is being used for every run. "+ "\n\n" + "Crossovers, Mutations and Selections can however be changed if the values stay the same");
                
            }
        }
        private void WriteToTextFile()
        {
            StreamWriter writer = new StreamWriter("TheRoute.txt", true);            
            for (int i = 0; i <= theGA.CurrentFittest.Cities.GetUpperBound(0); i++)
            writer.Write(theGA.CurrentFittest.Cities[i].CityName + ",");
            writer.Write("   Generation No: " + GenCount + "    Distance: " + theGA.CurrentFittest.distance);
            writer.WriteLine();
            writer.Close();
            
        }

        private void pMXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrossOverChoice = new PMX();
            Cross = true;
        }

        private void simpleMutationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MutatorChoice = new SimpleMutate();
            Mutate = true;
        }

        private void roulletteWheelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectChoice = new RouletteWheelSelect();
            Selection = true;

        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrossOverChoice = new SimpleCrossOver();
            Cross = true;
        }

        private void orderCrossoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrossOverChoice = new OrderCrossover();
            Cross = true;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MutatorChoice = new Insertion();
            Mutate = true;
        }

        private void tournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectChoice = new TournamentSelect();
            Selection = true;
        }

        private void displacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MutatorChoice = new DisplacementMutate();
            lblWarning.Text = "Displacement Mutate code works, but does not work well in this TSP";
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MutatorChoice = new ReverseMutate();
            Mutate = true;
        }

        private void rankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectChoice = new RankSelect();
            Selection = true;
            lblWarning2.Text = "The rank select runs through and ranks the entire population which is why it is so slow";
        }

       



    }
}
