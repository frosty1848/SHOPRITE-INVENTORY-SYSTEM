# SHOPRITE INVENTORY SYSTEM

SHOPRITE INVENTORY MANAGEMENT SYSTEM 
*************************************
	   C#.NET PROJECT
- In the initial stages the administrator is given the privilege to input the credentials to access the inventory.
 * the schema employed to this includes a textbox, label and a button.

- After the credentials are entered the admin has the opportunity to either submit to access the inventory or reset the instance to start the procedure again.
* first with the submit button the admin id is parsed into text and the password is also validated to grant admin access
*second with the reset button, the admin is given the opportunity to change the password as and when required.

* Tables are then created to store the various data of the respective entities which include the admin, user and the attendant.
ADMIN
-----
* ADMIN NAME.
* ADMIN ID(primary key).
* ATTENDANT ID(secondary key).
* PRODUCT ID(secondary key).
* PRODUCT CATEGORY ID(secondary key).
* ADMIN PASSWORD.
* ADMIN EMAIL.
* STOCK ID(secondary key).
* USER ID(secondary key).
* SALES ID(secondary key).

ATTENDANT 
---------
* ATTENDANT ID(primary key).
* ATTENDANT PASSWORD.
* TRANSACTIONS ID(secondary key).
* SALES ID(secondary key).
* PRODUCTS ID(secondary key)
* STOCK ID (secondary key)

PRODUCTS
---------
* PRODUCTS ID(primary key).
* PRODUCT NAME. 
* BARCODE ID.

USER
----
* USER ID(primary key).
* USER PASSWORD.
* USER NAME.
* USER EMAIL.
* PHONE NUMBER.

PRODUCTS CATEGORIES
-------------------
* PRODUCT CATEGORY NAME.
* PRODUCT CATEGORY ID(primary key).
* PRODUCT ID(secondary key).

SALES 
----
* NUMBER OF SALES.
* SALES ID(primary key).
* SALES REPORT.
* SALES RECEIPT.

TRANSACTIONS 
------------
* TRANSACTIONS ID(primary key).
* TRANSACTION RECORD.

STOCKS
------
* STOCK ID(primary key).
* STAKEHOLDER NAME.
* NUMBER OF SHARES.
* DATE OF ISSUE.
* SELLING PRICE.
* BUYING PRICE.
* STOCK HISTORY.

*****************************
* THE PROCESS BEGINS FROM THE 
* HOME PAGE WHERE YOU CHOOSE WHETHER TO LOGIN AS A AN ADMIN OR AN ATTENDANT

* AT THE ADMIN LOGIN => you input your username and password to validate the login and submit to go the admin page, the home page link to go to the, the reset link to reset the password.

* AT THE ATTENDANT LOGIN => You will input your username and password, an authentication is added to validate the login details to go to the next page which is the attendant page, a link to go back to the home page is added to the attendant login, then the forgot password to reset the password 

* THE ADMIN PAGE => At the admin page the admin has the opportunity to manage the product, product id, product category id, sales cost, date sold. He also has the privilege to insert and delete the input.The admin also has the privilege to create and reset the user login.

* THE ATTENDANT PAGE => The attendant is able to manage the close and start sales, able to scan the barcode, transaction record and detail, sales receipt generation, sales report generation, stock audit, sales report. In these respective sections the attendant is able to review and audit. 
