using System;
using XMLImporter.WinFormsMVP.Model;

namespace XMLImporter.WinFormsMVP.Events
{
    public delegate void DomainSelectedEventHandler(object sender, DomainSelectedEventArgs e);

    public class DomainSelectedEventArgs : EventArgs
    {
        public DomainItem SelectedDomain { get; private set; }

        public DomainSelectedEventArgs(DomainItem item)
        {
            this.SelectedDomain = item;
        }
    }
}
