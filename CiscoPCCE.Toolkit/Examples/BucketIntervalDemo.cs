using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for creating a bucket interval.
    /// </summary>
    public class BucketIntervalDemo
    {
        public static async Task Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("BucketIntervalDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            var restClient = new RESTClient(args[0], args[1], args[2]);
            await BucketIntervalDemoAsync(restClient);
        }

        private static async Task BucketIntervalDemoAsync(RESTClient restClient)
        {
            var bean = new BucketInterval
            {
                Name = "abcde",
                UpperBound1 = 123,
                Department = new ReferenceBean()
            };
            await restClient.CreateAndGetAsync(bean);
        }
    }
}
