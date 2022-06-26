using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHomeworkFor_250622
{
    public partial class Form1 : Form
    {
        ResourcesManager resManager = new ResourcesManager();

        Missions missions = new Missions(new Mission(Resource.Water, 20), new Mission(Resource.Grass, 5), new Mission(Resource.Wood, 1));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }
        private void UpdateUI()
        {
            resorcesText.Text = resManager.ToString();
            missionsText.Text = missions.ToString();
        }


        private void WaterButton_Click(object sender, EventArgs e)
        {
            resManager.AddResourceInCount(Resource.Water, 1);
            CheckMissionsWithResource(Resource.Water);

            UpdateUI();
        }

        private void GrassButton_Click(object sender, EventArgs e)
        {
            if (resManager[Resource.Water] < 1)
            {
                return;
            }

            resManager.TryDeleteResourceInCount(Resource.Water, 1);

            if (GrassProgressBar.Value == 100)
            {
                GrassProgressBar.Value = 0;
            }
            GrassProgressBar.Value += 20;

            if (GrassProgressBar.Value == 100)
            {
                resManager.AddResourceInCount(Resource.Grass, 1);
                CheckMissionsWithResource(Resource.Grass);
            }

            UpdateUI();
        }

        private void CheckMissionsWithResource(Resource resource)
        {
            for (int i = 0; i < missions.GetLength(); i++)
            {
                if (missions[i].NecessaryResource == resource)
                {
                    missions[i].CheckMissionCompletion(ref resManager);
                }
            }
        }
    }
}
