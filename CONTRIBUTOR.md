
# Contributing to PantryNET

Our goal is to make a pantry project for the Chico State, like many other universities, which has a food pantry for students who do not have access to enough to eat.The pantry provides food for students for free by storing donated and wholesale purchased bulk foods.

We want to create a system to manage the inventory of a food pantry, as well as generate reports about the pantry's activities. We need to design a website that manages the information.

Our project keeps track of all the details of the Pantry activities. Details of classes are as below:

1. Staff
   It gets all the details from the Inventory, can add, delete and update Items and do checkouts as well.
   It generates Reports as well for the all checkouts done.

2. Student
   It handles only Item, Item quantity and ask staff to check it out selected Items.
3. Inventory

4. Item
   We have used Abstract Factory Design Pattern for this class       
   For Item class we used Abstract Factory Pattern for the better implementation of our Project. It provides an interface for creating families of related or dependent objects without specifying their concrete product classes.
   We interact with this interface to allow the client to access instances of the our ConcreteFactory concrete subclasses.

   1. Item (Client Class) :
      It uses interfaces declared by AbstractFactory and AbstractProduct classes
   2. AbstractFacoryItems <<interface>> :
      It declares an interface for operations that create abstract products
   3. Concrete Classes :
      It has three concrete classes to implement the operations and to create concrete product objects:
      1. RentalConcreteItem class-
      2. PerishableConcreteItem class-
      3. NonPerishableConcreteItem class-

5. Provider

6. Report
   We have used Builder Pattern for the Report Class report to generate two types of report.
   1. Perishable Items Report and
   2. Imapact Summary Report

   Used builder Design Pattern to separate the construction of a complex object from its representation so that the same construction process can create different representations.

   The classes and objects participating in this pattern are:
   1. Builder  (IReportBuilder) - specifies an abstract interface for creating parts of a Product object

   2. ConcreteBuilder -
      It has two Concrete builders
      1. PerishableItemsReport
      2. Impact_SummaryReport

      Concrete builder constructs and assembles parts of the report by implementing the Builder interface,
      defines and keeps track of the representation it creates. provides an interface for retrieving the report.

   3. Director (ReportBuilder)- It constructs an object using the Builder interface

   4. Product  (Report) -
      Represents the complex object under construction. ConcreteBuilder builds the report's internal representation and defines the process by which it's assembled.

7. CheckOut

# Short Links to Important Resources:
   docs: handbook / roadmap (you'll learn more about this in the roadmapping session)
   bugs: issue tracker / bug report tool
   comms: forum link, developer list, IRC/email

   Issue :

   The food pantry has acquired some kitchen appliances that can help students cook, such as pots, pans, cutting boards, and baking trays. The system should keep an inventory of these appliances as well as keep track of when students borrow any of the items. As an initial policy, the pantry plans to let students borrow any appliance for up to seven days. When they borrow an appliance, the system should indicate who borrowed it and when it is due to be returned. Once it has been returned, the system should show that it is available. However, since there are many of the same kinds of appliance (e.g. large pan), the system should show how many pans are available to be borrowed and how many are currently "out" (being borrowed and not yet returned).

   To solve the above Issue, we have created a new Enumeration function which will tell us if the Item is Rental or NonRental. Also, we have added the functionality of find out the details of Rental Item and added the due date of rental Items. To incorporate the changes for rental Item we created RentalConcreteItem to integrate in our project. For more details we have added the functions to find out the checkin and checkout of the rental Item. Also we will know the Id of the student who took the rental Item and the quantity of Item. In the Checkout class we added the checkout function which will give us all the details about the Item and the student. The UML after solving the issue is given:

   Issue : Issue for Rental Appliances #9(Closed)   
