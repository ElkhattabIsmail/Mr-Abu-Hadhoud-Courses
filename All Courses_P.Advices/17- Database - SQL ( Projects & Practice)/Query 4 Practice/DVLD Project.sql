restore database DVLD
from disk = 'C:\DVLD.bak'

use DVLD

EXEC sp_changedbowner 'sa';

GO
ALTER AUTHORIZATION ON DATABASE::DVLD TO [sa]
GO

select * from Countries
where CountryName = 'Morocco';

--سأقوم بشرح تفاصيل كل جدول والعلاقات بينها، وأوضح الأسباب المحتملة وراء تصميم هذا النموذج بهذا الشكل.

--### جدول Users
--- الحقول: UserID، UserName، Password، IsActive
--- التفاصيل: يحتوي على معلومات تسجيل الدخول للمستخدمين.
--- السبب: الاحتفاظ بمعلومات المستخدمين الذين لديهم صلاحيات للوصول للنظام.

--### جدول People
--- الحقول: PersonID، NationalID، FirstName، LastName، Gender، BirthDate، NationalityCountryID، وغيرها.
--- التفاصيل: يحتوي على المعلومات الشخصية للأفراد.
--- العلاقة: مرتبط بـ Users من خلال PersonID ومرتبط بـ Countries من خلال NationalityCountryID.
--- السبب: الاحتفاظ بمعلومات الأفراد بشكل منفصل عن معلومات الدخول لزيادة الأمان والتنظيم.

--### جدول Drivers
--- الحقول: DriverID، PersonID، CreatedBy، CreatedDate
--- التفاصيل: يحتوي على معلومات عن السائقين.
--- العلاقة: مرتبط بـ People من خلال PersonID.
--- السبب: فصل معلومات السائقين الذين قد يكون لهم سجل خاص بهم من المعلومات.

--### جدول Countries
--- الحقول: CountryID، CountryName
--- التفاصيل: يحتوي على أسماء الدول.
--- العلاقة: مرتبط بـ People من خلال NationalityCountryID.
--- السبب: الاحتفاظ بمعلومات الدول لتجنب التكرار وتحقيق المرجعية النسبية.

--### جدول Applications
--- الحقول: ApplicationID، ApplicantID، ApplicationDate، ApplicationTypeID، وغيرها.
--- التفاصيل: يحتوي على معلومات عن الطلبات المقدمة.
--- العلاقة: مرتبط بـ People من خلال ApplicantID ومرتبط بـ ApplicationTypes من خلال ApplicationTypeID.
--- السبب: تتبع الطلبات المقدمة من الأفراد بشكل مفصل.

--### جدول ApplicationTypes
--- الحقول: ApplicationTypeID، ApplicationTypeName
--- التفاصيل: يحتوي على أنواع الطلبات.
--- العلاقة: مرتبط بـ Applications من خلال ApplicationTypeID.
--- السبب: تحديد أنواع مختلفة من الطلبات لتصنيفها بشكل مناسب.

--### جدول DetainedLicenses
--- الحقول: DetainedID، LicenseID، DetainedDate، وغيرها.
--- التفاصيل: يحتوي على معلومات عن الرخص المحتجزة.
--- العلاقة: مرتبط بـ Licenses من خلال LicenseID.
--- السبب: تتبع الرخص التي تم احتجازها.

--### جدول InternationalLicenses
--- الحقول: InternationalLicenseID، ApplicationID، IssueDate، وغيرها.
--- التفاصيل: يحتوي على معلومات عن الرخص الدولية.
--- العلاقة: مرتبط بـ Applications من خلال ApplicationID.
--- السبب: فصل الرخص الدولية لتتبعها بشكل منفصل.

--### جدول LocalDrivingLicensesApplications
--- الحقول: LocalDrivingLicenseApplicationID، ApplicationID، LicenseID، وغيرها.
--- التفاصيل: يحتوي على معلومات عن طلبات رخص القيادة المحلية.
--- العلاقة: مرتبط بـ Applications من خلال ApplicationID ومرتبط بـ Licenses من خلال LicenseID.
--- السبب: تتبع طلبات رخص القيادة المحلية بشكل منفصل.

--### جدول TestAppointments
--- الحقول: TestAppointmentID، LocalDrivingLicenseApplicationID، AppointmentDate، وغيرها.
--- التفاصيل: يحتوي على معلومات عن مواعيد الاختبارات.
--- العلاقة: مرتبط بـ LocalDrivingLicensesApplications من خلال LocalDrivingLicenseApplicationID.
--- السبب: تتبع مواعيد الاختبارات المحددة للأفراد.

--### جدول Tests
--- الحقول: TestID، TestAppointmentID، Result، وغيرها.
--- التفاصيل: يحتوي على معلومات عن الاختبارات.
--- العلاقة: مرتبط بـ TestAppointments من خلال TestAppointmentID ومرتبط بـ TestTypes من خلال TestTypeID.
--- السبب: تتبع نتائج الاختبارات التي تم إجراؤها.

--### جدول TestTypes
--- الحقول: TestTypeID، TestTypeName
--- التفاصيل: يحتوي على أنواع الاختبارات.
--- العلاقة: مرتبط بـ Tests من خلال TestTypeID.
--- السبب: تصنيف أنواع الاختبارات المختلفة.

--### جدول LicenseClasses
--- الحقول: LicenseClassID، LicenseClassDescription
--- التفاصيل: يحتوي على فئات الرخص.
--- العلاقة: مرتبط بـ Licenses من خلال LicenseClassID.
--- السبب: تحديد الفئات المختلفة للرخص لتصنيفها بشكل مناسب.

--### جدول Licenses
--- الحقول: LicenseID، ApplicationID، LicenseClassID، IssueDate، ExpirationDate، وغيرها.
--- التفاصيل: يحتوي على معلومات عن الرخص.
--- العلاقة: مرتبط بـ Applications من خلال ApplicationID ومرتبط بـ LicenseClasses من خلال LicenseClassID.
--- السبب: تتبع الرخص الممنوحة للأفراد وتصنيفها حسب الفئة.



select * from Applications		           select * from Licenses
select * from Users				           select * from TestTypes
select * from Drivers			           select * from LocalDrivingLicenseApplications
select * from Countries			           select * from TestAppointments
select * from People			           select * from Tests
select * from ApplicationTypes	           select * from Tests
select * from LicenseClasses	           select * from Tests
select * from InternationalLicenses	       select * from Tests
select * from DetainedLicenses			   select * from Tests	