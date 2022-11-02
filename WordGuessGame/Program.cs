using System.Linq;
Random rd = new Random();
//creates a word_list and generates a random word to be guessed
string[] wordList = {"abruptly",
"absurd",
"abyss",
"affix",
"askew",
"bikini",
"blitz",
"blizzard",
"caliph",
"cobweb",
"cockiness",
"equip",
"espionage",
"euouae",
"exodus",
"faking",
"fishhook",
"fixable",
"fjord",
"flapjack",
"flopping",
"fluffiness",
"flyby",
"foxglove",
"frazzled",
"frizzled",
"fuchsia",
"funny",
"gabby",
"galaxy",
"galvanize",
"gazebo",
"giaour",
"gizmo",
"glowworm",
"glyph",
"gnarly",
"gnostic",
"gossip",
"grogginess",
"haiku",
"haphazard",
"hyphen",
"iatrogenic",
"icebox",
"injury",
"ivory",
"ivy",
"jackpot",
"jaundice",
"jawbreaker",
"jaywalk",
"jazziest",
"jazzy",
"jelly",
"jigsaw",
"jinx",
"jiujitsu",
"jockey",
"jogging",
"joking",
"jovial",
"joyful",
"juicy",
"jukebox",
"jumbo",
"kayak",
"kazoo",
"keyhole",
"khaki",
"kilobyte",
"kiosk",
"kitsch",
"kiwifruit",
"klutz",
"knapsack",
"larynx",
"lengths",
"lucky",
"luxury",
"lymph",
"marquis",
"matrix",
"megahertz",
"microwave",
"mnemonic",
"mystify",
"naphtha",
"nightclub",
"nowadays",
"numbskull",
"nymph",
"onyx",
"ovary",
"oxidize",
"oxygen",
"pajama",
"peekaboo",
"phlegm",
"pixel",
"pizazz",
"pneumonia",
"polka",
"pshaw",
"psyche",
"puppy",
"puzzling",
"quartz",
"queue",
"quips",
"quixotic",
"quiz",
"quizzes",
"quorum",
"razzmatazz",
"rhubarb",
"rhythm",
"rickshaw",
"schnapps",
"scratch",
"shiv",
"snazzy",
"sphinx",
"spritz",
"squawk",
"staff",
"strength",
"strengths",
"stretch",
"stronghold",
"stymied",
"subway",
"swivel",
"syndrome",
"thriftless",
"thumbscrew",
"topaz",
"transcript",
"transgress",
"transplant",
"triphthong",
"twelfth",
"twelfths",
"unknown",
"unworthy",
"unzip",
"uptown",
"vaporize",
"vixen",
"vodka",
"voodoo",
"vortex",
"voyeurism",
"walkway",
"waltz",
"wave",
"wavy",
"waxy",
"wellspring",
"wheezy",
"whiskey",
"whizzing",
"whomever",
"wimpy",
"witchcraft",
"wizard",
"woozy",
"wristwatch",
"wyvern",
"xylophone",
"yachtsman",
"yippee",
"yoked",
"youthful",
"yummy",
"zephyr",
"zigzag",
"zigzagging",
"zilch",
"zipper",
"zodiac",
"zombie",};
string guessWord = wordList[rd.Next(wordList.Length)];
//Console.WriteLine(guessWord);
string[] displayText = new string[guessWord.Length];
for (int i = 0; i < guessWord.Length; i++)
    displayText[i] = "_";
int numTries = 6;
bool endOfGame = false;

Console.WriteLine("Welcome to the guessing game\nA random word will be generated and you are required to guess the letters");
while (!endOfGame)
{
    Console.Write("Guess a letter: ");
    char guessLetter = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (displayText.Contains(Convert.ToString(guessLetter)) == true)
    {
        Console.WriteLine($"You have already guessed {guessLetter}");
    }
    for (int j = 0; j < guessWord.Length; j++)
    {
        if (guessLetter == guessWord[j])
        {
            displayText[j] = Convert.ToString(guessLetter);
            Console.WriteLine(string.Join("", displayText));
        }
    }
    if (guessWord.Contains(guessLetter) == false)
    {
        numTries--;
        Console.WriteLine($"{guessLetter} is incorrect, you have {numTries} tries left.");
        if (numTries == 0)
        {
            Console.WriteLine("You are out of tries.");
            endOfGame = true;
        }
    }
    if (displayText.Contains("_") == false)
    {
        Console.WriteLine("You have correctly guessed the word");
        Console.WriteLine(string.Join("", displayText));
        endOfGame = true;
    }
}






