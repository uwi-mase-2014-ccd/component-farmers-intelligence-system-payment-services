using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

/// <summary>
/// Summary description for DatabaseConnection
/// </summary>
/// 
namespace CreditCardPaymentModel
{
public class DataConnection
{
    //private static string Connection
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //    //get { return "Data Source=WOLFPACK\\SQLEXPRESS;Initial Catalog=CreditCardPayment;Integrated Security=True"; }

    //    //set { }
    //}

    private static CardDetail CardCheck(string cardnum)
        {
            using (CreditCardPaymentEntities Entities = new CreditCardPaymentEntities())
            {
                return Entities.CardDetails.Where(e => e.card_num == cardnum).FirstOrDefault();
            }
        }


    public static bool ProcessCard(string cardnum, string amount, string cvv, string expiredate, string name, string add1,
        string add2, string country, string email, string account, string cardtype)
    {
        Random random = new Random();
        int limit = random.Next(25000, 1500000);
        int payment = Convert.ToInt32(amount);
        int merchent = Convert.ToInt32(account);
        int cvvnumber = Convert.ToInt32(cvv);
        DateTime date = Convert.ToDateTime(expiredate);

        CardDetail check = CardCheck(cardnum);

        if (check == null)
        {
            CardDetail c = new CardDetail();
            c.card_num = cardnum;
            c.cvv = Convert.ToInt32(cvv);
            c.balance = limit;
            c.expiration_dt = Convert.ToDateTime(expiredate);
            c.card_name = name;
            c.addrress1 = add1;
            c.addrress2 = add2;
            c.country = country;
            c.email = email;
            c.card_type = cardtype;

            using (CreditCardPaymentEntities Entities = new CreditCardPaymentEntities())
            {
                try
                {
                    Entities.AddToCardDetails(c);
                    Entities.SaveChanges();
                    check = c;
                }
                catch
                {
                    return false;
                }

            }
        }

        using (CreditCardPaymentEntities Entities = new CreditCardPaymentEntities())
        {

            var val = Entities.CardDetails.FirstOrDefault(e => e.card_name == check.card_name);

            if(val.cvv != cvvnumber)
            {
                return false;
            }

            if(val.expiration_dt != date)
            {
                return false;
            }

        if (check.balance >= payment)
        {
            Tran t = new Tran();
            t.trans_dt = DateTime.Now;
            t.trans_amt = payment;
            t.acc_num = merchent;
            t.card_num = cardnum;
            t.email_message = "Successful";
  
                try
                {
                    
                    val.balance = check.balance - payment;
                    Entities.AddToTrans(t);
                    Entities.SaveChanges();
                }
                catch
                {
                    return false;
                }

            }
        else
        {
            return false;
        }

        }

        return true;

        }
       


        

    }
}
