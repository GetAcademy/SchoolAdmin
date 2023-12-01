// See https://aka.ms/new-console-template for more information

using SchoolAdmin;

Console.WriteLine("Hello, World!");

var startDate = new DateTime(2023, 8, 7);
var getAcademy = new School("GET Academy");
var emne1 = getAcademy.CreateSubject("Emne 1");
var emne2 = getAcademy.CreateSubject("Emne 2");
var emne3 = getAcademy.CreateSubject("Emne 3");
var mads= getAcademy.CreateStudent("Mads");
var gerry= getAcademy.CreateStudent("Gerry");
getAcademy.RegisterStudentForSubject(emne1, mads, startDate);
getAcademy.RegisterStudentForSubject(emne1, gerry, startDate);
getAcademy.RegisterStudentForSubject(emne2, mads, startDate);
getAcademy.RegisterStudentForSubject(emne3, gerry, startDate);

var theClass = getAcademy.GetClass(startDate);
theClass.GetWeekplan().Show();

mads.GetWeekplan().Show();
gerry.GetWeekplan().Show();


/*
 * Use case - en liten bit funksjonalitet
 * Klassediagram
 * Sekvensdiagram
 *
 * Tenk deg en videregående skole.
 * Lærer, elev, klasse og fag.
 * Lag en applikasjon for påmelding av elev til kurs.
 * Hver klasse har en lærer.
 * Hvert fag har ukentlige timer - inkl. hvilket rom.
 * Lag kode som kan produsere timeplan for en elev og for en lærer.
 * Lag lister over elev for hvert fag - og for hver klasse.
 * Noen fag er felles for en klasse - andre fag har elever fra forskjellige klasser.
 */