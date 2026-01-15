using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk.AgentApi;

namespace CiscoPCCE.Toolkit.Sdk.Interfaces
{
    public interface IAgentFunctions
    {
        /// <summary>
        /// Creates an agent
        /// </summary>
        /// <returns>The RefURL of the created agent</returns>
        Task<string?> CreateAgentAsync(Agent agent);

        /// <summary>
        /// Marks one agent for deletion
        /// </summary>
        /// <param name="agentId">The Id of the agent to delete</param>
        Task DeleteAgentAsync(string agentId);

        /// <summary>
        /// Helper to delete by Agent object refURL
        /// </summary>
        /// <param name="agent">The agent to delete</param>
        Task DeleteAgentAsync(Agent agent);

        /// <summary>
        /// Returns one Agent matching the <paramref name="agentId"/>
        /// </summary>
        /// <returns>The agent with the specified ID</returns>
        Task<Agent?> GetAgentAsync(string agentId);

        /// <summary>
        /// Searches for and returns first Agent matching on <paramref name="otherId"/> (e.g. employeeId)
        /// </summary>
        /// <returns>The agent with specified <paramref name="otherId"/> (but different from Cisco internal AgentId)</returns>
        Task<Agent?> GetAgentByOtherIdAsync(int otherId);

        /// <summary>
        /// Retrieves a list of agents
        /// </summary>
        /// <returns>A list of agents</returns>
        Task<List<Agent>?> GetAgentsAsync();

        /// <summary>
        /// Retrieves a list of agents matching the search criteria
        /// </summary>
        /// <param name="criteria">The search criteria</param>
        /// <returns>A list of agents matching the criteria</returns>
        Task<List<Agent>?> GetAgentsAsync(AgentSearchCriteria criteria);

        /// <summary>
        /// Updates one agent
        /// </summary>
        /// <param name="agent">The agent to update</param>
        /// <remarks>
        /// - When you change the team association for an agent or supervisor in Packaged CCE, the same change is updated in the corresponding collection in Unified Intelligence Center.
        /// - When you change the username and team association for a supervisor's record, the same changes are also updated in the corresponding user account in Unified Intelligence Center.
        /// - For an existing supervisor's record in Packaged CCE, if the value for the Supervisor parameter is set to false, the corresponding user account is deleted from Unified Intelligence Center.
        /// </remarks>
        Task<bool> UpdateAgentAsync(Agent agent);

        /// <summary>
        /// Updates one agent and returns the updated object.
        /// </summary>
        Task<Agent?> UpdateAndGetAgentAsync(Agent agent);
    }
}