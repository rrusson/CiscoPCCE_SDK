using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit
{
    public class InitializationResult
    {
        public InitializationResult(List<InitializationStatus>? statuses, bool successful)
        {
            Statuses = statuses;
            IsSuccessful = successful;
        }

        public List<InitializationStatus>? Statuses { get; }

        public bool IsSuccessful { get; }
    }
}
