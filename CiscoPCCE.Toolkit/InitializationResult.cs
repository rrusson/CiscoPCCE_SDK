using System.Collections.Generic;
using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit
{
    public class InitializationResult
    {
        private readonly List<InitializationStatus>? statuses;
        private readonly bool successful;

        public InitializationResult(List<InitializationStatus>? statuses, bool successful)
        {
            this.statuses = statuses;
            this.successful = successful;
        }

        public List<InitializationStatus>? Statuses => statuses;

        public bool IsSuccessful => successful;
    }
}
