component-farmers-intelligence-system-payment-services
======================================================


The link to the webservice is below

http://www.sewebservice.somee.com/Payment/CardPayment.asmx


Payment Services
Description:

This component accepts the arguments listed below and outputs "success" or "fail"


Arguments:

-	cardnum: The credit card number
-	amount: The amount that is credited
-	cvv: The credit card verification value
-	expdate: The expiration date of the credit card (mm/dd/yyyy)
-	name: The name of the cardholder
-	add1 : The first line of the cardholder's address
-	add2: The second line of the cardholder's address
-	country: The country the card was registered
-	email: The email address of the cardholder
-	account: The account to which the money is being paid
-	cardtype: The type of credit card e.g. Visa, Discover

Sample Input:
{
      "cardnum": "4111111111111111",
      "amount": "5000",
      "cvv": "100",
      "expdate": "06/31/2017",
      "name": "John Doe",
      "add1": "123 Imaginary View",
      "add2": "Imaginary Land",
      "country": "jamaica",
      "email": "johndoe@yahoo.com",
      "account": "0123456789",
      "cardtype": "Visa"
}

Once valid information has been entered it will randomly assign a amount limit to the card and store the cvv number, as well as the card number. Any attempts made afterwards with that same card number will require the cvv number in its first use and it will minus the attempted amount from the random card limit until it has been maxed out.
