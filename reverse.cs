    string[] strings = {"ti", "ymedacAedoC" , "malas"};
    string reverse_word = "";
        for (int i = 0; i<strings.Length; i++)
        {
            foreach (char chars in strings[i])
            {
                reverse_word = chars + reverse_word;
            }
            strings[i]=reverse_word;
            reverse_word = "";

        }
        foreach (string reversed in strings)
        {
            System.Console.WriteLine(reversed);
        }

