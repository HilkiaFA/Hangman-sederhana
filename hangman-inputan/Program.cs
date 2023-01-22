class MainClass 
{
  public static void Main (string[] args)
  {
    string ulang="y";
    while(ulang=="y"){
    Console.WriteLine("Ayo bermain Hangman!");

    Console.Write("Masukkan Nama yang mau di tebak: ");
    string secretWord = Console.ReadLine();

    bool wordTest = secretWord.All(Char.IsLetter);
    
    while (wordTest == false || secretWord.Length == 0)
    {
      Console.WriteLine("kata harus mangandung huruf dan tidak boleh menggunakakn spasi");
      Console.WriteLine("");
      Console.Write("silahkan masukkan ulang kata yang ingin ditebak: ");
      secretWord = Console.ReadLine();
      wordTest = secretWord.All(Char.IsLetter);
    }
    
    Console.Clear();
    
    secretWord = secretWord.ToUpper();
    int lives = 5;
    int counter = -1;
    int wordLength = secretWord.Length;
    char[] secretArray = secretWord.ToCharArray();
    char[] printArray = new char[wordLength];
    char[] guessedLetters = new char[26];
    int numberStore = 0;
    bool victory = false;

    foreach(char letter in printArray)
    {
      counter++;
      printArray[counter] = '*';
    }

    while(lives > 0)
    {
      counter = -1;
      string printProgress = String.Concat(printArray);
      bool letterFound = false;
      int multiples = 0;

      if (printProgress == secretWord)
      {
        victory = true;
        break;
      }

      if (lives > 1)
      {
        Console.WriteLine("Kamu masih memiliki {0} nyawa!", lives);
      }
      else
      {
        Console.WriteLine("Nyawa kamu tersisa {0}!!", lives);
      }


    Console.WriteLine("");
    Console.WriteLine("silahkan tebak kata ini: " + printProgress);
    Console.Write("\n");
    Console.Write("silahkan masukan huruf: ");
    string playerGuess = Console.ReadLine();

      bool guessTest = playerGuess.All(Char.IsLetter);
    
      while (guessTest == false || playerGuess.Length != 1)
      {
        Console.WriteLine("Silahkan masukkan satu huruf saja!");
        Console.Write("silahkan masukan huruf: ");
        playerGuess = Console.ReadLine();
        guessTest = playerGuess.All(Char.IsLetter);
      }

      playerGuess = playerGuess.ToUpper();
      char playerChar = Convert.ToChar(playerGuess);

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
            letterFound = true;
            multiples++;
          }
        
        }

        if (letterFound)
        {
          Console.WriteLine("jawaban benar {0}!", playerChar);
        }
        else
        {
          Console.WriteLine("jawaban salah {0}!", playerChar);
          lives--;
        }
      }
      else
      {
        Console.WriteLine("kamu sudah menebak kata ini {0}!!", playerChar);
      }


    }


    if (victory)
      {
         Console.Clear();
        Console.WriteLine("Jawabannya adalah: {0}", secretWord);
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
        Console.WriteLine("Jawabannya adalah: {0}", secretWord);
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






