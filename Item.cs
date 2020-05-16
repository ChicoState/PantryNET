using System;
using System.Collections;

public class Item {

  private String name;
  private int quantity;
  private double price;
  private int productid = 0;
  private boolean upc = false;
  private DateTime CheckOutDate;
  private DateTime CheckInDate;

   //function to set the expirydate
  public void setCheckOutdate(DateTime d)
  {
    CheckOutDate = d;
  }
  //function to set rentaldate
  public void setCheckIndate(DateTime d)
  {
    CheckInDate = d;
  }
  //function to get rental date
  public DateTime getCheckOutDate()
  {
    return CheckOutDate;
  }
  //function to get expiry date
  public DateTime getCheckInDate()
  {
    return CheckInDate;
  }
  //function to set the name of Item
  public void setItemName(String n)
  {
    name = n;
  }
  //functionto set the quantity of Item
  public void setItemQuantity(int q)
  {
    quantity = q;
  }
  //function to set the price of the Item
  public void setPrice(int p)
  {
    price = p;
  }
  //function to set the code of the item
  public void setProductcode(int i)
  {
    productid = i;
  }
  //function to get the name of the item
  public String getItemName()
  {
    return name;
  }
  //function to get the quantity of the item
  public int getItemQuantity()
  {
    return quantity;
  }
  //function to get the price of the item
  public int getPrice()
  {
    return price;
  }
  //function to get the code of the item
  public int getItemCode()
  {
    return productid;
  }
  //Function to display the details of the item
  public void displayItem()
  {
    Console.WriteLine(name,quantity,price,productid);

  }
  //set the UPC code to false
  public void setUPC(Boolean k)
  {
    upc = k;
  }
  //set the UPC code to false
  public Boolean isUPC()
  {
    return upc;
  }



}
