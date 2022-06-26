using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomeworkFor_250622
{
    internal class ResourcesManager
    {
        private List<int> _countResources;

        public int this[Resource res]
        {
            get { return _countResources[(int)res]; }
        }

        public int this[int res]
        {
            get { return _countResources[res]; }
        }

        public ResourcesManager()
        {
            var last = (int)Enum.GetValues(typeof(Resource)).Cast<Resource>().Max() + 1;

            _countResources = new List<int>();
            for (int i = 0; i < last; i++)
            {
                _countResources.Add(0);
            }
        }

        public void AddResourceInCount(Resource resourceType, int count)
        {
            _countResources[(int)resourceType] += count;
        }

        public bool TryDeleteResourceInCount(Resource resourceType, int count)
        {
            if (_countResources[(int)resourceType] - count >= 0)
            {
                _countResources[(int)resourceType] -= count;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 1; i < _countResources.Count; i++)
            {
                str += (Resource)i + ": " + _countResources[i] + "\n";
            }

            return str;
        }
    }
}
