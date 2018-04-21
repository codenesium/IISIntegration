using FluentAssertions;
using Microsoft.Web.Administration;
using NLog;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Codenesium.IISIntegration
{
    public class IISIntegration
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// Retry the commit with sleep.
        /// </summary>
        /// <param name="serverManager"></param>
        private void commitChanges(ServerManager serverManager)
        {

            int retryCount = 5;
            for (int i = 0; i < retryCount; i++)
            {
                try
                {
                    serverManager.CommitChanges();
                    return;
                }
                catch (System.IO.FileLoadException)
                {
                    if (i >= retryCount)
                    {
                        throw;
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public void StartWebsite(string siteName)
        {
            _logger.Info("Starting website siteName={0}", siteName);
            siteName.Should().NotBeNullOrEmpty();

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                site.Should().NotBeNull("The site was null. It probably doesn't exist. webSiteName={0}", siteName);

                site.Start();
            }
            _logger.Info("Starting website complete siteName={0}", siteName);
        }

        public void StopWebsite(string siteName)
        {
            _logger.Info("Stopping website name={0}", siteName);
            siteName.Should().NotBeNullOrEmpty();

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                site.Should().NotBeNull("The site was null. It probably doesn't exist. webSiteName={0}", siteName);

                if (site.State == ObjectState.Started || site.State == ObjectState.Starting)
                {
                    _logger.Info("Website is started or starting siteName={0}", siteName);
                    site.Stop();
                }
            }
            _logger.Info("Stopping website complete siteName={0}", siteName);
        }

        public List<string> GetSiteList()
        {
            using (ServerManager serverManager = new ServerManager())
            {
                return serverManager.Sites.OrderBy(x => x.Name).Select(x => x.Name).ToList();
            }
        }

        public string GetSiteState(string siteName)
        {
            siteName.Should().NotBeNullOrEmpty();
            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                site.Should().NotBeNull("The site was null. It probably doesn't exist. webSiteName={0}", siteName);
                return site.State.ToString();
            }
        }

        public List<String> GetApplicationListForSite(string siteName)
        {
            siteName.Should().NotBeNullOrEmpty();
            using (ServerManager serverManager = new ServerManager())
            {
                if (serverManager.Sites[siteName] == null || serverManager.Sites[siteName].Applications == null)
                {
                    return new List<string>();
                }
                else
                {
                    return serverManager.Sites[siteName].Applications.Select(x => x.Path).ToList();
                }
            }
        }

        public List<String> GetApplicationPoolList()
        {
            using (ServerManager serverManager = new ServerManager())
            {
                return serverManager.ApplicationPools.OrderBy(x => x.Name).Select(x => x.Name).ToList();
            }
        }

        public void CreateAppPool(
            string name,
            string NETVersion,
            bool enable32BitAppOnWin64)
        {
            _logger.Info("Creating app pool name={0},NETVersion={1},enable32BitAppOnWin64={2}", name, NETVersion, enable32BitAppOnWin64);
            name.Should().NotBeNullOrEmpty();
            NETVersion.Should().NotBeNullOrEmpty().And.BeOneOf(new List<String>() { "v4.0", "v2.0" }, "Invalid .net framework verison");

            using (ServerManager serverManager = new ServerManager())
            {
                if (serverManager.ApplicationPools[name] == null)
                {
                    _logger.Info("Application pool does not exist so we will create it name={0}", name);
                    ApplicationPool newPool = serverManager.ApplicationPools.Add(name);
                    newPool.ManagedRuntimeVersion = NETVersion;
                    newPool.ManagedPipelineMode = ManagedPipelineMode.Integrated;
                    newPool.Enable32BitAppOnWin64 = enable32BitAppOnWin64;
                   
                    this.commitChanges(serverManager);
                    _logger.Info("App pool created name={0},NETVersion={1},enable32BitAppOnWin64={2}", name, NETVersion, enable32BitAppOnWin64);
                }
                else
                {
                    _logger.Info("Application pool already exists name={0}", name);
                }
            }
        }


        public void DeleteAppPool(string name)
        {
            _logger.Info("Deleting app pool name={0}", name);
            name.Should().NotBeNullOrEmpty();
            using (ServerManager serverManager = new ServerManager())
            {
                if (serverManager.ApplicationPools[name] == null)
                {
                    _logger.Info("Application pool does not exist name={0}", name);
                }
                else
                {
                    serverManager.ApplicationPools.Remove(serverManager.ApplicationPools[name]);
                    this.commitChanges(serverManager);
                    _logger.Info("Application pool deleted name={0}", name);
                }
            }
        }

        public void StopAppPool(string name)
        {
            _logger.Info($"Stopping app pool name={name}");
            name.Should().NotBeNullOrEmpty();
            using (ServerManager serverManager = new ServerManager())
            {
                if (serverManager.ApplicationPools[name] == null)
                {
                    _logger.Info($"Application pool does not exist name={name}");
                }
                else
                {
                    serverManager.ApplicationPools[name].Stop();
                    this.commitChanges(serverManager);
                    _logger.Info($"Application pool stopped name={name}");
                }
            }
        }


        public void StartAppPool(string name)
        {
            _logger.Info($"Starting app pool name={name}");
            name.Should().NotBeNullOrEmpty();
            using (ServerManager serverManager = new ServerManager())
            {
                if (serverManager.ApplicationPools[name] == null)
                {
                    _logger.Info($"Application pool does not exist name={name}");
                }
                else
                {
                    serverManager.ApplicationPools[name].Start();
                    this.commitChanges(serverManager);
                    _logger.Info($"Application pool started name={name}");
                }
            }
        }

        public void SetApplicationApplicationPool(
            string webSiteName,
            string applicationName,
            string applicationPoolName)
        {
            _logger.Info("Setting application pool webSiteName={0},applicationName={1},applicationPoolName={2}", webSiteName, applicationName, applicationPoolName);
            webSiteName.Should().NotBeNullOrEmpty();
            applicationName.Should().NotBeNullOrEmpty();
            applicationPoolName.Should().NotBeNullOrEmpty();

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[webSiteName];
                site.Should().NotBeNull("The site was null. It probably doesn't exist. webSiteName={0}", webSiteName);

                var application = site.Applications.Where(x => x.Path == applicationName).FirstOrDefault();
                application.Should().NotBeNull("The application does not exist");

                application.ApplicationPoolName = applicationPoolName;
                this.commitChanges(serverManager);
                _logger.Info("Application pool set applicationName={0},applicationPoolName={1}", applicationName, applicationPoolName);
            }
        }

        public void CreateApplication(
            string siteName,
            string siteDirectory,
            string applicationName,
            string appPoolName)
        {
            _logger.Info("Creating application siteName={0},siteDirectory={1},applicationName={2},appPoolName={3}", siteName, siteDirectory, applicationName, appPoolName);
            siteName.Should().NotBeNullOrEmpty();
            siteDirectory.Should().NotBeNullOrEmpty();
            applicationName.Should().NotBeNullOrEmpty();
            appPoolName.Should().NotBeNullOrEmpty();
            applicationName.Should().StartWith("/");

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                site.Should().NotBeNull("Site does not exist siteName={0}", siteName);

                var applications = site.Applications;
                if (applications[applicationName] == null)
                {
                    _logger.Info("Application does not exist name={0}", siteName);
                    applications.Add(applicationName, siteDirectory);
                    this.commitChanges(serverManager);
                    _logger.Info("Application created name={0}", siteName);
                }
                else
                {
                    _logger.Info("Application already exists name={0}", applicationName);
                }
            }

            SetApplicationApplicationPool(siteName, applicationName, appPoolName);
        }

        public void DeleteApplication(
            string siteName,
            string applicationName)
        {
            _logger.Info("Deleting application siteName={0},applicationName={1}", siteName, applicationName);
            siteName.Should().NotBeNullOrEmpty();
            applicationName.Should().NotBeNullOrEmpty();

            if(!applicationName.StartsWith("/"))
            {
                applicationName = "/" + applicationName;
            }

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                if (site == null)
                {
                    _logger.Info("Site does not exist siteName={0}", siteName);
                }
                else
                {
                    if (site.Applications[applicationName] == null)
                    {
                        _logger.Info("Application does not exist applicationName={0}", applicationName);
                    }
                    else
                    {
                        site.Applications[applicationName].Delete();
                        this.commitChanges(serverManager);
                        _logger.Info("Application deleted applicationName={0}", applicationName);
                    }
                }
            }
        }

        public void CreateVirtualDirectory(
            string siteName,
            string applicationName,
            string virtualDirectoryName,
            string path
            )
        {
            _logger.Info("Creating Virtual Directory siteName={0},applicationName={1},virtualDirectoryName={2},path={3}", siteName, applicationName, virtualDirectoryName, path);
            siteName.Should().NotBeNullOrEmpty();
            applicationName.Should().NotBeNullOrEmpty();
            virtualDirectoryName.Should().NotBeNullOrEmpty();
            path.Should().NotBeNullOrEmpty();

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                site.Should().NotBeNull("Site does not exist siteName={0}", siteName);

                var application = site.Applications[applicationName];
                application.Should().NotBeNull("Application was not found applicationName={0}", applicationName);

                application.VirtualDirectories.Add("/" + virtualDirectoryName, path);
                this.commitChanges(serverManager);
                _logger.Info("Creating virtual directory complete siteName={0}", siteName);
            }
        }

        public void CreateWebSite(
            string siteName,
            string physicalPath,
            int portNumber)
        {
            _logger.Info("Creating website siteName={0},physicalPath={1},portNumber={2}", siteName, physicalPath, portNumber);
            siteName.Should().NotBeNullOrEmpty();
            physicalPath.Should().NotBeNullOrEmpty();
            portNumber.Should().BeInRange(1, 65536);

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];

                site.Should().BeNull("Site already exists siteName={0}", siteName);

                serverManager.Sites.Add(siteName, physicalPath, portNumber);
                this.commitChanges(serverManager);

                _logger.Info("Creating website complete siteName={0}", siteName);
            }
        }

        public void DeleteWebsite(string siteName)
        {
            _logger.Info("Deleting website siteName={0}", siteName);
            siteName.Should().NotBeNullOrEmpty();

            using (ServerManager serverManager = new ServerManager())
            {
                var site = serverManager.Sites[siteName];
                if (site == null)
                {
                    _logger.Info("Site does not exist siteName={0}", siteName);
                }
                else
                {
                    serverManager.Sites.Remove(site);
                    this.commitChanges(serverManager);
                    _logger.Info("Creating website complete siteName={0}", siteName);
                }
            }
        }
    }
}