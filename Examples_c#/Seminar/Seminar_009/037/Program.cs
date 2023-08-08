using System.Text;
string Vowel2Index(string str)
  {
    for(int i = 0; i < str.Length; i++)
    {
      if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' ||
        str[i] == 'o' || str[i] == 'u')
        {
            StringBuilder sb = new StringBuilder(str);
            sb[i] = i+1;
            str = sb.ToString();
        }
        
    }
    return str;
  }

  Console.Write(Vowel2Index("this is my string"));
