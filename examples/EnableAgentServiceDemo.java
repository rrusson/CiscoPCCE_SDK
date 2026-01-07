package com.cisco.ccbu.cce.unifiedconfig.toolkit.examples;


import com.cisco.ccbu.cce.unifiedconfig.toolkit.RESTClient;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.bean.Agent;


/**
 * Example code for creating agent with agent service enabled.
 *
 * Command line launch: mvn exec:java -Dexec.mainClass="com.cisco.ccbu.cce.unifiedconfig.toolkit.examples.EnableAgentServiceDemo" -Dexec.args="10.86.135.193 administrator@test.com abc123="
 */
public class EnableAgentServiceDemo {

    public static void main(String[] args) {

        if(args.length < 3){
            System.out.println("EnableAgentServiceDemo requires 3 parameters: hostname username (with @domain) password");
            System.exit(0);
        }

        // Create a new RESTClient object with the IP of AW HDS
        RESTClient restClient = new RESTClient(args[0], args[1], args[2]);
        DemoUtils.checkPCCEDeploymentType(restClient);

        try {
            enableAgentServiceDemo(restClient);
        } catch (Exception e){
            System.out.println("Exception occured: "+e.getMessage());
        }
    }

    private static void enableAgentServiceDemo(RESTClient restClient) throws ClassNotFoundException {
        // Create a new agent with 3 agent services enabled, "Transcript", "AgentAnswers", "VAVTranscript"
        String payload = "{\"agentServicesEnabled\": [{\"agentService\": [\"AgentAnswers\",\"Transcript\", \"VAVTranscript\"]}]," +
                "    \"person\": {" +
                "        \"ecePerson\": false," +
                "        \"firstName\": \""+DemoUtils.generateUniqueString("firstName", 1)+"\"," +
                "        \"lastName\": \""+DemoUtils.generateUniqueString("lastName", 1)+"\"," +
                "        \"loginEnabled\": true," +
                "        \"ssoEnabled\": false," +
                "        \"userName\": \""+DemoUtils.generateUniqueString("userName", 1)+"\"" +
                "    }" +
                "}";

        // -- Create and get the agent
        Agent newAgent = restClient.createAndGet_JSONPayload(payload, "agent", Class.forName("com.cisco.ccbu.cce.unifiedconfig.toolkit.bean.Agent"));
        System.out.println("Agent created: " + newAgent.getRefURL());
        System.out.println("Agent Services enabled for the agent: " + newAgent.getAgentServicesEnabled());

        // delete the agent
        restClient.delete(newAgent.getRefURL());
        System.out.println("Deleted Agent: " + newAgent.getRefURL());
    }
}
