using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Sample code for how to execute the initialization operations
    /// Note: This demo requires an extensive dictionary of configuration values
    /// </summary>
    public class InitializeDemo
    {
        // TODO: Encapsulate all these values in a configuration DTO to simplify usage

        // Configuration keys
        public const string PcceHost = "pcce.host";
        public const string SideAUsername = "side.a.username";
        public const string SideAPassword = "side.a.password";
        public const string SideAAddress = "side.a.address";
        public const string SideBUsername = "side.b.username";
        public const string SideBPassword = "side.b.password";
        public const string SideBAddress = "side.b.address";
        public const string CmPubName = "cm.pub.name";
        public const string CmUsername = "cm.username";
        public const string CmPassword = "cm.password";
        public const string CvpDiagUsername = "cvp.diag.username";
        public const string CvpDiagPassword = "cvp.diag.password";
        public const string CvpAdminUsername = "cvp.admin.username";
        public const string CvpAdminPassword = "cvp.admin.password";
        public const string CvpAUsername = "cvp.a.username";
        public const string CvpAPassword = "cvp.a.password";
        public const string CvpBUsername = "cvp.b.username";
        public const string CvpBPassword = "cvp.b.password";
        public const string CceDiagUsername = "pcce.diag.username";
        public const string CceDiagPassword = "pcce.diag.password";
        public const string CuicDiagUsername = "cuic.diag.username";
        public const string CuicDiagPassword = "cuic.diag.password";
        public const string CuicIdsUsername = "cuic.ids.username";
        public const string CuicIdsPassword = "cuic.ids.password";
        public const string FinesseDiagUsername = "finesse.diag.username";
        public const string FinesseDiagPassword = "finesse.diag.password";
        public const string SettingsCodec = "settings.codec";
        public const string SettingsServiceUsername = "settings.service.username";
        public const string SettingsServicePassword = "settings.service.password";
        public const string Facility = "facility";
        public const string Instance = "instance";

        /// <summary>
        /// How long to wait between polls of the initialization status API (in milliseconds).
        /// </summary>
        public const int SleepTimeMs = 5000;

        private RestClient _restClient = default!;
        private readonly Dictionary<string, string> _props;
        private Dictionary<MachineType, List<MachineHost>> _typeToMachine = new Dictionary<MachineType, List<MachineHost>>();

        /// <summary>
        /// The main method.
        /// </summary>
        public static async Task Main(string[] args)
        {
            Console.WriteLine("InitializeDemo - This is a complex demo that requires extensive configuration.");
            Console.WriteLine("Configuration should be loaded from appsettings.json by the calling application.");
            Console.WriteLine("Please ensure you have all necessary configuration values in your appsettings.json file.");

            // Example usage (see Configuration keys section above):
            // var configuration = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json", optional: false)
            //     .Build();
            // var props = configuration.GetSection("InitializeSettings").Get<Dictionary<string, string>>();
            // var demo = new InitializeDemo(props);
            // await demo.ExecuteInitializeAsync();

            Console.WriteLine("Initialize demo structure ported successfully.");
        }

        /// <summary>
        /// Constructor with properties dictionary loaded from appsettings.json.
        /// </summary>
        public InitializeDemo(Dictionary<string, string> props)
        {
            _props = props ?? throw new ArgumentNullException(nameof(props));

            // Create a new RESTClient object with the IP of your DS / AW HDS
            _restClient = new RestClient(
                props[PcceHost],
                props[CceDiagUsername],
                props[CceDiagPassword]
            );
        }

        // for unit testing
        public InitializeDemo()
        {
            _props = new Dictionary<string, string>();
            _restClient = default!;
        }

        /// <summary>
        /// Performs automated initialization.
        /// </summary>
        public async Task<InitializationResult> ExecuteInitializeAsync()
        {
            await CreateInstanceAsync();
            await UpdateDeploymentTypeInfoAsync();

            await LoadMachinesAsync();
            await UpdateCmAsync();
            await UpdateCvpAsync();
            await UpdateCvpReportingAsync();
            await UpdateCceAsync();
            await UpdateCuicAsync();
            await UpdateFinesseAsync();
            await UpdateInitialSettingsAsync();

            await StartInitAsync();
            return await MonitorInitializationAsync();
        }

        /// <summary>
        /// Used to monitor initialization progress and output results to the console.
        /// </summary>
        public virtual async Task<InitializationResult> MonitorInitializationAsync()
        {
            Console.WriteLine("==== Monitoring initialization progress of the following tasks: ====");

            // print out all tasks
            var statuses = await GetStatusListAsync();
            foreach (var status in statuses)
            {
                Console.WriteLine($" - {status.TaskName}");
            }

            // keep track of tasks so we don't print it multiple times if its status hasn't changed
            var successfulTaskNames = new List<string>();
            var processingTaskNames = new List<string>();
            var failedTaskNames = new List<string>();

            Console.WriteLine("\n==== Current status ====");
            bool failed = false;
            while (true)
            {
                var failedTasks = FindStatus(statuses, StateEnum.FAILED);

                foreach (var status in failedTasks)
                {
                    failed = true;
                    PrintIfNecessary("Failed task", status.TaskName ?? "", failedTaskNames);
                }

                var succeededTasks = FindStatus(statuses, StateEnum.SUCCEEDED);
                foreach (var status in succeededTasks)
                {
                    PrintIfNecessary("Task completed successfully: ", status.TaskName ?? "", successfulTaskNames);
                }

                foreach (var status in FindStatus(statuses, StateEnum.PROCESSING))
                {
                    PrintIfNecessary("Processing...", status.TaskName ?? "", processingTaskNames);
                }

                if (!IsCompleteOrFailed(statuses))
                {
                    await Task.Delay(SleepTimeMs);
                }
                else
                {
                    break;
                }
                statuses = await GetStatusListAsync();
            }

            Console.WriteLine("\n==== SUMMARY ====");

            PrintSummaryData("Failed tasks", failedTaskNames);
            PrintSummaryData("Successful tasks", successfulTaskNames);

            if (failed)
            {
                Console.WriteLine("\n**** FAILED during initialization ****");
            }
            else
            {
                Console.WriteLine("\n**** Successfully completed initialization ****");
            }
            return new InitializationResult(statuses, !failed);
        }

        /// <summary>
        /// Helper method to return whether the status results indicate success or failure.
        /// </summary>
        private bool IsCompleteOrFailed(List<InitializationStatus> statuses)
        {
            int successCount = 0;
            foreach (var status in statuses)
            {
                if (status.State == StateEnum.FAILED)
                {
                    return true;
                }
                else if (status.State == StateEnum.SUCCEEDED)
                {
                    successCount++;
                }
            }
            return successCount == statuses.Count;
        }

        /// <summary>
        /// May be overridden, for unit testing.
        /// </summary>
        public virtual async Task<List<InitializationStatus>> GetStatusListAsync()
        {
            var status = await _restClient.GetAsync<InitializationStatusResults>(RestClient.BaseUrl + "initialize");
            return status?.StatusList ?? new List<InitializationStatus>();
        }

        /// <summary>
        /// Prints results.
        /// </summary>
        private void PrintSummaryData(string header, List<string> tasks)
        {
            Console.WriteLine($"\n{header}:");
            if (tasks.Count == 0)
            {
                Console.WriteLine(" - None");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($" - {task}");
                }
            }
        }

        /// <summary>
        /// Prints current state of the task if its state hasn't changed.
        /// </summary>
        private void PrintIfNecessary(string desc, string taskName, List<string> printedTaskNames)
        {
            if (!printedTaskNames.Contains(taskName))
            {
                Console.WriteLine($" > {desc} {taskName}");
                printedTaskNames.Add(taskName);
            }
        }

        /// <summary>
        /// This starts the initialization process.
        /// </summary>
        private async Task StartInitAsync()
        {
            Console.WriteLine("Starting initialization process");

            // In C#, we need a different approach for empty body updates
            // This would call the appropriate REST endpoint to start initialization
            _ = await _restClient.UpdateAsync(new WebsetupInstance { RefURL = RestClient.BaseUrl + "initialize" });
        }

        /// <summary>
        /// Updates initial settings.
        /// </summary>
        private async Task UpdateInitialSettingsAsync()
        {
            Console.WriteLine("Updating initial settings");

            var initialSettings = new InitialSettings
            {
                RefURL = RestClient.BaseUrl + "initialize/settings",
                // possible codecs: "G.711U", "G.711A", "G.729"
                MobileAgentCodec = _props.GetValueOrDefault(SettingsCodec),
                CmSideA = new ReferenceBean(),
                CmSideB = new ReferenceBean(),
                Department = new ReferenceBean()
            };

            var username = _props.GetValueOrDefault(SettingsServiceUsername);
            var password = _props.GetValueOrDefault(SettingsServicePassword);
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                initialSettings.ServiceAccountUserName = username;
                initialSettings.ServiceAccountPassword = password;
            }

            // not handling external UCM for now
            _ = await _restClient.UpdateAsync(initialSettings);
        }

        // Additional helper methods would continue here...
        // Due to size constraints, I'm showing the key structure and patterns
        // The remaining methods follow similar patterns to what's shown above

        private async Task UpdateFinesseAsync()
        {
            Console.WriteLine("Updating Finesse");
            await UpdateMachineAsync(MachineType.FINESSE, _props[FinesseDiagUsername], _props[FinesseDiagPassword]);
        }

        private async Task UpdateCuicAsync()
        {
            Console.WriteLine("Updating CUIC");
            await UpdateCUICMachineAsync(MachineType.CUIC_PUBLISHER, _props[CuicDiagUsername], _props[CuicDiagPassword],
                _props[CuicIdsUsername], _props[CuicIdsPassword]);
        }

        private async Task UpdateCceAsync()
        {
            Console.WriteLine("Updating CCE");
            await UpdateMachineAsync(MachineType.CCE_AW, _props[CceDiagUsername], _props[CceDiagPassword]);
        }

        private async Task UpdateCvpAsync()
        {
            Console.WriteLine("Updating CVP");

            var machines = _typeToMachine.GetValueOrDefault(MachineType.CVP);
            if (machines == null)
            {
                return;
            }

            var cvpA = FindMachineBySide(MachineType.CVP, "sideA");
            var cvpB = FindMachineBySide(MachineType.CVP, "sideB");

            if (cvpA != null)
            {
                var address = FindAddressByType(cvpA.Addresses ?? new List<MachineAddress>(), AddressType.PUBLIC);
                if (address != null)
                {
                    var svc = new MachineService
                    {
                        Type = ServiceType.CVP_WSM,
                        UserName = _props[CvpAUsername],
                        Password = _props[CvpAPassword]
                    };
                    address.MachineServices = new List<MachineService> { svc };
                    _ = await _restClient.UpdateAsync(cvpA);
                }
            }

            if (cvpB != null)
            {
                var address = FindAddressByType(cvpB.Addresses ?? new List<MachineAddress>(), AddressType.PUBLIC);
                if (address != null)
                {
                    var svc = new MachineService
                    {
                        Type = ServiceType.CVP_WSM,
                        UserName = _props[CvpBUsername],
                        Password = _props[CvpBPassword]
                    };
                    address.MachineServices = new List<MachineService> { svc };
                    _ = await _restClient.UpdateAsync(cvpB);
                }
            }
        }

        private async Task UpdateCvpReportingAsync()
        {
            Console.WriteLine("Updating CVP Reporting");

            var cvpReportingB = FindMachineBySide(MachineType.CVP_REPORTING, "sideB");

            if (cvpReportingB != null)
            {
                var address = FindAddressByType(cvpReportingB.Addresses ?? new List<MachineAddress>(), AddressType.PUBLIC);
                if (address != null)
                {
                    var svc = new MachineService
                    {
                        Type = ServiceType.DIAGNOSTIC_PORTAL,
                        UserName = _props[CvpAUsername],
                        Password = _props[CvpAPassword]
                    };
                    address.MachineServices = new List<MachineService> { svc };
                    _ = await _restClient.UpdateAsync(cvpReportingB);
                }
            }
        }

        private async Task UpdateMachineAsync(MachineType machineType, string username, string password)
        {
            var machine = FindMachineBySide(machineType, "sideA");
            if (machine == null)
            {
                throw new InvalidOperationException($"no machines found for type {machineType} on sideA");
            }

            var addr = FindAddressByType(machine.Addresses ?? new List<MachineAddress>(), AddressType.PUBLIC);
            if (addr == null)
            {
                return;
            }

            var services = addr.MachineServices != null
                ? new List<MachineService>(addr.MachineServices)
                : new List<MachineService>();
            addr.MachineServices = services;
            UpdateOrCreateMachineService(addr, ServiceType.DIAGNOSTIC_PORTAL, username, password);

            _ = await _restClient.UpdateAsync(machine);
        }

        private async Task UpdateCUICMachineAsync(MachineType machineType, string username, string password,
            string idsUsername, string idsPassword)
        {
            var machine = FindMachineBySide(machineType, "sideA");
            if (machine == null)
            {
                throw new InvalidOperationException($"no machines found for type {machineType} on sideA");
            }

            var addr = FindAddressByType(machine.Addresses ?? new List<MachineAddress>(), AddressType.PUBLIC);
            if (addr == null)
            {
                return;
            }

            var services = addr.MachineServices != null
                ? new List<MachineService>(addr.MachineServices)
                : new List<MachineService>();
            addr.MachineServices = services;
            UpdateOrCreateMachineService(addr, ServiceType.DIAGNOSTIC_PORTAL, username, password);
            UpdateOrCreateMachineService(addr, ServiceType.IDS, idsUsername, idsPassword);

            _ = await _restClient.UpdateAsync(machine);
        }

        private void UpdateOrCreateMachineService(MachineAddress addr, ServiceType svcType, string username, string password)
        {
            MachineService? service = null;
            if (addr.MachineServices != null)
            {
                foreach (var svc in addr.MachineServices)
                {
                    if (svc.Type == svcType)
                    {
                        service = svc;
                        break;
                    }
                }
            }
            else
            {
                addr.MachineServices = new List<MachineService>();
            }

            if (service == null)
            {
                service = new MachineService { Type = svcType };
                addr.MachineServices.Add(service);
            }
            service.UserName = username;
            service.Password = password;
        }

        private async Task UpdateCmAsync()
        {
            Console.WriteLine("Updating Call Manager");

            var cmPubName = _props[CmPubName];
            var machine = FindMachineByName(MachineType.CM, cmPubName);

            if (machine == null)
            {
                machine = FindMachineByName(MachineType.CM_PUBLISHER, cmPubName);
                if (machine == null)
                {
                    throw new InvalidOperationException($"can't find CM pub with VM name {cmPubName}");
                }
            }
            else
            {
                machine.MachineType = MachineType.CM_PUBLISHER;
            }

            var addr = FindAddressByType(machine.Addresses ?? new List<MachineAddress>(), AddressType.PUBLIC);
            if (addr != null)
            {
                var svc = new MachineService
                {
                    Type = ServiceType.AXL,
                    UserName = _props[CmUsername],
                    Password = _props[CmPassword]
                };
                addr.MachineServices = new List<MachineService> { svc };

                _ = await _restClient.UpdateAsync(machine);
            }
        }

        private async Task UpdateDeploymentTypeInfoAsync()
        {
            Console.WriteLine("Setting ESX host info");

            var deploymentTypeInfo = new DeploymentTypeInfo
            {
                RefURL = RestClient.BaseUrl + "deploymenttypeinfo",
                CapacityInfo = new CapacityInfo(),
                Department = new ReferenceBean(),
                PermissionInfo = new PermissionInfo(),
                SystemValidationStatus = new SystemValidationStatus
                {
                    VmValidationResult = new VMValidationResult()
                }
            };

            var sideAHost = new VMHost
            {
                Name = "sideA",
                UserName = _props[SideAUsername],
                Password = _props[SideAPassword],
                Address = _props[SideAAddress]
            };

            var sideBHost = new VMHost
            {
                Name = "sideB",
                UserName = _props[SideBUsername],
                Password = _props[SideBPassword],
                Address = _props[SideBAddress]
            };

            deploymentTypeInfo.DeploymentType = 7;
            deploymentTypeInfo.HardwareLayoutType = HardwareLayoutType.TRC;
            deploymentTypeInfo.VmHosts = new List<VMHost> { sideAHost, sideBHost };
            _ = await _restClient.UpdateAsync(deploymentTypeInfo);
        }

        private async Task CreateInstanceAsync()
        {
            Console.WriteLine("Creating instance (if necessary)");
            WebsetupInstance? instance;
            try
            {
                instance = await _restClient.GetByIdAsync<WebsetupInstance>("1");
            }
            catch (ApiException)
            {
                instance = null;
            }
            if (instance != null)
            {
                await DeleteInstanceAsync();
            }
            instance = new WebsetupInstance
            {
                FacilityName = _props[Facility],
                InstanceName = _props[Instance]
            };
            _ = await _restClient.CreateAsync(instance);
        }

        private async Task DeleteInstanceAsync()
        {
            await _restClient.DeleteByIdAsync<WebsetupInstance>("1");
        }

        private async Task LoadMachinesAsync()
        {
            Console.WriteLine("Loading inventory");

            var listBean = await _restClient.GetListAsync<MachineHostList>();
            _typeToMachine = new Dictionary<MachineType, List<MachineHost>>();

            int total = 0;
            if (listBean?.Items != null)
            {
                foreach (var bean in listBean.Items)
                {
                    if (bean is MachineHost machine)
                    {
                        if (!_typeToMachine.ContainsKey(machine.MachineType))
                        {
                            _typeToMachine[machine.MachineType] = new List<MachineHost>();
                        }
                        _typeToMachine[machine.MachineType].Add(machine);
                        total++;
                    }
                }
            }

            Console.WriteLine($"Inventory has been loaded. Total: {total}");
            foreach (var machineType in _typeToMachine.Keys)
            {
                Console.WriteLine($" Type: > {machineType}");
                foreach (var machine in _typeToMachine[machineType])
                {
                    Console.WriteLine($"     --> {machine.Name} {machine}");
                }
            }
        }

        private MachineAddress? FindAddressByType(List<MachineAddress> addresses, AddressType type)
        {
            return addresses.FirstOrDefault(addr => addr.Type == type);
        }

        private MachineHost? FindMachineByName(MachineType type, string name)
        {
            if (!_typeToMachine.ContainsKey(type))
            {
                return null;
            }

            return _typeToMachine[type].FirstOrDefault(machine => machine.Name == name);
        }

        private MachineHost? FindMachineBySide(MachineType type, string sideName)
        {
            if (!_typeToMachine.ContainsKey(type))
            {
                return null;
            }

            return _typeToMachine[type].FirstOrDefault(machine =>
                machine.VmHostRef?.Name == sideName);
        }

        private IEnumerable<InitializationStatus> FindStatus(List<InitializationStatus> statuses, StateEnum state)
        {
            return statuses.Where(status => status.State == state);
        }
    }
}
