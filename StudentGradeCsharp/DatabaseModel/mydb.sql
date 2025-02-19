create table "Students"(
    "IdStudents" SERIAL,
    "Name" varchar(80),
    "Enrollment" varchar(13),
    CONSTRAINT pk_students PRIMARY KEY("IdStudents")
)

create table "SchoolTest"(
    "IdSchoolTest" SERIAL,
    "Title" varchar(100),
    "MaxWeight" decimal(10,2),
    CONSTRAINT pk_schooltest PRIMARY KEY("IdSchoolTest")
)

create table "Grade"(
    "IdStudents" SERIAL,
    "IdSchoolTest" SERIAL,
    "Weight" decimal(10,2),
    CONSTRAINT pk_grade PRIMARY KEY ("IdStudents","IdSchoolTest"),
    CONSTRAINT fk_studentgrade FOREIGN KEY("IdStudents") REFERENCES  "Students"("IdStudents"),
    CONSTRAINT fk_schooltestgrade FOREIGN KEY("IdSchoolTest") REFERENCES "SchoolTest"("IdSchoolTest")
)