using System;
using System.Collections;

class Inventory {
  string name;
  double cost;
  int onhand;
  int id;

  public Inventory(string n, double c, int h, int k) {
    name = n;
    cost = c;
    onhand = h;
    id = k;
  }

  public override string ToString() {
    return
      String.Format("{0,-10}Cost: {1,6:C}  On hand: {2} ID: {3}",
                    name, cost, onhand, id);
  }
}

// Class to display inventory
public class displayInventory {
  public static void Main() {
    ArrayList inv = new ArrayList();
    Random rand = new Random(100);
    int code=  rand.Next(000000000, 999999999);
    Console.WriteLine(code);
    // Add elements to the list
    inv.Add(new Inventory("Apples", 5.95, 3, code));
    inv.Add(new Inventory("Oranges", 8.29, 2, code));
    inv.Add(new Inventory("Banana", 3.50, 4, code));
    inv.Add(new Inventory("Avocado", 19.88, 8, code));

    Console.WriteLine("Inventory list:");
    foreach(Inventory i in inv) {
      Console.WriteLine("   " + i);
    }
  }
}
//Enumeration for ITEM TYPE
public enum ItemType {

  RENTAL = 0,
  NONRENTAL = 1,
}

public class Invent {
  private static Inventory inventory = null;
	ArrayList inv = new ArrayList();
  var myList = new List<KeyValuePair<string, Item>>();
  private ItemType type;
  private string itemName;
  private int itemCode;
  private DateTime rentaldate;
  private DateTime expirydate;


	//Creating Instance for Inventory
	public static Inventory getInstance()
	{
		if (inventory == null)
			inventory = new Inventory();

		return inventory;
	}

	/*Remove the item from inventory (only when completely out of the item)*/
	public void removeFromInventory(String code)
	{
		if(isRental(code)){
			rented.put(code, myList.get(code));
		}
		myList.remove(code);
	}

  //function to find out the typeofItem
  public ItemT(String name, String type)
  {
    id = itemid;
    this.name = name;
    if(type.equals("rental"))
    {
      this.type = ItemType.RENTAL;
    }
    else {
      this.type = ItemType.NONRENTAL;
    }
  }
  //function to get details of Rental Item
  public void getRentalItem()
  {
    return itemName;

  }
  //function to set the expirydate
  public void setexpirydate(DateTime d)
  {
    expirydate = d;
  }
  //function to set rentaldate
  public void setrentaldate(DateTime d)
  {
    rentaldate = d;
  }
  //function to get rental date
  public DateTime getRentalDueDate()
  {
    return rentaldate;
  }
  //function to get expiry date
  public DateTime getExpiryDate()
  {
    return expirydate;
  }
	public void addToInventory(string code,Item item)
	{

    myList.Add(new KeyValuePair<code, Item>('234543678','fdkjfdk'));
	}


	public void reduceItemQuantity(String code, double noofitems) {

    var myItem = (from c in myList where item.id == code select c).FirstOrDefault();
        quantity=item.getcount()-noofitems;

	}

	public void increaseItemQuantity(String code, double quantity){
    var myItem = (from c in myList where item.id == code select c).FirstOrDefault();
        quantity=item.getcount()+noofitems;
	}


	public List<String, ArrayList<Item>> getAvailableItems() {
		return stock;
	}


  //Function to check if the Item is available in the Inventory.
  public Boolean getItemAvailability(String itemCode)
  {
    return myList.get(itemCode) != null;
  }

}
