using System;
using System.Collections;

namespace us.mattgreen{
    public class Program
    {

        private static FileOutput outFile = new FileOutput("animals.txt");

        public static void Main(String[] args)
        {
            ArrayList zoo = new ArrayList();
            AddAnimal animalAdd = new AddAnimal();
            bool addMore = false;
            do
            {
                animalAdd.enterType();
                zoo.Add(animalAdd.newAnimal());
                Console.WriteLine("Add another animal? (Y/N)");
                string yOrN = Console.ReadLine().ToUpper();
                if (yOrN == "Y")
                {
                    addMore = true;
                }
                else
                {
                    addMore = false;
                }

            } while (addMore == true);

            foreach (Talkable thing in zoo)
                {
                    printOut(thing);
                }

                outFile.fileClose();
                FileInput inFile = new FileInput("animals.txt");
                inFile.fileRead();
                inFile.fileClose();

                FileInput indata = new FileInput("animals.txt");
                String line;
                while ((line = indata.fileReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                indata.fileClose();
        }

        public static void printOut(Talkable p) {
            Console.WriteLine(p.getName() + " says=" + p.talk());
            outFile.fileWrite(p.getName() + " | " + p.talk());
        }
    }
}