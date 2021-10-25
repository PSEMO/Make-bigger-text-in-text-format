using System;

namespace ConsoleApp2
{
    class Program
    {
        static string[,] alphabet = new string[26, 8];
        //Sets basic Eng letters. Since their dec is consecutive, it is usefull to have them in consecutive array numbers

        static string[,] numbers = new string[10, 8];
        //Sets basic numbers. Since their dec is consecutive, it is usefull to have them in consecutive array numbers

        static string[,] utilities = new string[4, 8];
        //Sets some utility characters

        static string[] Output = new string[8];
        //To store the output

        static void Main()
        {

#region "Big Characters"
            alphabet[0, 0] = " _______  ";//1
            alphabet[0, 1] = "(  ___  ) ";//2
            alphabet[0, 2] = "| (   ) | ";//3
            alphabet[0, 3] = "| (___) | ";//4
            alphabet[0, 4] = "|  ___  | ";//5
            alphabet[0, 5] = "| (   ) | ";//6
            alphabet[0, 6] = "| )   ( | ";//7
            alphabet[0, 7] = "|/     \\| ";//8

            alphabet[1, 0] = " ______   ";//1
            alphabet[1, 1] = "(  ___ \\  ";//2
            alphabet[1, 2] = "| (   ) ) ";//3
            alphabet[1, 3] = "| (__/ /  ";//4
            alphabet[1, 4] = "|  __ (   ";//5
            alphabet[1, 5] = "| (  \\ \\  ";//6
            alphabet[1, 6] = "| )___) ) ";//7
            alphabet[1, 7] = "|______/  ";//8

            alphabet[2, 0] = " _______  ";//1
            alphabet[2, 1] = "(  ____ \\ ";//2
            alphabet[2, 2] = "| (    \\/ ";//3
            alphabet[2, 3] = "| |       ";//4
            alphabet[2, 4] = "| |       ";//5
            alphabet[2, 5] = "| |       ";//6
            alphabet[2, 6] = "| (____/\\ ";//7
            alphabet[2, 7] = "(_______/ ";//8

            alphabet[3, 0] = " ______   ";//1
            alphabet[3, 1] = "(  __  \\  ";//2
            alphabet[3, 2] = "| (  \\  ) ";//3
            alphabet[3, 3] = "| |   ) | ";//4
            alphabet[3, 4] = "| |   | | ";//5
            alphabet[3, 5] = "| |   ) | ";//6
            alphabet[3, 6] = "| (__/  ) ";//7
            alphabet[3, 7] = "(______/  ";//8

            alphabet[4, 0] = " _______  ";//1
            alphabet[4, 1] = "(  ____ \\ ";//2
            alphabet[4, 2] = "| (    \\/ ";//3
            alphabet[4, 3] = "| (__     ";//4
            alphabet[4, 4] = "|  __)    ";//5
            alphabet[4, 5] = "| (       ";//6
            alphabet[4, 6] = "| (____/\\ ";//7
            alphabet[4, 7] = "(_______/ ";//8

            alphabet[5, 0] = " _______  ";//1
            alphabet[5, 1] = "(  ____ \\ ";//2
            alphabet[5, 2] = "| (    \\/ ";//3
            alphabet[5, 3] = "| (__     ";//4
            alphabet[5, 4] = "|  __)    ";//5
            alphabet[5, 5] = "| (       ";//6
            alphabet[5, 6] = "| )       ";//7
            alphabet[5, 7] = "|/        ";//8

            alphabet[6, 0] = " _______  ";//1
            alphabet[6, 1] = "(  ____ \\ ";//2
            alphabet[6, 2] = "| )   ( | ";//3
            alphabet[6, 3] = "| |       ";//4
            alphabet[6, 4] = "| | ____  ";//5
            alphabet[6, 5] = "| | \\_  ) ";//6
            alphabet[6, 6] = "| (___) | ";//7
            alphabet[6, 7] = "(_______) ";//8

            alphabet[7, 0] = "          ";//1
            alphabet[7, 1] = "|\\     /| ";//2
            alphabet[7, 2] = "| )   ( | ";//3
            alphabet[7, 3] = "| (___) | ";//4
            alphabet[7, 4] = "|  ___  | ";//5
            alphabet[7, 5] = "| (   ) | ";//6
            alphabet[7, 6] = "| )   ( | ";//7
            alphabet[7, 7] = "|/     \\| ";//8

            alphabet[8, 0] = "__________";//1
            alphabet[8, 1] = "\\__   __/ ";//2
            alphabet[8, 2] = "   ) (    ";//3
            alphabet[8, 3] = "   | |    ";//4
            alphabet[8, 4] = "   | |    ";//5
            alphabet[8, 5] = "   | |    ";//6
            alphabet[8, 6] = "___) (___ ";//7
            alphabet[8, 7] = "\\_______/ ";//8

            alphabet[9, 0] = "_________ ";//1
            alphabet[9, 1] = "\\__    _/ ";//2
            alphabet[9, 2] = "   )  (   ";//3
            alphabet[9, 3] = "   |  |   ";//4
            alphabet[9, 4] = "   |  |   ";//5
            alphabet[9, 5] = "   |  |   ";//6
            alphabet[9, 6] = "|\\_)  )   ";//7
            alphabet[9, 7] = "(____/    ";//8

            alphabet[10, 0] = " _        ";//1
            alphabet[10, 1] = "| \\    /\\ ";//2
            alphabet[10, 2] = "|  \\  / / ";//3
            alphabet[10, 3] = "|  (_/ /  ";//4
            alphabet[10, 4] = "|   _ (   ";//5
            alphabet[10, 5] = "|  ( \\ \\  ";//6
            alphabet[10, 6] = "|  /  \\ \\ ";//7
            alphabet[10, 7] = "|_/    \\_\\";//8

            alphabet[11, 0] = " _        ";//1
            alphabet[11, 1] = "( \\       ";//2
            alphabet[11, 2] = "| (       ";//3
            alphabet[11, 3] = "| |       ";//4
            alphabet[11, 4] = "| |       ";//5
            alphabet[11, 5] = "| |       ";//6
            alphabet[11, 6] = "| (____/\\ ";//7
            alphabet[11, 7] = "(_______/ ";//8

            alphabet[12, 0] = " _______  ";//1
            alphabet[12, 1] = "(       ) ";//2
            alphabet[12, 2] = "| () () | ";//3
            alphabet[12, 3] = "| || || | ";//4
            alphabet[12, 4] = "| |(_)| | ";//5
            alphabet[12, 5] = "| |   | | ";//6
            alphabet[12, 6] = "| )   ( | ";//7
            alphabet[12, 7] = "|/     \\| ";//8

            alphabet[13, 0] = " _        ";//1
            alphabet[13, 1] = "( (    /| ";//2
            alphabet[13, 2] = "|  \\  ( | ";//3
            alphabet[13, 3] = "|   \\ | | ";//4
            alphabet[13, 4] = "| (\\ \\) | ";//5
            alphabet[13, 5] = "| | \\   | ";//6
            alphabet[13, 6] = "| )  \\  | ";//7
            alphabet[13, 7] = "|/    )_) ";//8

            alphabet[14, 0] = " _______  ";//1
            alphabet[14, 1] = "(  ___  ) ";//2
            alphabet[14, 2] = "| (   ) | ";//3
            alphabet[14, 3] = "| |   | | ";//4
            alphabet[14, 4] = "| |   | | ";//5
            alphabet[14, 5] = "| |   | | ";//6
            alphabet[14, 6] = "| (___) | ";//7
            alphabet[14, 7] = "(_______) ";//8

            alphabet[15, 0] = " _______  ";//1
            alphabet[15, 1] = "(  ____ ) ";//2
            alphabet[15, 2] = "| (    )| ";//3
            alphabet[15, 3] = "| (____)| ";//4
            alphabet[15, 4] = "|  _____) ";//5
            alphabet[15, 5] = "| (       ";//6
            alphabet[15, 6] = "| )       ";//7
            alphabet[15, 7] = "|/        ";//8

            alphabet[16, 0] = " _______  ";//1
            alphabet[16, 1] = "(  ___  ) ";//2
            alphabet[16, 2] = "| (   ) | ";//3
            alphabet[16, 3] = "| |   | | ";//4
            alphabet[16, 4] = "| |   | | ";//5
            alphabet[16, 5] = "| | /\\| | ";//6
            alphabet[16, 6] = "| (_\\ \\ | ";//7
            alphabet[16, 7] = "(____\\/_) ";//8

            alphabet[17, 0] = " _______  ";//1
            alphabet[17, 1] = "(  ____ ) ";//2
            alphabet[17, 2] = "| (    )| ";//3
            alphabet[17, 3] = "| (____)| ";//4
            alphabet[17, 4] = "|     __) ";//5
            alphabet[17, 5] = "| (\\ (    ";//6
            alphabet[17, 6] = "| ) \\ \\__ ";//7
            alphabet[17, 7] = "|/   \\__/ ";//8

            alphabet[18, 0] = " _______  ";//1
            alphabet[18, 1] = "(  ____ \\ ";//2
            alphabet[18, 2] = "| (    \\/ ";//3
            alphabet[18, 3] = "| (_____  ";//4
            alphabet[18, 4] = "(_____  ) ";//5
            alphabet[18, 5] = "      ) | ";//6
            alphabet[18, 6] = "/\\____) | ";//7
            alphabet[18, 7] = "\\_______) ";//8

            alphabet[19, 0] = "_________ ";//1
            alphabet[19, 1] = "\\__   __/ ";//2
            alphabet[19, 2] = "   ) (    ";//3
            alphabet[19, 3] = "   | |    ";//4
            alphabet[19, 4] = "   | |    ";//5
            alphabet[19, 5] = "   | |    ";//6
            alphabet[19, 6] = "   | |    ";//7
            alphabet[19, 7] = "   )_(    ";//8

            alphabet[20, 0] = "          ";//1
            alphabet[20, 1] = "|\\     /| ";//2
            alphabet[20, 2] = "| )   ( | ";//3
            alphabet[20, 3] = "| |   | | ";//4
            alphabet[20, 4] = "| |   | | ";//5
            alphabet[20, 5] = "| |   | | ";//6
            alphabet[20, 6] = "| (___) | ";//7
            alphabet[20, 7] = "(_______) ";//8

            alphabet[21, 0] = "          ";//1
            alphabet[21, 1] = "|\\     /| ";//2
            alphabet[21, 2] = "| )   ( | ";//3
            alphabet[21, 3] = "| |   | | ";//4
            alphabet[21, 4] = "( (   ) ) ";//5
            alphabet[21, 5] = " \\ \\_/ /  ";//6
            alphabet[21, 6] = "  \\   /   ";//7
            alphabet[21, 7] = "   \\_/    ";//8

            alphabet[22, 0] = "          ";//1
            alphabet[22, 1] = "|\\     /| ";//2
            alphabet[22, 2] = "| )   ( | ";//3
            alphabet[22, 3] = "| | _ | | ";//4
            alphabet[22, 4] = "| |( )| | ";//5
            alphabet[22, 5] = "| || || | ";//6
            alphabet[22, 6] = "| () () | ";//7
            alphabet[22, 7] = "(_______) ";//8

            alphabet[23, 0] = "          ";//1
            alphabet[23, 1] = "|\\     /| ";//2
            alphabet[23, 2] = "( \\   / ) ";//3
            alphabet[23, 3] = " \\ (_) /  ";//4
            alphabet[23, 4] = "  ) _ (   ";//5
            alphabet[23, 5] = " / ( ) \\  ";//6
            alphabet[23, 6] = "( /   \\ ) ";//7
            alphabet[23, 7] = "|/     \\| ";//8

            alphabet[24, 0] = "          ";//1
            alphabet[24, 1] = "|\\     /| ";//2
            alphabet[24, 2] = "( \\   / ) ";//3
            alphabet[24, 3] = " \\ (_) /  ";//4
            alphabet[24, 4] = "  \\   /   ";//5
            alphabet[24, 5] = "   ) (    ";//6
            alphabet[24, 6] = "   | |    ";//7
            alphabet[24, 7] = "   \\_/    ";//8

            alphabet[25, 0] = " _________  ";//1
            alphabet[25, 1] = "/____     ) ";//2
            alphabet[25, 2] = "     )   /  ";//3
            alphabet[25, 3] = "    /   /   ";//4
            alphabet[25, 4] = "   /   /    ";//5
            alphabet[25, 5] = "  /   /     ";//6
            alphabet[25, 6] = " /   (_____ ";//7
            alphabet[25, 7] = "(_________/ ";//8

            numbers[0, 0] = " _______  ";//1
            numbers[0, 1] = "(  __   ) ";//2
            numbers[0, 2] = "| (  )  | ";//3
            numbers[0, 3] = "| | /   | ";//4
            numbers[0, 4] = "| (/ /) | ";//5
            numbers[0, 5] = "|   / | | ";//6
            numbers[0, 6] = "|  (__) | ";//7
            numbers[0, 7] = "(_______) ";//8

            numbers[1, 0] = " __    ";//1
            numbers[1, 1] = "/  \\   ";//2
            numbers[1, 2] = "\\/) )  ";//3
            numbers[1, 3] = "  | |  ";//4
            numbers[1, 4] = "  | |  ";//5
            numbers[1, 5] = "  | |  ";//6
            numbers[1, 6] = "__) (_ ";//7
            numbers[1, 7] = "\\____/ ";//8

            numbers[2, 0] = " _______  ";//1
            numbers[2, 1] = "/ ___   ) ";//2
            numbers[2, 2] = "\\/   )  | ";//3
            numbers[2, 3] = "    /   ) ";//4
            numbers[2, 4] = "  _/   /  ";//5
            numbers[2, 5] = " /   _/   ";//6
            numbers[2, 6] = "(   (__/\\ ";//7
            numbers[2, 7] = "\\_______/ ";//8

            numbers[3, 0] = " ______   ";//1
            numbers[3, 1] = "/ ___  \\  ";//2
            numbers[3, 2] = "\\/   \\  \\ ";//3
            numbers[3, 3] = "   ___) / ";//4
            numbers[3, 4] = "  (___ (  ";//5
            numbers[3, 5] = "      ) \\ ";//6
            numbers[3, 6] = "/\\___/  / ";//7
            numbers[3, 7] = "\\______/  ";//8
         
            numbers[4, 0] = "    ___    ";//1
            numbers[4, 1] = "   /   )   ";//2
            numbers[4, 2] = "  / /) |   ";//3
            numbers[4, 3] = " / (_) (_  ";//4
            numbers[4, 4] = "(____   _) ";//5
            numbers[4, 5] = "     ) (   ";//6
            numbers[4, 6] = "     | |   ";//7
            numbers[4, 7] = "     (_)   ";//8
         
            numbers[5, 0] = " _______  ";//1
            numbers[5, 1] = "(  ____ \\ ";//2
            numbers[5, 2] = "| (    \\/ ";//3
            numbers[5, 3] = "| (____   ";//4
            numbers[5, 4] = "(_____ \\  ";//5
            numbers[5, 5] = "      ) ) ";//6
            numbers[5, 6] = "/\\____) ) ";//7
            numbers[5, 7] = "\\______/  ";//8

            numbers[6, 0] = "  ______  ";//1
            numbers[6, 1] = " / ____ \\ ";//2
            numbers[6, 2] = "( (    \\/ ";//3
            numbers[6, 3] = "| (____   ";//4
            numbers[6, 4] = "|  ___ \\  ";//5
            numbers[6, 5] = "| (   ) ) ";//6
            numbers[6, 6] = "( (___) ) ";//7
            numbers[6, 7] = " \\_____/  ";//8

            numbers[7, 0] = " ______   ";//1
            numbers[7, 1] = "/ ___  \\  ";//2
            numbers[7, 2] = "\\/   )  ) ";//3
            numbers[7, 3] = "    /  /  ";//4
            numbers[7, 4] = "   /  /   ";//5
            numbers[7, 5] = "  /  /    ";//6
            numbers[7, 6] = " /  /     ";//7
            numbers[7, 7] = " \\_/      ";//8
         
            numbers[8, 0] = "  _____   ";//1
            numbers[8, 1] = " / ___ \\  ";//2
            numbers[8, 2] = "( (___) ) ";//3
            numbers[8, 3] = " \\     /  ";//4
            numbers[8, 4] = " / ___ \\  ";//5
            numbers[8, 5] = "( (   ) ) ";//6
            numbers[8, 6] = "( (___) ) ";//7
            numbers[8, 7] = " \\_____/  ";//8

            numbers[9, 0] = "  _____   ";//1
            numbers[9, 1] = " / ___ \\  ";//2
            numbers[9, 2] = "( (   ) ) ";//3
            numbers[9, 3] = "( (___) | ";//4
            numbers[9, 4] = " \\____  | ";//5
            numbers[9, 5] = "      ) | ";//6
            numbers[9, 6] = "/\\____) ) ";//7
            numbers[9, 7] = "\\______/  ";//8

            utilities[0, 0] = "     ";//1
            utilities[0, 1] = "     ";//2
            utilities[0, 2] = "     ";//3
            utilities[0, 3] = "     ";//4
            utilities[0, 4] = "     ";//5
            utilities[0, 5] = "     ";//6
            utilities[0, 6] = "     ";//7
            utilities[0, 7] = "     ";//8

            utilities[1, 0] = " _  ";//1
            utilities[1, 1] = "( ) ";//2
            utilities[1, 2] = "| | ";//3
            utilities[1, 3] = "| | ";//4
            utilities[1, 4] = "| | ";//5
            utilities[1, 5] = "(_) ";//6
            utilities[1, 6] = " _  ";//7
            utilities[1, 7] = "(_) ";//8

            utilities[2, 0] = "  _____   ";//1
            utilities[2, 1] = " / ___ \\  ";//2
            utilities[2, 2] = "( (   ) ) ";//3
            utilities[2, 3] = " \\/  / /  ";//4
            utilities[2, 4] = "    ( |   ";//5
            utilities[2, 5] = "    (_)   ";//6
            utilities[2, 6] = "     _    ";//7
            utilities[2, 7] = "    (_)   ";//8

            utilities[3, 0] = "    ";//1
            utilities[3, 1] = "    ";//2
            utilities[3, 2] = "    ";//3
            utilities[3, 3] = "    ";//4
            utilities[3, 4] = "    ";//5
            utilities[3, 5] = "    ";//6
            utilities[3, 6] = " _  ";//7
            utilities[3, 7] = "(_) ";//8
            #endregion Region


            while (true)
            {
                Console.WriteLine("Write Your Text Here: ");
                string input = Console.ReadLine();//Stores the input
                Console.Clear();

                //Codes after this makes the input bigger:

                Output = new string[8];

                for (int currentPlaceRendering = 0; currentPlaceRendering < 8; currentPlaceRendering++)
                {
                    foreach (char currentChar in input)
                    {
                        Decimal dec = currentChar;
                        Console.WriteLine("Rendering: " + dec + ", Stage: " + currentPlaceRendering);

                        {//Save same positions of "given characters bigger form" side by side. And repeat this until every position is done.
                            if (dec > 96 && dec <= 122)//'a', 'b', 'c'... 
                            {
                                Output[currentPlaceRendering] += alphabet[((int)dec) - 97, currentPlaceRendering];
                            }
                            else if (dec > 64 && dec <= 90)//'A', 'B', 'C'...
                            {
                                Output[currentPlaceRendering] += alphabet[((int)dec) - 65, currentPlaceRendering];
                            }
                            else if (dec > 47 && dec <= 58)//'1', '2', '3'...
                            {
                                Output[currentPlaceRendering] += numbers[((int)dec) - 48, currentPlaceRendering];
                            }
                            else if (dec > 31 && dec <= 33)//' ', '!' 
                            {
                                Output[currentPlaceRendering] += utilities[((int)dec) - 32, currentPlaceRendering];
                            }
                            else if (dec == 63)//'?'
                            {
                                Output[currentPlaceRendering] += utilities[2, currentPlaceRendering];
                            }
                            else if (dec == 46)//'.'
                            {
                                Output[currentPlaceRendering] += utilities[3, currentPlaceRendering];
                            }
                            else
                            {
                                //TODO: idk write X or something. A character that program was not ready for was enter.
                            }
                        }
                    }
                }

                for (int i = 0; i < 8; i++)//Renders the stored data top to down
                {
                    Console.WriteLine(Output[i]);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}