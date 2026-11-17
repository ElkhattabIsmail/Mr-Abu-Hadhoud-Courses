
select  * from LocalDrivingLicenseApplications
select * from ApplicationTypes
select * from Tests
select  * from TestAppointments
select  * from Drivers
select  * from Drivers_View




SELECT TotalTrialsPerTest = count(TestID)
 FROM LocalDrivingLicenseApplications INNER JOIN
      TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
 WHERE
 (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 31) 
 AND (TestAppointments.TestTypeID = 2)


 SELECT top 1 Found=1
 FROM LocalDrivingLicenseApplications INNER JOIN
      TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
 WHERE
 (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 30) 
 AND(TestAppointments.TestTypeID = 3)
 ORDER BY TestAppointments.TestAppointmentID desc