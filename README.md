Update - 26.03.2014 - Tasks and Dead-lines
==========================================

Tasks
-----
Ghisa - Form 1,4
Moldovan - Form 3,5,7,8
Tudor - Form2
Iza - Detailed Database Diagram and Description (WPF basics)
Nandor - Source Code Structure, Documentation

Important Dates
---------------
Connection to GitHub through Visual Studio ( you have the tutorial below)  - 28.03.2014
Visual Interfaces Design - 02.04.2014
Group Meeting - 09.04.2014 16:00

Updates: https://www.google.com/calendar/embed?src=9f84t1tr6bf1qsdgpmoql7vfn8%40group.calendar.google.com&ctz=Europe/Bucharest

General Guidelines
=================
Groups:Admin, Member, Worker (Cleaning and Reception)
Visual Studio versions: All good if they work with git-hub, no compatibility issues, it synchronizes the root files
Button,Tab names should be named as follow: [Form name]_[Button or other name] - It can't have the Button1, Button2 names 

Github Install:
---------------
https://rionscode.wordpress.com/2013/04/19/integrating-and-using-github-in-visual-studio-2012/comment-page-1/

Roles
-----
Iza Birs - Database
Tudor Bala - Programmer
Ghisa Ioachim - Engineer Responsible with Quality Control
Moldovan Alexandru - Programmer
Verba Nandor - Guest Manager



Project Interfaces Description and Structure
===========================================

Main Page - Form1
-----------------
-Supports general information about Hotel
-Login page for Users, Employes and Admins
-Second Tab Create user
-Can go to Form2,Form3,Form4,Form5

Administrator - Form2
---------------------
-Has tabs for the following:
1.Employes: Modification, Addition, Deletion, General Review,Protmote to admin
2.Prices and Discounts: Can add prices modify/delete add discounts
3.Cleaning: Gives the manager the opportunity to Distribuite work for the Cleaning
4.Room Info:Shows the information of all the rooms and allows for the modification of the room status
5.Customer Page:Displayes Information about Customers and their Reservations
6.Statistics: Displayes Interesting statistics about the Hotel

Cleaning - Form3
----------------
-Displays all the rooms that are not Cleaned and need to be cleaned by the person in hand
-GIves the CLeaner the possibility to change the status of the room ( In need of cleanng, In progress, Cleaned)

Reception - Form4
-----------------
-Worker Form, Gives the possibility to Create or Delete reservations

Guest Page - Form5
------------------
-Shows the Rooms that the person has Reserver in the past and any current reservations, nad gives the possibility to delete these reservations if they are not less then 48 hours due,else it gives out hte managers phone number
-Can go to Reservations Form6 or Form7

Reservation Plan - Form6
------------------------
-Shows the floor plan of the Hotel and the availability of the rooms, and allows for reservations (opens Form8 for reservation)


Reservation List - Form7
------------------------
-Shows the available rooms categorized by type, price and capacity, has a built in search(opens Form8 for serervation)

Booking - Form8
---------------
-Requires the user to insert information that is needed for the reservation and and checks if the room is still availabe before saving



Hotel-PolyHilton
================

Created for Industrial Engineering Project Hotel C#
