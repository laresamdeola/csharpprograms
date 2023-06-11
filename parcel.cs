using System;

class Parcels {

  public string place;
  public string postCodeAddress;
  
  public void ParcelLogic() {
    Console.WriteLine("What is the post code?");
    place = Console.ReadLine();
    //Console.WriteLine(place.Substring(0,2));
    
    if(place.Substring(0).Equals("M")) {
      postCodeAddress = "Manchester";
    }
    
    switch(place.Substring(0,2)) {
    case "BL":
      postCodeAddress = "Bolton";
      break;
    case "SK":
      postCodeAddress = "Stockport";
      break;
    case "OL":
      postCodeAddress = "Oldham";
      break;
    default:
      postCodeAddress = "This is not a valid postcode";
      break;
    }

    Console.WriteLine(postCodeAddress);
  }
};