using System;
using System.Windows.Forms;
using XMLImporter.Business.Interfaces;
using XMLImporter.WinFormsMVP.Events;
using XMLImporter.WinFormsMVP.Infrastructure.DI;
using XMLImporter.WinFormsMVP.MockData;
using XMLImporter.WinFormsMVP.Model;
using XMLImporter.WinFormsMVP.Presenter;
using XMLImporter.WinFormsMVP.View;

namespace XMLImporter.WinFormsMVP
{
    public partial class MainForm : Form, IXMLImporterView
    {
        private readonly string _appStartPath = Application.StartupPath;
        private readonly XMLImporterPresenter _xMLImporterPresenter;

        //Gets instance using DI
        private readonly IDomainRepository _domainRepo = CompositionRoot.Resolve<IDomainRepository>();
        private readonly IProjectRepository _projectRepo = CompositionRoot.Resolve<IProjectRepository>();
        private readonly IFileService _fileService = CompositionRoot.Resolve<IFileService>();

        public MainForm()
        {
            InitializeComponent();
            InitializGuiFields();

            _xMLImporterPresenter = new XMLImporterPresenter(this, _fileService, _domainRepo, _projectRepo, _appStartPath);

            this.Load += XMLImporter_Load;
        }

        private void InitializGuiFields()
        {
            DisableConnectionLinkField();
            EnableOrDisableLoginFields(true);
            EnableOrDisableConnectFields(false);
            DisableImportFields();
        }

        #region Events from IView
        public event EventHandler LoginClicked;
        public event EventHandler ConnectClicked;
        public event EventHandler ImportStartClicked;
        public event EventHandler CloseClicked;
        public event DomainSelectedEventHandler DomainSelectionChanged;
        public event ProjectSelectedEventHandler ProjectSelectionChanged;
        public event FileSelectedEventHandler FileSelected;
        #endregion

        #region Properties from IView
        public bool IsLoggedIn { get; set; }

        public bool IsConnected { get; set; }

        public bool ButtonLoginEnabled
        {
            set { btn_login.Enabled = value; }
        }

        public bool ButtonConnectEnabled
        {
            set { btn_Connect.Enabled = value; }
        }

        public bool ButtonImportFileEnabled
        {
            set { btn_startImport.Enabled = value; }
        }

        public string ConnectionLink
        {
            set { txtBox_ConnectionLink.Text = value; }
        }

        public string Username
        {
            get { return txtBox_username.Text; }
            set { txtBox_username.Text = value; }
        }

        public string Password
        {
            get { return txtBox_password.Text; }
            set { txtBox_password.Text = value; }
        }

        public string FilePath
        {
            set { txtBox_file.Text = value; }
        }

        public DomainItem[] ComboBoxDomain
        {
            set
            {
                //todo: refactor
                cmbBox_domain.Items.Clear();
                if (value != null && value.Length > 0)
                {
                    cmbBox_domain.Items.AddRange(value);
                    cmbBox_domain.DisplayMember = "Name";
                    cmbBox_domain.SelectedIndex = 0;
                }
                else
                {
                    cmbBox_domain.SelectedIndex = -1;
                    cmbBox_domain.SelectedItem = null;
                    DomainSelectionChanged?.Invoke(this, new DomainSelectedEventArgs(null));
                }
            }
        }

        public ProjectItem[] ComboBoxProject
        {
            set
            {
                //todo: refactor
                cmbBox_project.Items.Clear();
                if (value != null && value.Length > 0)
                {
                    cmbBox_project.Items.AddRange(value);
                    cmbBox_project.DisplayMember = "Name";
                    cmbBox_project.SelectedIndex = 0;
                }
                else
                {
                    cmbBox_project.SelectedIndex = -1;
                    cmbBox_project.SelectedItem = null;
                    ProjectSelectionChanged?.Invoke(this, new ProjectSelectedEventArgs(null));
                }
            }
        }
        #endregion

        #region Methods from IView
        public void LogMessage(string message)
        {
            AddToOutputTextBox(message);
        }
        #endregion

        #region private Events
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                LoginClicked?.Invoke(sender, e);

                if (this.IsLoggedIn)
                {
                    EnableOrDisableLoginFields(false);
                    EnableOrDisableConnectFields(true);
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsLoggedIn)
                {
                    ConnectClicked?.Invoke(sender, e);
                }

                if (this.IsConnected)
                {
                    EnableImportFields();
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void cmbBox_domain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;
            var selectedDomain = cmb.SelectedItem as DomainItem;
            DomainSelectionChanged?.Invoke(sender, new DomainSelectedEventArgs(selectedDomain));
        }

        private void cmbBox_project_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;
            var selectedProject = cmb.SelectedItem as ProjectItem;
            ProjectSelectionChanged?.Invoke(sender, new ProjectSelectedEventArgs(selectedProject));
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog_SelectXmlFile.Filter = "txt files (*.txt)|*.txt";
            openFileDialog_SelectXmlFile.Multiselect = false;
            if (openFileDialog_SelectXmlFile.ShowDialog() == DialogResult.OK)
            {
                FileSelected?.Invoke(sender, new FileSelectedEventArgs(openFileDialog_SelectXmlFile.FileName));
                EnableImportButton();
            }
        }

        private void btn_startImport_Click(object sender, EventArgs e)
        {
            try
            {
                ImportStartClicked?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            try
            {
                CloseClicked?.Invoke(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        #endregion

        #region private Methods

        private void XMLImporter_Load(object sender, EventArgs e)
        {
            try
            {
                _xMLImporterPresenter.Load();
            }
            catch (Exception)
            {
                ShowErrorDialog("Fehler beim Starten der Anwendung.");
            }
        }

        private void AddToOutputTextBox(string message)
        {
            txtBox_output.AppendText(message + Environment.NewLine);
            txtBox_output.ScrollToCaret();

            //todo: save in Log file
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisableConnectionLinkField()
        {
            txtBox_ConnectionLink.Enabled = false;
        }

        private void EnableOrDisableLoginFields(bool value)
        {
            txtBox_username.Enabled = value;
            txtBox_password.Enabled = value;
            btn_login.Enabled = value;
        }

        private void EnableOrDisableConnectFields(bool value)
        {
            cmbBox_domain.Enabled = value;
            cmbBox_project.Enabled = value;
            btn_Connect.Enabled = value;
        }

        private void DisableImportFields()
        {
            txtBox_file.Enabled = false;
            btn_openFile.Enabled = false;
            btn_startImport.Enabled = false;
        }

        private void EnableImportFields()
        {
            txtBox_file.Enabled = true;
            btn_openFile.Enabled = true;
        }

        private void EnableImportButton()
        {
            txtBox_file.Enabled = false;
            btn_startImport.Enabled = true;
        }
        #endregion
    }
}
