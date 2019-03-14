using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMovement
{
    public partial class CircleMovement : Form
    {


        public CircleMovement()
        {
            InitializeComponent();
            Initialize();
        }

        static Bitmap rocket_pict = new Bitmap(Properties.Resources.rocket, new Size(50, 50));
        static Rocket rocket = new Rocket(rocket_pict);
        static OrbitalObject orbital_obj = new OrbitalObject(rocket, 350, 350, Color.White);
        //Satellite satellite = new Satellite(3, 150, 150, 3, 30, 1);
        //Planet planet = new Planet(10, 100, 50, 0, 150, 1, satellite);
        Star star = new Star(30, 300, 300, Color.Yellow);
        //Planet planet;
        //private static Satellite satellite;
        Planet planet = new Planet(0, 0, 0, 0, orbital_obj.RandomColor(), 0, 0,0);
        Satellite satellite = new Satellite(0,0, 0, 0, orbital_obj.RandomColor(), 0, 0, 0,0);
        

        public List<Planet> planets = new List<Planet>();
        public List<Satellite> satellites = new List<Satellite>();

        Timer time = new Timer();
        EventHandler handler;
        int numOfPlanets = 0;

        public void Initialize()
        {
            //planets.Add(planet);
            //satellites.Add(satellite);
            star.CreateSystem(out planets, out satellites);
            //planet.CreateRandPlanet(numOfPlanets, 1, planets, satellites, satellite);
           // numOfPlanets++; //одна инициализирована заранее

            time.Interval = 30;
            time.Enabled = true;
 

            handler = (x, y) => 
            {
                planet.Move(planets, satellites, star);
                
            }; 

            time.Tick += handler;
            time.Start(); 

            Background.Paint += (sender, e) =>
            {
                Paint(sender, e, planets, satellites, orbital_obj);
            };

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            int formWidth = Width;
            int formHeight = Height;

        }

        private new void Paint(object sender, PaintEventArgs e, List<Planet> planets, List<Satellite> satellites, OrbitalObject orb)
        {
            Graphics g = e.Graphics;
            star.Shine(g);
            g.FillEllipse(new SolidBrush(star.ColorObj), (int)star.X, (int)star.Y, (float)(2 * star.Radius), (float)(2 * star.Radius));          
            foreach (Planet planet in planets)
            {
                g.DrawEllipse(Pens.Blue, (float)(star.X - planet.Distance + star.Radius), (float)(star.Y - planet.Distance + star.Radius), 
                    (float)(2 * planet.Distance), (float)(2 * planet.Distance));
                g.FillEllipse(new SolidBrush(planet.ColorObj), (int)planet.X, (int)planet.Y, (float)(2 * planet.Radius), (float)(2 * planet.Radius));
                foreach (Satellite satellite in satellites)
                {
                    if (satellite.fatherName == planet.Name)
                        g.FillEllipse(new SolidBrush(satellite.ColorObj), (int)satellite.X, (int)satellite.Y, (float)(2 * satellite.Radius), (float)(2 * satellite.Radius));
                }
            }
            g.DrawImage(orb.rocket.Img, (float)orb.X, (float)orb.Y);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
        }



        private void btn_AddPlan_Click(object sender, EventArgs e)
        {
            CountPlanets();
            planet.InitData(numOfPlanets, 1, planets);
        }

        private int CountPlanets()
        {
            numOfPlanets = 0;
            foreach (Planet planet in planets)
                numOfPlanets++;
            return numOfPlanets;
        }

        public bool IsValidInput(string s,out int name)
        {
            name = 10000;
            int.TryParse(s, out name);
            if (name <= CountPlanets())
            {
                return true;
            }
            return false;
        }

        private int CountSats()
        {
            numOfPlanets = 0;
            foreach (Satellite satellite in satellites)
                numOfPlanets++;
            return numOfPlanets;
        }

        public bool IsValidInputSat(string s, out int name)
        {
            name = 10000;
            int.TryParse(s, out name);
            if (name <= CountSats())
            {
                return true;
            }
            return false;
        }

        private void btn_AddSat_Click(object sender, EventArgs e)
        {
            if (IsValidInput(textBox_NamePlan1.Text, out int name))
            {
                satellite.CreateRandSat(1, 1, satellites, name);
            }
        }

        private void btn_DelPlan_Click(object sender, EventArgs e)
        {
            if (IsValidInput(textBox_NamePlan2.Text, out int name))
            {
                planet.Del(planets, name);
            }
        }

        private void btnDelSat_Click(object sender, EventArgs e)
        {
            if (IsValidInput(textBox_NamePlan3.Text, out int name))
            {
                satellite.Del(satellites, name);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            rocket.Fly(e, orbital_obj);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tBox_EditPlan_TextChanged(object sender, EventArgs e)
        {
            if (IsValidInput(tBox_EditPlan.Text, out int name))
            {
                foreach (Planet planet in planets)
                {
                    if (planet.Name == name)
                    {
                        PlanRad_UpDown.Text = planet.Radius.ToString();
                        PlanDist_UpDown.Text = planet.Distance.ToString();
                        speedPlan_UpDown.Text = planet.OrbitSpeed.ToString();
                        int ColorNum = planet.ColorObj.ToArgb();
                        Byte[] rgb = BitConverter.GetBytes(ColorNum);
                        tColor_R.Text = rgb[2].ToString();
                        tColor_G.Text = rgb[1].ToString();
                        tColor_B.Text = rgb[0].ToString();
                    }
                }
            }

        }

        private void btn_EditPlan_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            if (IsValidInput(tBox_EditPlan.Text, out int name))
            {
                foreach (Planet planet in planets)
                {                    
                    if (planet.Name == name)
                    {
                        planet.Radius = int.Parse(PlanRad_UpDown.Text);
                        planet.Distance = int.Parse(PlanDist_UpDown.Text);
                        planet.OrbitSpeed = double.Parse(speedPlan_UpDown.Text);
                        int.TryParse(tColor_R.Text, out r);
                        int.TryParse(tColor_G.Text, out g);
                        int.TryParse(tColor_B.Text, out b);
                        planet.ColorObj = Color.FromArgb(r, g, b);
                    }
                }
            }
        }


        private void btn_EditSat_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            if ((IsValidInput(t_NumSat.Text, out int f_name)) && (IsValidInputSat(t_NumPlanOfSat.Text, out int name)))
            {
                foreach (Satellite satellite in satellites)
                {
                    if ((satellite.fatherName == f_name) && (satellite.Name == name))
                    {
                        satellite.Radius = int.Parse(upDown_SatRad.Text);
                        satellite.Distance = int.Parse(upDown_SatDist.Text);
                        satellite.OrbitSpeed = double.Parse(upDown_SatSpeed.Text);
                        int.TryParse(t_SatColor_R.Text, out r);
                        int.TryParse(t_SatColor_G.Text, out g);
                        int.TryParse(t_SatColor_B.Text, out b);
                        satellite.ColorObj = Color.FromArgb(r, g, b);
                        //satellite.fatherName = int.Parse(t_NumPlanOfSat.Text);
                    }
                }
            }
        }

        private void Btn_SeeSatData_Click(object sender, EventArgs e)
        {
            if ((IsValidInput(t_NumSat.Text, out int f_name)) && (IsValidInputSat(t_NumPlanOfSat.Text, out int name)))
            {
                    foreach (Satellite satellite in satellites)
                    {
                        if ((satellite.fatherName == f_name) && (satellite.Name == name))
                        {
                            upDown_SatRad.Text = satellite.Radius.ToString();
                            upDown_SatDist.Text = satellite.Distance.ToString();
                            upDown_SatSpeed.Text = satellite.OrbitSpeed.ToString();
                            int ColorNum = satellite.ColorObj.ToArgb();
                            Byte[] rgb = BitConverter.GetBytes(ColorNum);
                            t_SatColor_R.Text = rgb[2].ToString();
                            t_SatColor_G.Text = rgb[1].ToString();
                            t_SatColor_B.Text = rgb[0].ToString();
                            //t_NumSat.Text = satellite.Name.ToString();
                        }
                    }
            }
        }

        private void Btn_ChangeStar_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            star.X = int.Parse(t_StarX.Text);
            star.Y = int.Parse(t_StarY.Text);
            int.TryParse(T_StarColor_R.Text, out r);
            int.TryParse(T_StarColor_G.Text, out g);
            int.TryParse(T_StarColor_B.Text, out b);
            star.ColorObj = Color.FromArgb(r, g, b);
        }
    }

}
