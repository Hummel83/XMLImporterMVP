using System;
using XMLImporter.WinFormsMVP.Events;
using XMLImporter.WinFormsMVP.Model;

namespace XMLImporter.WinFormsMVP.View
{
    public interface IXMLImporterView
    {
        event EventHandler LoginClicked;
        event EventHandler ConnectClicked;
        event EventHandler ImportStartClicked;
        event EventHandler CloseClicked;
        event DomainSelectedEventHandler DomainSelectionChanged;
        event ProjectSelectedEventHandler ProjectSelectionChanged;
        event FileSelectedEventHandler FileSelected;

        bool IsLoggedIn { get; set; }

        bool IsConnected { get; set; }

        bool ButtonLoginEnabled { set; }

        bool ButtonConnectEnabled { set; }

        bool ButtonImportFileEnabled { set; }

        string ConnectionLink { set; }

        string Username { get; set; }

        string Password { get; set; }

        string FilePath { set; }

        DomainItem[] ComboBoxDomain { set; }

        ProjectItem[] ComboBoxProject { set; }

        void LogMessage(string message);
    }
}
