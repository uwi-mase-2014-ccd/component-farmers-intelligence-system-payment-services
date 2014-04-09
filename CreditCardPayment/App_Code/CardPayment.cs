using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Collections;
using CreditCardPaymentModel;


[Flags, Serializable]
public enum CardType
{
    MasterCard = 0x0001,
    VISA = 0x0002,
    //Amex = 0x0004,
    //DinersClub = 0x0008,
    //enRoute = 0x0010,
    Discover = 0x0020,
    //JCB = 0x0040,
    Unknown = 0x0080,
    All = CardType.Discover | CardType.MasterCard | CardType.VISA
}

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CardPayment : System.Web.Services.WebService
{

    private CardType _cardTypes;
    private bool _validateCardType;
    private decimal payamount;
    //private string email;
    private decimal accnum;
    //private int cardnumber;
    private int cvvnum;
    private DateTime expdate;
    //private string custname;


    //Validate input values
    [WebMethod]
    public String Validation(string cardnum, string amount, string cvv, string expiredate, string name, string add1,
        string add2, string country, string email, string account, string cardtype)
    {
        if (cardnum.Length == 0)
        {
            return "Please enter a credit card number";
        }

        if (amount.Length == 0)
        {
            return "Please enter a valid amount";
        }

        if (cvv.Length == 0)
        {
            return "Please enter a cvv number";
        }

        if (expiredate.Length == 0)
        {
            return "Please enter a card expiration date";
        }

        if (name.Length == 0)
        {
            return "Please enter a valid name";
        }

        if (add1.Length == 0)
        {
            return "Please enter a address 1";
        }

        if (country.Length == 0)
        {
            return "Please enter a country";
        }

        if (email.Length == 0)
        {
            return "Please enter a email address";
        }

        if (account.Length == 0)
        {
            return "Please enter a account number";
        }

        if (cardtype.Length == 0)
        {
            return "Please enter card type";
        }

        if (EvaluateIsValid(cardnum) != true)
        {
            return "Invalid Card Number";
        }

        try
        {
            payamount = Convert.ToDecimal(amount);
            cvvnum = Convert.ToInt32(cvv);
            expdate = Convert.ToDateTime(expiredate);
            accnum = Convert.ToDecimal(account);
        }
        catch (Exception e)
        {
            return e.Message;
        }

        if (payamount <= 0)
        {
            return "Amount cannot be 0 or less";
        }

        if (accnum <= 0)
        {
            return "Account number cannot be 0 or less";
        }

        if (ValidateCVVCode(cardtype, cvv) != true)
        {
            return "Invalid cvv number";
        }

        if (IsValidEmail(email) != true)
        {
            return "Invalid email address";
        }

        
       //ProcessCard(cardnum, amount, cvv);
       if(DataConnection.ProcessCard(cardnum, amount, cvv, expiredate, name, add1, add2, 
            country, email, account, cardtype) != true)
       {
           return "Invalid card information";
       }

        return "Transaction Successful";
    }

    //private bool ProcessCard(string cardnum, string amount, string cvv)
    //{
        
    //    try
    //    {
    
    //    }
    //    catch
    //    {

    //    }
    //    return true;
    //}


    public CardPayment()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        _validateCardType = true;
        _cardTypes = CardType.All | CardType.Unknown;	// Accept everything

    }

    public bool EvaluateIsValid(string cardnum)
    {
        if (_validateCardType)	// should the length be validated also?
        {
            // Check the length, if the length is fine then validate the card number
            if (IsValidCardType(cardnum))
                return ValidateCardNumber(cardnum);
            else
                return false;		// Invalid length
        }
        else
            // Check that the text box contains a valid number using the ValidateCardNumber method
            return ValidateCardNumber(cardnum);
    }

    /// <summary>
    /// Will ensure that the card is a valid length for the card type. If the
    /// card type isn't recognised it will return true by default.
    /// 
    /// The CreditCardValidator control also includes a CardTypes property that determines
    /// what card types should be accepted. If the card isn't recognised, and the Unknown card
    /// type is in the AcceptedCardTypes property then the DefaultLengthTest value will be
    /// returned.
    /// </summary>
    /// 
    private bool IsValidCardType(string cardNumber)
    {
        // AMEX -- 34 or 37 -- 15 length
        //if ((Regex.IsMatch(cardNumber, "^(34|37)")) && ((_cardTypes & CardType.Amex) != 0))
          //  return (15 == cardNumber.Length);

            // MasterCard -- 51 through 55 -- 16 length
        if ((Regex.IsMatch(cardNumber, "^(51|52|53|54|55)")) && ((_cardTypes & CardType.MasterCard) != 0))
            return (16 == cardNumber.Length);

            // VISA -- 4 -- 13 and 16 length
        else if ((Regex.IsMatch(cardNumber, "^(4)")) && ((_cardTypes & CardType.VISA) != 0))
            return (13 == cardNumber.Length || 16 == cardNumber.Length);

            // Diners Club -- 300-305, 36 or 38 -- 14 length
        //else if ((Regex.IsMatch(cardNumber, "^(300|301|302|303|304|305|36|38)")) && ((_cardTypes & CardType.DinersClub) != 0))
          //  return (14 == cardNumber.Length);

            // enRoute -- 2014,2149 -- 15 length
        //else if ((Regex.IsMatch(cardNumber, "^(2014|2149)")) && ((_cardTypes & CardType.DinersClub) != 0))
          //  return (15 == cardNumber.Length);

            // Discover -- 6011 -- 16 length
        else if ((Regex.IsMatch(cardNumber, "^(6011)")) && ((_cardTypes & CardType.Discover) != 0))
            return (16 == cardNumber.Length);

            // JCB -- 3 -- 16 length
        //else if ((Regex.IsMatch(cardNumber, "^(3)")) && ((_cardTypes & CardType.JCB) != 0))
          //  return (16 == cardNumber.Length);

            // JCB -- 2131, 1800 -- 15 length
        //else if ((Regex.IsMatch(cardNumber, "^(2131|1800)")) && ((_cardTypes & CardType.JCB) != 0))
          //  return (15 == cardNumber.Length);
        else
        {
            // Card type wasn't recognised, provided Unknown is in the CardTypes property, then
            // return true, otherwise return false.
            if ((_cardTypes & CardType.Unknown) != 0)

                //check for card in db 
                return true;
            else
                return false;
        }
    }

    private static bool ValidateCardNumber(string cardNumber)
    {
        try
        {
            // Array to contain individual numbers
            System.Collections.ArrayList CheckNumbers = new ArrayList();

            // So, get length of card
            int CardLength = cardNumber.Length;

            // Double the value of alternate digits, starting with the second digit
            // from the right, i.e. back to front.

            // Loop through starting at the end
            for (int i = CardLength - 2; i >= 0; i = i - 2)
            {
                // Now read the contents at each index, this
                // can then be stored as an array of integers

                // Double the number returned
                CheckNumbers.Add(Int32.Parse(cardNumber[i].ToString()) * 2);
            }

            int CheckSum = 0;	// Will hold the total sum of all checksum digits

            // Second stage, add separate digits of all products
            for (int iCount = 0; iCount <= CheckNumbers.Count - 1; iCount++)
            {
                int _count = 0;	// will hold the sum of the digits

                // determine if current number has more than one digit
                if ((int)CheckNumbers[iCount] > 9)
                {
                    int _numLength = ((int)CheckNumbers[iCount]).ToString().Length;
                    // add count to each digit
                    for (int x = 0; x < _numLength; x++)
                    {
                        _count = _count + Int32.Parse(((int)CheckNumbers[iCount]).ToString()[x].ToString());
                    }
                }
                else
                {
                    _count = (int)CheckNumbers[iCount];	// single digit, just add it by itself
                }

                CheckSum = CheckSum + _count;	// add sum to the total sum
            }

            // Stage 3, add the unaffected digits
            // Add all the digits that we didn't double still starting from the right
            // but this time we'll start from the rightmost number with alternating digits
            int OriginalSum = 0;
            for (int y = CardLength - 1; y >= 0; y = y - 2)
            {
                OriginalSum = OriginalSum + Int32.Parse(cardNumber[y].ToString());
            }

            // Perform the final calculation, if the sum Mod 10 results in 0 then
            // it's valid, otherwise its false.
            return (((OriginalSum + CheckSum) % 10) == 0);
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Should the length be validated also?
    /// </summary>
    /// 

    public bool ValidateCardType
    {
        get
        {
            return _validateCardType;
        }
        set
        {
            _validateCardType = value;
        }
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return true;
        }
        catch
        {
            return false;
        }
    }


    private bool ValidateCVVCode(string cardtype, string cvv)
    {

        int digits = 0;
        switch (cardtype.ToUpper())
        {
            case "MASTERCARD":
            case "EUROCARD":
            case "EUROCARD/MASTERCARD":
            case "VISA":
            case "DISCOVER":
                digits = 3;
                break;
            case "AMEX":
            case "AMERICANEXPRESS":
            case "AMERICAN EXPRESS":
                digits = 4;
                break;
            default:
                return false;
        }

        Regex regEx = new Regex("[0-9]{" + digits + "}");
        return (cvv.Length == digits && regEx.Match(cvv).Success);
    }
}
