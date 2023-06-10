using System;

class Parcels {

  public string place;
  public string postCodeAddress;
  
  public void ParcelLogic() {
    Console.WriteLine("What is the post code?");
    place = Console.ReadLine();
    //Console.WriteLine(place.Substring(0,2));
    
    if(place.Substring(0,2).Equals("BL")){
      postCodeAddress = "Bolton";
      Console.WriteLine(postCodeAddress);
    } else {
      Console.WriteLine("Place does not exist");
    }
  }
};