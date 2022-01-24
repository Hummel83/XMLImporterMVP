using System;
using XMLImporter.WinFormsMVP.Model;

namespace XMLImporter.WinFormsMVP.Events
{
    public delegate void ProjectSelectedEventHandler(object sender, ProjectSelectedEventArgs e);

    public class ProjectSelectedEventArgs : EventArgs
    {
        public ProjectItem SelectedProject { get; private set; }

        public ProjectSelectedEventArgs(ProjectItem item)
        {
            this.SelectedProject = item;
        }
    }
}
