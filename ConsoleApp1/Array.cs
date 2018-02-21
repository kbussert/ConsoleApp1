
////====================================================================================================================

////REPLACES ALL SPACES IN A STRING WITH '%20'
//private static string replaceSpaces(string s)
//{
//    string sub = "%20";
//    string result = "";
//    int lastSpaceIndex = 0;
//    var x = s.ToCharArray();

//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] == ' ')
//        {
//            string subR = new string(x, lastSpaceIndex, (i - lastSpaceIndex));
//            result += subR;
//            result += sub;
//            lastSpaceIndex = i + 1;
//        }
//    }

//    result += new string(x, lastSpaceIndex, (x.Length - lastSpaceIndex));

//    return result;
//}

////====================================================================================================================

////REVERSES A STRING 
//static char[] reverseArray(char[] array)
//{
//    var product = new char[array.Length];
//    int productIndex = product.Length - 1;

//    for (int i = 0; i < array.Length; i++)
//    {
//        product[productIndex] = array[i];
//        productIndex--;
//    }

//    return product;
//}

////====================================================================================================================

////PRINTS A CHAR ARRAY
//static void printArray(char[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }

//    Console.WriteLine();
//}