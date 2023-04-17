using System;
using System.IO;

/**
 * Created by mgreen14 on 12/27/17.
 */
namespace us.mattgreen
{
    public class FileInput
    {

        private string fileName;
        private StreamReader sr = null;

        public FileInput(String fileName)
        {
            this.fileName = fileName;
            try
            {
                sr = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileRead()
        {
            String line;
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public String fileReadLine()
        {
            try
            {
                String line = sr.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
                return null;
            }
        }

        public void fileClose()
        {
            if (sr != null)
            {
                try
                {
                    sr.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("File Close Error: " + fileName + " " + e);
                }
            }

        }
    }
}