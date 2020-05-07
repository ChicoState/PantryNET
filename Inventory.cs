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

public class InventoryList {
  public static void Main() {
    ArrayList inv = new ArrayList();

    // Add elements to the list
    inv.Add(new Inventory("Apples", 5.95, 3, 1));
    inv.Add(new Inventory("Oranges", 8.29, 2, 2));
    inv.Add(new Inventory("Banana", 3.50, 4, 3));
    inv.Add(new Inventory("Avocado", 19.88, 8, 4));

    Console.WriteLine("Inventory list:");
    foreach(Inventory i in inv) {
      Console.WriteLine("   " + i);
    }
  }
}
