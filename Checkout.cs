using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

public class Checkout{

  private static Inventory inventory = null;
	ArrayList inv = new ArrayList();
  var myList = new List<KeyValuePair<string, Item>>();
  private ItemType type;
  private string itemName;
  private int itemCode;
  private int checkoutID;
  private DateTime rentaldate;
  private DateTime expirydate;
// return rented item
public void returnRentedItem(String code, double qty){
  Checkout co = new Checkout();
  co.returnItem(code, qty);
}
//Set a unique ID for Checkout
public void setCheckoutID(int id)
{
  checkoutID = id;

}
//Get the unique checkout id
public int getCheckoutID()
{
  return checkoutID;
}

// Create a new checkout, get student's complete cart, and checkout
// everything. Then add the checkout to the transaction history
public void checkoutItems(){
  Checkout co = new Checkout();
  co.getCart(cart);
  co.checkoutAll();
  transactionHistory.add(co);
}
}

class New
{
    static void Main(string[] args)
    {
        var regularOrder = new RegularOrder();
        Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
        Console.WriteLine();

        var preOrder = new PreOrder();
        Console.WriteLine(preOrder.CalculateTotalOrderPrice());
        Console.WriteLine();
    }
}
