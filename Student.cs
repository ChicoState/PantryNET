using System;
using System.Collections;

public class Student {

  Guid guid = Guid.NewGuid();
  string id = guid.ToString();
  private Student student;
  //private final long studentId;
  ArrayList<Checkout> transactionHistory = new ArrayList<>();
  ArrayList<UUID> studentT=new ArrayList<>();
  // function to generates random 9 digit student id
  Student() {
	  Random rand = new Random(100);
    	  int code=  rand.Next(000000000, 999999999);
	}
  public string getStudentId(){
		return sid;
  }

  // add item with given code and qty to the student's cart
  public void addItemToCart(String code, double qty){
		cart.put(code, qty);
 }


  // Display complete Checkout History
  public void displayCheckoutHistory()
  {
  	for (Checkout check : transactionHistory) {
  		check.displayCheckoutInfo();
  	  }
  }
 // return rented item
 public void returnRentedItem(String code, double qty){
	Checkout check = new Checkout();
	check.returnItem(code, qty);
 }

}
 // Get info about all items in the student's cart
  public ArrayList<keyvaluepair<String, Double>> getCartInfo(){
  int count = 1;
  for (studentT<String, Double> item : cart.entrySet()) {
	  
	   Console.WriteLine("-----------------------------------");
           Console.WriteLine("-----Details about the inventory Info-----");
           Console.WriteLine("");
	   Console.WriteLine(count);
	   Console.WriteLine("");
	   Console.WriteLine(count);
	   Console.WriteLine(item.getKey());
	   Console.WriteLine(item.getValue());
  	   count++;
  }
  return cart;
  }
