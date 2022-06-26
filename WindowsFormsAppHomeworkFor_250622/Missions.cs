using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomeworkFor_250622
{
    internal class Missions
    {
        private List<Mission> _missions;

        public Missions()
        {
            _missions = new List<Mission>();
        }

        public Missions(params Mission[] eachMission)
        {
            _missions = new List<Mission>();

            foreach (var mission in eachMission)
            {
                _missions.Add(mission);
            }
        }

        public override string ToString()
        {
            string str = "";

            foreach (var mission in _missions)
            {
                str += mission + "\n\n";
            }

            return str;
        }

        public int GetLength()
        {
            return _missions.Count;
        }

        public Mission this[int res]
        {
            get { return _missions[res]; }
        }
        
        public void DeleteResourceByIndex(int index)
        {
            _missions.Remove(_missions[index]);
        }
    }
}
