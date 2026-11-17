CREATE or alter TRIGGER trg_UpdateStudentView ON StudentView
INSTEAD OF UPDATE
AS
BEGIN
	-- distribute the updated infos to the two table down.

    -- Update PersonalInfo
    UPDATE PersonalInfo
    SET Name = I.Name, Address = I.Address
    FROM PersonalInfo
    INNER JOIN inserted I ON PersonalInfo.StudentID = I.StudentID;

    -- Update AcademicInfo
    UPDATE AcademicInfo
    SET Course = I.Course, Grade = I.Grade
    FROM AcademicInfo
    INNER JOIN inserted I ON AcademicInfo.StudentID = I.StudentID;
END;
--- Single-table views are updatable.
--- Multi-table views are updatable only if the update modifies one table at a time.
--- If you need to update both tables, you must use an INSTEAD OF UPDATE trigger.



--رجعت للكومنت بعد ما اكتشفت خطأي بس ما رح امسحه عشان لو حدا كان عنده نفس التساؤل 

--لما نعمل طريقة الاستاذ ونعدل على الجدوال بدل ما نعدل على الVirew 
--نفسها 
--بالمرات القادمة لو استخدمت الفيو رح تكون الداتا معدلة فيها لانها بتاخذ الداتا من الجدوال اللي اصلا تم تعديلهم بفعل الTrigger
--يعني الفيو ما بتحفظ وقت انشاءها الداتا اللي كانت بالجدوال
--بل بتاخذها كل مرة من الجدوال من اول وجديد
--يعني في حال صار اي تعديل على الجدوال رح يأثر على الفيو لما نستدعيها

--يا رب الفكرة تكون وصلت
