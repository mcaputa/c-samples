using System;
using System.Collections.Generic;
using System.Text;

namespace Fabric
{
    using System.Reflection;

    using Fabric.Interfaces;

    public class AutoFactory
    {
        private Dictionary<string, Type> autos;

        public AutoFactory()
        {
            this.LoadAutoTypes();
        }

        private void LoadAutoTypes()
        {
           this.autos = new Dictionary<string, Type>();

            Type[] typesInCurrentAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInCurrentAssembly)
            {
                if (type.GetInterface(nameof(IAuto)) != null)
                {
                    this.autos.Add(type.Name.ToLower(), type);
                }
            }
        }

        public IAuto CreateInstance(string careName)
        {
            Type t = this.GetTypeToCreate(careName);

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carName)
        {
            foreach (var auto in this.autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return auto.Value;
                }
            }

            return null;
        }
    }
}
