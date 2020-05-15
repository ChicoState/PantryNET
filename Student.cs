using System;
using System.Collections;

public class Student {

  Guid guid = Guid.NewGuid();
  string id = guid.ToString();
  private Student student;
  //private final long studentId;
	ArrayList<Checkout> transactionHistory = new ArrayList<>();

	ArrayList<UUID> studentT=new ArrayList<>();

	// generates random 9 digit student id
	Student() {

    Random rand = new Random(100);
    int code=  rand.Next(000000000, 999999999);
	}

	public string getStudentId(){
		return sid;
	}


	/* Returns checkout history of student */
	public ArrayList<Checkout> getTransactionHistory() {
		return transactionHistory;
	}

	// Get info about all items in the student's cart
	public HashMap<String, Double> getCartInfo(){
		int count = 1;
		for (Entry<String, Double> itm : cart.entrySet()) {
			System.out.println("\t" + count + ".");
			System.out.println("\tItem code: " + itm.getKey());
			System.out.println("\tItem quantity: " + itm.getValue());
			count++;
		}
		return cart;
	}

	// add item with given code and qty to the student's cart
	public void addItemToCart(String code, double qty){
		cart.put(code, qty);
	}

	// return rented item
	public void returnRentedItem(String code, double qty){
		Checkout co = new Checkout();
		co.returnItem(code, qty);
	}

	// Display complete Checkout History
	public void displayCheckoutHistory()
	{
		for (Checkout co : transactionHistory) {
			co.displayCheckoutInfo();
	   }
	}

}
