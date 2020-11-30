using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalVersionControl
{
    class Descripciones
    {
        private int idProject;
        private string version;
        private string Description;

        public string getVersion()
        {
            return this.version;
        }

        public string getDescripcion()
        {
            return this.Description;
        }

        public string getId()
        {
            return idProject.ToString();
        }

        public Descripciones(int idProject, string version, string description)
        {
            this.idProject = idProject;
            this.version = version;
            this.Description = description;
        }
    }
}
