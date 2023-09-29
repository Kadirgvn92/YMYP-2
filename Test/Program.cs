namespace Test;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, This is My Student List..");


        List<string> list = new List<string>();
        list.Add("1 - Ahmet Yıldız");
        list.Add("2- Mehmet Mars");
        list.Add("3 - Saadettin Teksoy");
        list.Add("4 - Haluk Levent");
        list.Add("5 - Kadir GÜVEN");
        //Burada bir liste oluşturup öğrencilerimizi ekledik.

        List<string> intList = new List<string>();


        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
        //Burada öğrencilerimizi teker teker ekrana yazdırdık.

        List<bool> isStudentAttend = new List<bool>(new bool[list.Count]);
        isStudentAttend[0] = false;
        isStudentAttend[1] = false;
        isStudentAttend[2] = false;
        isStudentAttend[3] = false;
        isStudentAttend[4] = false;
        /*burada amacım bonus 2.sorudaki tüm öğrencilerin sınıfta olup olmadığını
        kontrol ettirmekti biraz chatGDPden yardım aldım..*/

        bool isAttend = true;

        bool isAllOkey = false;
        while (!isAllOkey)
        {
            if (isStudentAttend.TrueForAll(status => status)) // Bu mantığı chatGPT ile buldum..amacım bütün öğrencileri sınıfta olduğunda işlem yapmak..
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("All students are in the class sir");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                isAllOkey = true; //burada dönümüzden çıkacağız..
            }
            else
            {
                Console.WriteLine("Please enter your student number");
                string result = Console.ReadLine();
                int intResult;
                bool isInt = int.TryParse(result, out intResult);
                if (isInt == false) //Burada amacım girdinin sayı olup olmadığını kontrol etmek değilse hata verdirmek..
                {
                    Console.WriteLine("You didnt enter integer value, try again!!");
                }
                else
                {
                    Console.WriteLine("Right!! You enter integer value");
                    Console.WriteLine("-------------------------------");

                    //Burada girdinin sayı olduğunu onayladık 
                    //sonra yeni bir bool oluşturup döngü ile öğrencilerin sınıfta olup olmadığını kontrol etmek..
                    for (int i = 0; i < list.Count; i++)
                    {
                        string number = new string(list[i].Where(char.IsDigit).ToArray());
                        intList.Add(number);
                        if (result.Equals(number))
                        {
                            if (isStudentAttend[i] == false)                // yukarıda 01 olarak girilen list değeri list[0] olduğu için 
                            {                                                       //aynı şekilde isStudentAttend listimizdede [0].ncı verisini kontrol etmekti.
                                Console.WriteLine(list[i] + " is in the class..");  //Eğer [0].ncı veriyi 1 kere girersek true ya döndürüp ilk öğrencimizi sınıfta sayacağız artık..
                                isStudentAttend[i] = true;
                            }
                            else
                            {
                                Console.WriteLine(list[i] + " is already in the class, Please try to enter other students numbers");
                                isStudentAttend[i] = true;
                            }
                        }
                    }
                }
            }
        }
    }
}