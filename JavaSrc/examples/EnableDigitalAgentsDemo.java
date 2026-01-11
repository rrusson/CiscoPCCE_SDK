package com.cisco.ccbu.cce.unifiedconfig.toolkit.examples;


import com.cisco.ccbu.cce.unifiedconfig.toolkit.RESTClient;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.bean.Agent;


/**
 * Example code for creating a digital agent.
 *
 * Command line launch: mvn exec:java -Dexec.mainClass="com.cisco.ccbu.cce.unifiedconfig.toolkit.examples.EnableDigitalAgentsDemo" -Dexec.args="10.86.135.193 administrator@test.com abc123="
 */
public class EnableDigitalAgentsDemo {
    private static RESTClient restClient = null;

    public static void main(String[] args) {

        if(args.length < 3){
            System.out.println("EnableDigitalAgentsDemo requires 3 parameters: hostname username (with @domain) password");
            System.exit(0);
        }

        // Create a new RESTClient object with the IP of AW HDS
        restClient = new RESTClient(args[0], args[1], args[2]);

        try {
            enableDigitalAgentsDemo();
        } catch (Exception e){
            System.out.println("Exception occured: " + e.getMessage());
        }
    }

    private static void enableDigitalAgentsDemo() throws ClassNotFoundException {
        String payload = "{\"person\": {" +
                "        \"digitalChannel\": true," +
                "        \"emailAddress\": \"xyz@cisco.com\"," +
                "        \"ecePerson\": false," +
                "        \"firstName\": \""+DemoUtils.generateUniqueString("firstName", 1)+"\"," +
                "        \"lastName\": \""+DemoUtils.generateUniqueString("lastName", 1)+"\"," +
                "        \"loginEnabled\": true," +
                "        \"ssoEnabled\": true," +
                "        \"userName\": \""+DemoUtils.generateUniqueString("userName", 1)+"\"" +
                "    }" +
                "}";

        // -- Create and get the agent
        Agent newAgent = restClient.createAndGet_JSONPayload(payload, "agent", Class.forName("com.cisco.ccbu.cce.unifiedconfig.toolkit.bean.Agent"));
        System.out.println("Digital Agent created: " + newAgent.getRefURL());
        System.out.println("Digital Agent Email ID: " + newAgent.getPerson().getEmailAddress());

        // delete the digital agent
        restClient.delete(newAgent.getRefURL());
        System.out.println("Deleted Digital Agent: " + newAgent.getRefURL());
    }
}
