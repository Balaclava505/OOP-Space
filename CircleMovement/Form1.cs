using CircleMovement.Compression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        static Rocket rocket = new Rocket(rocket_pict,200,200);
        static OrbitalObject orbital_obj = new OrbitalObject();

        Star star = new Star(rocket, 30, 300, 300, Color.Yellow, 3);
        //Star star_rock = new Star(rocket);

        Planet planet = new Planet();
        Satellite satellite = new Satellite();

        Timer time = new Timer();
        EventHandler handler;
        int numOfPlanets = 0;

        public void Initialize()
        { 
            star.CreateSystem();

            time.Interval = 30;
            time.Enabled = true;
 

            handler = (x, y) => 
            {
                orbital_obj.Move(star.planets, star.satellites, star);
                
            }; 

            time.Tick += handler;
            time.Start(); 

            Background.Paint += (sender, e) =>
            {
                Paint(sender, e, star.planets, star.satellites);
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

        private new void Paint(object sender, PaintEventArgs e, List<Planet> planets, List<Satellite> satellites)
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
            g.DrawImage(star.rocket.Img, (float)star.rocket.X, (float)star.rocket.Y);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_AddPlan_Click(object sender, EventArgs e)
        {
            planet.InitData(++star.CountPlan, 0, star.planets);
        }

        public bool IsValidInput(string s,out int name)
        {
            name = 10000;
            int.TryParse(s, out name);
            if (name <= star.CountPlan)
            {
                return true;
            }
            return false;
        }

        private int CountSats()
        {
            numOfPlanets = 0;
            foreach (Satellite satellite in star.satellites)
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

        private void SearchFatherPlanet(int name)
        {
            foreach (Planet planet in star.planets)
                if (planet.Name == name)
                    planet.CountSat++;
        }

        private void btn_AddSat_Click(object sender, EventArgs e)
        {
            if (IsValidInput(textBox_NamePlan1.Text, out int name))
            {
                int numOfSats = 0;
                foreach (Satellite satellite in star.satellites)
                    if (satellite.fatherName == name)
                        numOfSats++;
                satellite.CreateRandSat(1, numOfSats, star.satellites, name);
                SearchFatherPlanet(name);
            }
        }

        private void btn_DelPlan_Click(object sender, EventArgs e)
        {
            if (IsValidInput(textBox_NamePlan2.Text, out int name))
            {
                planet.Del(star.planets, name);
                star.CountPlan--;
            }
        }

        private void btnDelSat_Click(object sender, EventArgs e)
        {
            if (IsValidInput(textBox_NamePlan3.Text, out int name))
            {
                satellite.Del(star.satellites, name);
                foreach (Planet planet in star.planets)
                    if (planet.Name == name)
                        planet.CountSat--;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            rocket.Fly(e, star.rocket);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tBox_EditPlan_TextChanged(object sender, EventArgs e)
        {
            if (IsValidInput(tBox_EditPlan.Text, out int name))
            {
                foreach (Planet planet in star.planets)
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
                foreach (Planet planet in star.planets)
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
                foreach (Satellite satellite in star.satellites)
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
            if ((IsValidInput(t_NumPlanOfSat.Text, out int f_name)) && (IsValidInputSat(t_NumSat.Text, out int name)))
            {
                    foreach (Satellite satellite in star.satellites)
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

        private void Serial_Click(object sender, EventArgs e)
        {
            NewSerializer newSerializer = new NewSerializer();
            time.Stop();

            SaveFileDialog dlg = new SaveFileDialog
            {
                FileName = "World",
                Filter = "Encoded XML file(*.xml)|*.xml|Encoded Binary data (*.bin)|*.bin|Encoded Text file(*.txt)|*.txt"
            };
            

            bool result = dlg.ShowDialog() == DialogResult.OK;
 
            if (result == true)
            {
               newSerializer.GetfileName_Serialization(dlg.FileName).Serialize(star, dlg.FileName);
            }
            time.Start();
        }

        private void Deserial_Click(object sender, EventArgs e)
        {
            NewSerializer newSerializer = new NewSerializer();
            time.Stop();

            var dlg = new OpenFileDialog();
            dlg.Filter = "Any file(xml,bin,txt or their encoded versions)|*.*";


            bool result = dlg.ShowDialog() == DialogResult.OK;
            if (result == true)
            {
                star = (Star)newSerializer.GetfileName_Serialization(dlg.FileName).Deserialize(typeof(Star), dlg.FileName);
            }
            time.Start();
        }

        private string pluginPath = "./";

        private void btnCompress_Click(object sender, EventArgs e)
        {
            time.Stop();
            NewSerializer newSerializer = new NewSerializer();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "World";

            CompressionAlgs algorithms = new CompressionAlgs(pluginPath);
            if (algorithms.objects.Count == 0)
            {
                MessageBox.Show("No plugins");
                return;
            }

            AddCompressorDecorator(algorithms);

            string filter = string.Empty;
            foreach (ICompression alg in algorithms.objects)
            {
                filter += alg.Name + " archive (*" + alg.Format + ")|*" + alg.Format + "|";
            }
            dlg.Filter = filter.TrimEnd('|');

            bool result = dlg.ShowDialog() == DialogResult.OK;
            if (result == true)
            {
                BinarySerialization bin = new BinarySerialization();
                XmlSerialization xml = new XmlSerialization();
                TextSerialization text = new TextSerialization();

                string ext = Path.GetExtension(dlg.FileName);
                string name = dlg.FileName.Replace(ext, "");
                ICompression compressor = algorithms.objects.Find(obj => obj.Format == ext);

                xml.Serialize(star, name + ".xml");
                compressor.Compress(name + ".xml", name + ".xml" + ext);
                File.Delete(name + ".xml");

                bin.Serialize(star, name + ".bin");
                compressor.Compress(name + ".bin", name + ".bin" + ext);
                File.Delete(name + ".bin");

                text.Serialize(star, name + ".txt");
                compressor.Compress(name + ".txt", name + ".txt" + ext);
                File.Delete(name + ".txt");
            }
            time.Start();
        }

        private void AddCompressorDecorator(CompressionAlgs algorithms)
        {
            List<ICompression> baseCompressors = new List<ICompression>(algorithms.objects);
            foreach (ICompression compressor in baseCompressors)
            {
                algorithms.objects.Add(new CipherDecorator(compressor));
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            time.Stop();
            NewSerializer newSerializer = new NewSerializer();

            CompressionAlgs algorithms = new CompressionAlgs(pluginPath);
            if (algorithms.objects.Count == 0)
            {
                MessageBox.Show("No plugins");
            }

            AddCompressorDecorator(algorithms);

            OpenFileDialog dlg = new OpenFileDialog();

            string filter = string.Empty;
            foreach (ICompression alg in algorithms.objects)
            {
                filter += "*" + alg.Format + ";";
            }
            filter = filter.TrimEnd(';');
            dlg.Filter = "Archives (" + filter + ")|" + filter;

            bool result = dlg.ShowDialog() == DialogResult.OK;

            if (result == true)
            {
                try
                {
                    string ext = System.IO.Path.GetExtension(dlg.FileName);
                    string temp = dlg.FileName.Replace(ext, "");

                    ICompression compressor = algorithms.objects.Find(obj => obj.Format == ext);
                    compressor.Decompress(dlg.FileName, temp);

                    star = (Star)newSerializer.GetfileName_Serialization(dlg.FileName).Deserialize(typeof(Star), temp);

                    File.Delete(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }

            time.Start();
        }
    }
}
