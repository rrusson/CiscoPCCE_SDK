package com.cisco.ccbu.cce.unifiedconfig.toolkit.examples;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.ApiException;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.RESTClient;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.ReferenceBean;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.bean.*;

import java.util.ArrayList;
import java.util.List;

public class BusinessHoursDemo {

    private static RESTClient restClient = null;
    private static final String BUSINESS_HOUR_NAME_PREFIX = "DemoBH";

    /**
     * Validates the arguments
     */
    public static void main(String[] args) {
        // Create a new RESTClient object
        //args[0] - IP of AW-HDS
        //args[1] - user name(with domain)
        //args[2] - password
        if(args.length < 3) {
            System.out.println("BusinessHourDemoDemo requires 3 parameters: hostname username (with @domain) password");
            System.exit(0);
        }

        restClient = new RESTClient(args[0], args[1], args[2]);
        demoBusinessHours(restClient);
    }

    private static void demoBusinessHours(RESTClient restClient) {
        BusinessHour businessHour1 = new BusinessHour();
        BusinessHour businessHour2 = new BusinessHour();
        try {
            // -- Create a business hour
            businessHour1 = createAndGetBusinessHourConfig(restClient, BUSINESS_HOUR_NAME_PREFIX+1);

            // -- Update the business hour
            updateAndVerifyBusinessHourConfig(restClient, businessHour1);

            // -- Create 1 more business hour
            businessHour2 = createAndGetBusinessHourConfig(restClient, BUSINESS_HOUR_NAME_PREFIX+2);

            // Get the list of the Business hours created
            getBusinessHoursList();
        } catch (ApiException e){
            System.out.println(e.getErrors());
        }
        finally {
            // *** Finally Delete everything
            if(businessHour1 != null && businessHour1.getRefURL() != null) {
                restClient.delete(businessHour1.getRefURL());
                System.out.println("Deleted Business Hour: " + businessHour1.getRefURL());
            }
            if(businessHour2 != null && businessHour2.getRefURL() != null) {
                restClient.delete(businessHour2.getRefURL());
                System.out.println("Deleted Business Hour: " + businessHour2.getRefURL());
            }
            getBusinessHoursList();
        }
    }

    private static void getBusinessHoursList() {
        try {
            BusinessHour.BusinessHourList businessHourList = restClient.getList(BusinessHour.BusinessHourList.class, BUSINESS_HOUR_NAME_PREFIX);
            System.out.println("Number of Business Hours retrieved on LIST: " + businessHourList.getItems().size());
        } catch(ApiException e) {
            System.out.println(e.getErrors());
        }
    }

    private static BusinessHour createAndGetBusinessHourConfig(RESTClient restClient, String bhName) {
        BusinessHour businessHour = restClient.createAndGetBean(getBusinessHourForCreate(bhName));
        System.out.println("Business Hour created: " + businessHour.getRefURL());
        return businessHour;
    }

    /**
     * create a business Hour object for Create.
     *
     * @return
     */
    private static BusinessHour getBusinessHourForCreate(String bhName) {
        BusinessHour bh = new BusinessHour();
        bh.setName(bhName);
        bh.setType(1);
        bh.setDescription("This is for Business Hours Demo");

        BusinessHourConfiguredStatus businessHourConfiguredStatus = new BusinessHourConfiguredStatus();
        businessHourConfiguredStatus.setStatus(1);

        ReferenceBean businessHourStatusReasonRef = new ReferenceBean();
        businessHourStatusReasonRef.setRefURL("/unifiedconfig/config/businesshourstatusreason/5000");
        businessHourConfiguredStatus.setStatusReason(businessHourStatusReasonRef);

        bh.setConfiguredStatus(businessHourConfiguredStatus);

        ReferenceBean timeZoneLocationRef = new ReferenceBean();
        timeZoneLocationRef.setRefURL("/unifiedconfig/config/timezone/v2/5000");

        bh.setTimezone(timeZoneLocationRef);

        List<SpecialDaySchedule> specialDayScheduleList = new ArrayList<>();

        SpecialDaySchedule specialDaySchedule = new SpecialDaySchedule();
        specialDaySchedule.setDate("04-02-3019");
        specialDaySchedule.setStartTime("03:26");
        specialDaySchedule.setEndTime("04:16");
        specialDaySchedule.setDescription("Test");
        specialDaySchedule.setStatus(1);
        specialDaySchedule.setStatusReason(businessHourStatusReasonRef);
        specialDayScheduleList.add(specialDaySchedule);
        bh.setSpecialDaySchedules(specialDayScheduleList);

        List<WeekDaySchedule> weekDayScheduleList = new ArrayList<>();

        WeekDaySchedule weekDaySchedule = new WeekDaySchedule();
        weekDaySchedule.setDayOfWeek(1);
        weekDaySchedule.setStartTime("20:20");
        weekDaySchedule.setEndTime("23:00");
        weekDayScheduleList.add(weekDaySchedule);

        bh.setWeekDaySchedules(weekDayScheduleList);

        return bh;
    }

    /**
     * Update a business Hour object and verify that it's updated.
     *
     * @return
     */
    private static void updateAndVerifyBusinessHourConfig(RESTClient restClient, BusinessHour bh) {
        System.out.println("Business Hour time zone before update: " + bh.getTimezone().getRefURL());

        ReferenceBean timeZoneLocationRef = new ReferenceBean();
        timeZoneLocationRef.setRefURL("/unifiedconfig/config/timezone/v2/5001");

        bh.setTimezone(timeZoneLocationRef);
        BusinessHour updatedBH = restClient.updateAndGetBean(bh);
        System.out.println("Business Hour updated: " + updatedBH.getRefURL());
        System.out.println("Business Hour time zone after update: " + bh.getTimezone().getRefURL());
    }
}