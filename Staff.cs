using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

public class Staff{
  
    public string getStudentId(){
		return sid;
  }

  // add item with given code and qty to the student's cart
  public void addItemToInventory(String code, double qty){
		cart.put(code, qty);
 }

}
