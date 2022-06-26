using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomeworkFor_250622
{
    enum Resource
    {
        None,
        Value,
        Water,
        Grass,
        Wood
    }

    internal class Mission
    {
        const int rewardValue = 1;
        private bool _isCompleted = false;
        private string _missionInfo;

        private Resource _necessaryResource;
        private int _necessaryResourceCount;

        public Resource NecessaryResource
        {
            get { return _necessaryResource; }
        }

        public Mission()
        {
            _necessaryResource = Resource.None;
            _necessaryResourceCount = 0;
            _missionInfo = "Пустая задача";
        }

        public Mission(Resource resource, int resourceCount)
        {
            UpdateMission(resource, resourceCount);
        }

        public void CheckMissionCompletion(ResourcesManager manager)
        {
            if (_isCompleted) { return; }

            if (manager[_necessaryResource] >= _necessaryResourceCount)
            {
                bool isNormal = manager.TryDeleteResourceInCount(_necessaryResource, _necessaryResourceCount);

                if (isNormal)
                {
                    manager.AddResourceInCount(Resource.Value, rewardValue);

                    UpdateMission(_necessaryResource, (int)Math.Round(_necessaryResourceCount * 2.1));
                }
                else
                {
                    throw new Exception("Какие-то проблемы в CheckMissionCompletion");
                }
            }
        }

        public override string ToString()
        {
            return _missionInfo;
        }

        public void UpdateMission(Resource resource, int resourceCount)
        {
            _necessaryResource = resource;
            _necessaryResourceCount = resourceCount;
            _missionInfo = $"Необходимо {resourceCount} {resource}";
        }
    }
}
