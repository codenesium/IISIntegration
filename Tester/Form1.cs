using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codenesium.IISIntegration;

namespace Tester
{
    public partial class Form1 : Form
    {
        private IISIntegration _manager = new IISIntegration();

        public Form1()
        {
            InitializeComponent();
            LoadWebsites();
        }

        public void LoadWebsites()
        {
            comboBoxSites.DataSource = this._manager.GetSiteList();
            comboBoxAppPools.DataSource = this._manager.GetApplicationPoolList();
        }

        public void RefreshSiteStatus()
        {
            if (comboBoxSites.SelectedIndex > -1)
            {
                labelSiteStatus.Text = this._manager.GetSiteState(comboBoxSites.Text);
                comboBoxApplications.DataSource = this._manager.GetApplicationListForSite(comboBoxSites.Text);
            }
            else
            {
                labelSiteStatus.Text = String.Empty;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedIndex > -1)
            {
                this._manager.StartWebsite(comboBoxSites.Text);
                RefreshSiteStatus();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedIndex > -1)
            {
                this._manager.StopWebsite(comboBoxSites.Text);
                RefreshSiteStatus();
            }
        }

        private void comboBoxSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSiteStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonDeleteAppPool_Click(object sender, EventArgs e)
        {
            if (comboBoxAppPools.SelectedIndex > -1)
            {
                this._manager.DeleteAppPool(comboBoxAppPools.Text);
            }
        }

        private void buttonCreateAppPool_Click(object sender, EventArgs e)
        {
            this._manager.CreateAppPool(textBoxApplicationPoolName.Text, comboBoxNETVersion.Text, checkBoxEnable32BitApplications.Checked);
        }

        private void buttonDeleteWebsite_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedIndex > -1)
            {
                this._manager.DeleteWebsite(comboBoxSites.Text);
                RefreshSiteStatus();
            }
        }

        private void buttonCreateWebsite_Click(object sender, EventArgs e)
        {
            this._manager.CreateWebSite(textBoxSiteName.Text, textBoxWebsitePhysicalPath.Text, Convert.ToInt32(textBoxPort.Text));
        }

        private void buttonDeleteApplication_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedIndex > -1 && comboBoxApplications.SelectedIndex > -1)
            {
                this._manager.DeleteApplication(comboBoxSites.Text, comboBoxApplications.Text);
            }
        }

        private void buttonCreateVirtualDirectory_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedIndex > -1 && comboBoxApplications.SelectedIndex > -1)
            {
                this._manager.CreateVirtualDirectory(comboBoxSites.Text, comboBoxApplications.Text, textBoxVirtualDirectory.Text, textBoxVirtualDirectoryPath.Text);
            }
        }

        private void buttonCreateApplication_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedIndex > -1 && comboBoxApplications.SelectedIndex > -1)
            {
                this._manager.CreateApplication(comboBoxSites.Text, textBoxApplicationPath.Text, textBoxApplicationName.Text, comboBoxAppPools.Text);
            }
        }

        private void buttonCreateAppPool_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxApplicationPoolName.Text))
            {
                this._manager.CreateAppPool(textBoxApplicationPoolName.Text, comboBoxNETVersion.Text, checkBoxEnable32BitApplications.Checked);
            }
        }

        private void buttonDeleteAppPool_Click_1(object sender, EventArgs e)
        {
            if (comboBoxAppPools.SelectedIndex > -1)
            {
                this._manager.DeleteAppPool(comboBoxAppPools.Text);
            }
        }
    }
}