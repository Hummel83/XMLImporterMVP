using System;
using System.Linq;
using XMLImporter.Business.Events;
using XMLImporter.Business.Interfaces;
using XMLImporter.WinFormsMVP.Events;
using XMLImporter.WinFormsMVP.MockData;
using XMLImporter.WinFormsMVP.Model;
using XMLImporter.WinFormsMVP.View;

namespace XMLImporter.WinFormsMVP.Presenter
{
    public class XMLImporterPresenter
    {
        private readonly string _appStartPath;
        private string _selectedFilePath;
        private DomainItem _selectedDomain;
        private ProjectItem _selectedProject;

        private readonly IXMLImporterView _view;
        private readonly IFileService _fileService;
        private readonly IDomainRepository _domainRepo;
        private readonly IProjectRepository _projectRepo;

        #region constructor
        public XMLImporterPresenter(IXMLImporterView view,
            IFileService fileService,
            IDomainRepository domainRepo,
            IProjectRepository projectRepo,
            string appStartPath)
        {
            _view = view;
            _fileService = fileService;
            _domainRepo = domainRepo;
            _projectRepo = projectRepo;
            _appStartPath = appStartPath;
            view.LoginClicked += View_LoginClicked;
            view.ConnectClicked += View_ConnectClicked;
            view.ImportStartClicked += View_ImportStartClicked;
            view.CloseClicked += View_CloseClicked;
            view.DomainSelectionChanged += View_DomainSelectionChanged;
            view.ProjectSelectionChanged += View_ProjectSelectionChanged;
            view.FileSelected += View_FileSelected;
        }
        #endregion

        #region data
        public void Load()
        {
            try
            {
                //print out
                _view.LogMessage($"-> Importer-started");
                _view.LogMessage($"Startpfad: {_appStartPath}");
                _view.LogMessage(string.Empty);

                //implement initial load info if needed
            }
            catch (Exception)
            {
                _view.ButtonLoginEnabled = false;
                _view.ButtonConnectEnabled = false;
                _view.ButtonImportFileEnabled = false;
                throw;
            }
        }
        #endregion

        #region private methods
        private void ReadFile(string path)
        {
            try
            {
                //subscribe to file reader message event
                _fileService.FileReaderMessageSent += FileReaderMessagesSent;

                //read xml file
                _fileService.ReadFile(path);
            }
            catch (Exception ex)
            {
                _view.LogMessage("Fehler beim lesen der xml datei:");
                _view.LogMessage("-Fehler: " + ex.Message);
                throw;
            }
        }

        private void FileReaderMessagesSent(object sender, FileReaderMessageEventArgs e)
        {
            _view.LogMessage(e.Message);
        }

        private bool ValidateXML(string path)
        {
            return true;
        }
        #endregion

        #region events
        private void View_LoginClicked(object sender, EventArgs e)
        {
            try
            {
                //toDo: add login functionality here
                var oldUsername = _view.Username;
                _view.Username = "Gor";
                _view.Password = "**********";

                //populate domain combo
                _view.ComboBoxDomain = _domainRepo.GetDomains().ToArray();

                _view.IsLoggedIn = true;
            }
            catch (Exception)
            {

                _view.LogMessage("Fehler beim Login");
                _selectedDomain = null;
                _selectedProject = null;
                _view.ComboBoxDomain = null;
                _view.ComboBoxProject = null;
                throw;
            }
        }

        private void View_ConnectClicked(object sender, EventArgs e)
        {
            try
            {
                //toDo: add connect functionality here
                _view.IsConnected = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void View_DomainSelectionChanged(object sender, DomainSelectedEventArgs e)
        {
            _selectedDomain = e.SelectedDomain as DomainItem;
            _view.LogMessage($"Domain selected: {_selectedDomain?.Name}");

            if (_selectedDomain != null)
            {
                try
                {
                    //populate project combo
                    if (_selectedDomain.Name != "Domain-2")
                    {
                        _view.ComboBoxProject = _projectRepo.GetProjects(_selectedDomain.Name).ToArray();
                    }
                    else
                    {
                        _view.ComboBoxProject = null;
                    }
                }
                catch (Exception)
                {
                    _view.LogMessage("Fehler beim Abrufen von Projekten.");
                    _selectedProject = null;
                    _view.ComboBoxProject = null;
                    throw;
                }
            }
            else
            {
                _selectedProject = null;
                _view.ComboBoxProject = null;
            }
        }

        private void View_ProjectSelectionChanged(object sender, ProjectSelectedEventArgs e)
        {
            _selectedProject = e.SelectedProject as ProjectItem;
            _view.LogMessage($"Project selected: {_selectedProject?.Name}");
        }

        private void View_FileSelected(object sender, FileSelectedEventArgs e)
        {
            var selectedFilePath = e.SelectedFilePath as string;
            _selectedFilePath = selectedFilePath;
            _view.FilePath = selectedFilePath;
            _view.LogMessage("Datei: " + selectedFilePath);
        }

        private void View_ImportStartClicked(object sender, EventArgs e)
        {
            try
            {
                //check if file path not empty
                if (!string.IsNullOrWhiteSpace(_selectedFilePath))
                {
                    //todo: validate xml data
                    var isValidated = ValidateXML(_selectedFilePath);
                    if (isValidated)
                    {
                        _view.LogMessage("Validierung nicht erfolgreich, Vorgang abgebrochen");
                    }

                    _view.LogMessage("Validierung erfolgreich.");

                    //todo: import xml

                    _view.LogMessage("XML imported erfolgreich.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void View_CloseClicked(object sender, EventArgs e)
        {
            try
            {
                //todo: close functionality
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
