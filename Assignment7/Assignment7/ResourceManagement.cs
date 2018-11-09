using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment7
{
    public class ResourceManagement
    {
        public int ResourceCount = 0;
        public List<Resource> Resources = new List<Resource>();
        public ResourceManagement()
        {
            AddResource();
        }

        public void AddResource()
        {
            Resources.Add(new Resource());
            IncrementCount();
        }

        public void IncrementCount()
        {
            ResourceCount += 1;
        }
        public void DecrementCount()
        {
            ResourceCount -= 1;
        }
        public int GetCount()
        {
            return ResourceCount;
        }

        public void RemoveResource()
        {
            Resources.RemoveAt(0);
            DecrementCount();
        }
        public class Resource : IDisposable
        {
            public MemoryStream Leak;
            public Resource()
            {
                Leak = new MemoryStream();
            }

            ~Resource()
            {
                Dispose();
            }

            public void Dispose()
            {
                Leak.Dispose();
            }
        }
    }
}
