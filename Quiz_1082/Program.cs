class program{
    public static void Main(string[] args ){
    Console.WriteLine("chose Menu");
    Console.WriteLine("1 = มหาลัย");
    Console.WriteLine("2 = ตัวแทนที่ส่ง");
    Console.WriteLine("3 = ค่า FT แต่ละมหาลัย");
    Console.WriteLine("4 = มหาลัยที่ใช้น้อยที่สุด");

    string nameUniversity = inputNameUniversity();
    User user = new User(nameUniversity);
    user.printUniversity();

    string nameUniversity2 = inputNameUniversity();
    User user2 = new User(nameUniversity2);
    user2.printUniversity();

    string nameUniversity3 = inputNameUniversity();
    User user3 = new User(nameUniversity3);
    user3.printUniversity();

    string nameUniversity4 = inputNameUniversity();
    User user4 = new User(nameUniversity4);
    user4.printUniversity();
    }
   
public static string inputNameUniversity(){
    Console.Write("Input Menu : ");
    return Console.ReadLine();
    }   
}