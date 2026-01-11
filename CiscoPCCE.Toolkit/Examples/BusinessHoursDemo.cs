using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk;
using CiscoPCCE.Toolkit.Sdk.Helpers;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for Business Hours operations.
    /// </summary>
    public class BusinessHoursDemo
    {
        private static RestClient? restClient = null;
        private const string BusinessHourNamePrefix = "DemoBH";

        public static async Task Main(string[] args)
        {
            // Create a new RESTClient object
            //args[0] - IP of AW-HDS
            //args[1] - user name(with domain)
            //args[2] - password
            if (args.Length < 3)
            {
                Console.WriteLine("BusinessHoursDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            restClient = new RestClient(args[0], args[1], args[2]);
            await DemoBusinessHoursAsync(restClient);
        }

        private static async Task DemoBusinessHoursAsync(RestClient restClient)
        {
            BusinessHour? businessHour1 = null;
            BusinessHour? businessHour2 = null;

            try
            {
                // -- Create a business hour
                businessHour1 = await CreateAndGetBusinessHourConfigAsync(restClient, BusinessHourNamePrefix + "1");

                // -- Update the business hour
                await UpdateAndVerifyBusinessHourConfigAsync(restClient, businessHour1);

                // -- Create 1 more business hour
                businessHour2 = await CreateAndGetBusinessHourConfigAsync(restClient, BusinessHourNamePrefix + "2");

                // Get the list of the Business hours created
                await GetBusinessHoursListAsync(restClient);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
            finally
            {
                // *** Finally Delete everything
                if (businessHour1?.RefURL != null)
                {
                    await restClient.DeleteAsync(businessHour1.RefURL);
                    Console.WriteLine($"Deleted Business Hour: {businessHour1.RefURL}");
                }
                if (businessHour2?.RefURL != null)
                {
                    await restClient.DeleteAsync(businessHour2.RefURL);
                    Console.WriteLine($"Deleted Business Hour: {businessHour2.RefURL}");
                }
                await GetBusinessHoursListAsync(restClient);
            }
        }

        private static async Task GetBusinessHoursListAsync(RestClient restClient)
        {
            try
            {
                var businessHourList = await restClient.GetListAsync<BusinessHourList>(BusinessHourNamePrefix);
                Console.WriteLine($"Number of Business Hours retrieved on LIST: {businessHourList?.Items?.Count ?? 0}");
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
        }

        private static async Task<BusinessHour?> CreateAndGetBusinessHourConfigAsync(RestClient restClient, string bhName)
        {
            var bean = GetBusinessHourForCreate(bhName);
            var refUrl = await restClient.CreateAndGetAsync(bean);
            BusinessHour? businessHour = null;
            if (refUrl != null)
            {
                businessHour = await restClient.GetAsync<BusinessHour>(refUrl);
                Console.WriteLine($"Business Hour created: {businessHour?.RefURL}");
            }
            return businessHour;
        }

        /// <summary>
        /// Create a business Hour object for Create.
        /// </summary>
        private static BusinessHour GetBusinessHourForCreate(string bhName)
        {
            var businessHourConfiguredStatus = new BusinessHourConfiguredStatus
            {
                Status = 1,
                StatusReason = new ReferenceBean
                {
                    RefURL = "/unifiedconfig/config/businesshourstatusreason/5000"
                },
                Department = new ReferenceBean()
            };

            var timeZoneLocationRef = new ReferenceBean
            {
                RefURL = "/unifiedconfig/config/timezone/v2/5000"
            };

            var bh = new BusinessHour
            {
                Name = bhName,
                Type = 1,
                Description = "This is for Business Hours Demo",
                ConfiguredStatus = businessHourConfiguredStatus,
                Timezone = timeZoneLocationRef,
                Department = new ReferenceBean()
            };

            var specialDayScheduleList = new List<SpecialDaySchedule>();

            var specialDaySchedule = new SpecialDaySchedule
            {
                Date = "04-02-3019",
                StartTime = "03:26",
                EndTime = "04:16",
                Description = "Test",
                Status = 1,
                StatusReason = new ReferenceBean
                {
                    RefURL = "/unifiedconfig/config/businesshourstatusreason/5000"
                },
                Department = new ReferenceBean()
            };
            specialDayScheduleList.Add(specialDaySchedule);
            bh.SpecialDaySchedules = specialDayScheduleList;

            var weekDayScheduleList = new List<WeekDaySchedule>();

            var weekDaySchedule = new WeekDaySchedule
            {
                DayOfWeek = 1,
                StartTime = "20:20",
                EndTime = "23:00",
                Department = new ReferenceBean()
            };
            weekDayScheduleList.Add(weekDaySchedule);

            bh.WeekDaySchedules = weekDayScheduleList;

            return bh;
        }

        /// <summary>
        /// Update a business Hour object and verify that it's updated.
        /// </summary>
        private static async Task UpdateAndVerifyBusinessHourConfigAsync(RestClient restClient, BusinessHour bh)
        {
            Console.WriteLine($"Business Hour time zone before update: {bh.Timezone?.RefURL}");

            var timeZoneLocationRef = new ReferenceBean
            {
                RefURL = "/unifiedconfig/config/timezone/v2/5001"
            };

            bh.Timezone = timeZoneLocationRef;
            var updatedBH = await restClient.UpdateAndGetBeanAsync(bh);
            Console.WriteLine($"Business Hour updated: {updatedBH?.RefURL}");
            Console.WriteLine($"Business Hour time zone after update: {bh.Timezone?.RefURL}");
        }
    }
}
