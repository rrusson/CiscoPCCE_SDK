package com.cisco.ccbu.cce.unifiedconfig.toolkit.examples;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.ApiException;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.RESTClient;
import com.sun.jersey.api.client.ClientResponse;

/**
 * Example code for retrieving and syncing CCAI config.
 *
 * Command line launch: mvn exec:java -Dexec.mainClass="com.cisco.ccbu.cce.unifiedconfig.toolkit.examples.CCAIConfigDemo" -Dexec.args="10.86.135.193 administrator@test.com abc123="
 */
public class CCAIConfigDemo {

    private static RESTClient restClient = null;

    /**
     * Validates the arguments
     */
    public static void main(String[] args) {
        // Create a new RESTClient object
        //args[0] - IP of AW-HDS
        //args[1] - user name(with domain)
        //args[2] - password
        if(args.length < 3) {
            System.out.println("CCAIConfigDemo requires 3 parameters: hostname username (with @domain) password");
            System.exit(0);
        }

        restClient = new RESTClient(args[0], args[1], args[2]);
        demoCCAIConfig();
    }

    private static void demoCCAIConfig() {
        getCCAIConfig();
        getGlobalCCAIConfig();
        syncGlobalCCAIConfig();
    }

    private static void getCCAIConfig() {
        try {
            String ccaiConfig = restClient.getList("contactcenterai/config");
            System.out.println("****************************************************************************************************");
            System.out.println("****************************************************************************************************");
            System.out.println("CCAI Config list: " + ccaiConfig);
        } catch(ApiException e) {
            System.out.println("CCAI Config list fetch failed. Errors: "+e.getErrors());
        }
    }

    private static void getGlobalCCAIConfig() {
        try {
            System.out.println("****************************************************************************************************");
            System.out.println("****************************************************************************************************");
            String ccaiGlobalConfig = restClient.getList("contactcenterai/globalconfig");
            System.out.println("CCAI Global Config list: " + ccaiGlobalConfig);
        } catch(ApiException e) {
            System.out.println("CCAI Global Config list fetch failed. Errors: "+e.getErrors());
        }
    }

    private static void syncGlobalCCAIConfig() {
        try {
            System.out.println("****************************************************************************************************");
            System.out.println("****************************************************************************************************");
            ClientResponse response = restClient.create("contactcenterai/globalconfig/sync");
            System.out.println("CCAI Global Config sync is successful. Response status: " + response.getStatus());
        } catch(ApiException e) {
            System.out.println("CCAI Global Config sync failed. Errors: "+e.getErrors());
        }
    }
}