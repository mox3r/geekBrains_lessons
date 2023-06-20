
string text = "- Я думаю, — сказал князь, улыбаясь, — что,"
        + "ежели бы вас послали вместо нашего милого Винценгероде,"
        + "вы бы взяли приступом согласие прусского короля."
        + "Вы так красноречивы. Вы дадите мне чаю?";

string Replacement(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replacement(text, 'С', 'с');
newText = Replacement(newText, 'к', 'К');

System.Console.WriteLine(newText);
