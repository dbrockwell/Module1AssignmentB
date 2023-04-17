using System;
using System.IO;

/**
 * Created by mgreen14 on 12/27/17.
 */
namespace us.mattgreen{
    public class FileOutput {

        StreamWriter sw = null;
        private String fileName;

        public FileOutput(String fileName) {
            this.fileName = fileName;
            try {
                sw = new StreamWriter(fileName);
            } catch (FileNotFoundException e) {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileWrite(String line) {
            try {
                sw.WriteLine(line + "\n");
            } catch (Exception e) {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void fileClose() {
            if (sw != null) {
                try {
                    sw.Close();
                } catch (IOException e) {
                    Console.WriteLine("File Close Error: " + fileName + " " + e);
                }
            }

        }
    }
}