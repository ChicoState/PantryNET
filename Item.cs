using System;
using System.Collections;

public class Item {

  private String name;
  private int quantity;
  private double price;
  private int productid = 0;

  public void setName(String n)
  {
    name = n;
  }
  public void setQuantity(int q)
  {
    quantity = q;
  }
  public void setPrice(int p)
  {
    price = p;
  }
  public void setProductid(int i)
  {
    productid = i;
  }
  public String getName()
  {
    return name;
  }
  public int getQuantity()
  {
    return quantity;
  }
  public int getPrice()
  {
    return price;
  }
  public int getProductid()
  {
    return productid;
  }

  public void displayItem()
  {
    Console.WriteLine(name,quantity,price,productid);
  }
}
