class MainClass 
{
  public static void Main (string[] args)
  {
    string ulang="y";
    while(ulang=="y"){
        Console.WriteLine("selamat datang di game hangman");
        Console.Write("Pencet enter jika anda mau memainkan game ini");
        Console.ReadLine();
        Console.Clear();
        string[] listtebak = new string[10];
            listtebak[0] = "mangga";
            listtebak[1] = "kelapa";
            listtebak[2] = "apel";
            listtebak[3] = "semangka";
            listtebak[4] = "jeruk";
            listtebak[5] = "rambutan";
            listtebak[6] = "manggis";
            listtebak[7] = "pisang";
            listtebak[8] = "durian";
            listtebak[9] = "alpukat";
            Random randGen = new Random();
            var nomor = randGen.Next(0, 9);
            string katarahasia = listtebak[nomor];
    
    
    katarahasia = katarahasia.ToUpper();
    int Nyawa = 5;
    int counter = -1;
    int tebakan = katarahasia.Length;
    char[] secretArray = katarahasia.ToCharArray();
    char[] printArray = new char[tebakan];
    char[] guessedLetters = new char[26];
    int numberStore = 0;
    bool menang = false;

    foreach(char letter in printArray)
    {
      counter++;
      printArray[counter] = '*';
    }

    
    
    while(Nyawa > 0)
    {
      counter = -1;
      string tebakan_rahasia = String.Concat(printArray);
      bool jawaban = false;
      int multiples = 0;

      if (tebakan_rahasia == katarahasia)
      {
        menang = true;
        break;
      }
      
      Console.WriteLine("");
    Console.WriteLine("silahkan tebak kata ini: " + tebakan_rahasia);
    Console.Write("\n");
    Console.Write("silahkan masukan huruf: ");
    string pemain = Console.ReadLine();

      bool maksimal = pemain.All(Char.IsLetter);
    
      while (maksimal == false || pemain.Length != 1)
      {
        Console.WriteLine("Silahkan masukkan satu huruf saja!");
        Console.Write("silahkan masukan huruf: ");
        pemain = Console.ReadLine();
        maksimal = pemain.All(Char.IsLetter);
      }

      if (Nyawa > 1)
      {
        Console.WriteLine("Kamu masih memiliki {0} nyawa!", Nyawa);
      }
      else
      {
        Console.WriteLine("Nyawa kamu tersisa {0}!!", Nyawa);
      }


    

      pemain = pemain.ToUpper();
      char playerChar = Convert.ToChar(pemain);

      if (guessedLetters.Contains(playerChar) == false)
      {
                
        guessedLetters[numberStore] = playerChar;
        numberStore++;

        foreach(char letter in secretArray)
        { 
          counter++;
          if (letter == playerChar)
          {
            printArray[counter] = playerChar;
            jawaban = true;
            multiples++;
          }
        }

        if (jawaban)
        {
          Console.WriteLine("jawaban benar {0}!", playerChar);
        }
        else
        {
          Console.WriteLine("jawaban salah {0}!", playerChar);
          Nyawa--;
        }
      }
      else
      {
        Console.WriteLine("kamu sudah menebak kata ini {0}!!", playerChar);
      }


    }


    if (menang)
      {
         Console.Clear();
        Console.WriteLine("Jawabannya adalah: {0}", katarahasia);
        Console.WriteLine("KAMU MENANG!!!!!!!!!!!");
        Console.Write("Ingin bermain lagi?(y/n): ");
        ulang = Console.ReadLine();
        Console.Clear();
        if(ulang=="n")
        {
            Console.Clear();
            Console.Write("Game selesai");
        }
      }
    else
      {
          Console.Clear();
        Console.WriteLine("Jawabannya adalah: {0}", katarahasia);
        Console.WriteLine("KAMU KALAH!!!!!!!!!");
        Console.WriteLine("SILAHKAN COBA LAGI");
        Console.Write("Ingin bermain lagi?(y/n): ");
        ulang = Console.ReadLine();
        Console.Clear();
        if(ulang=="n")
        {
            Console.Clear();
            Console.Write("Game selesai");
        }
        }
      }
    }
  }







