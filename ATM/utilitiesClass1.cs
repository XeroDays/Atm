using System;
using System.IO;
using System.Windows.Forms;

namespace ATM
{
    public class utilitiesClass1
    {
        public static string balnce;
        public static int balnce2;
        //   public static string data2= @"E:\vswork\ATM\"
        public static string data = Path.GetDirectoryName(Application.ExecutablePath) + @"\DATA.txt";
        public static void createdata()
        {



        }
        public static void getfile()
        {
            if (!(File.Exists(data)))
            {
                File.Create(data).Close();
            }


        }
        public static void Write()
        {
            //StreamWriter sw = new StreamWriter(data);

            //sw.WriteLine(balnce);

        }
        public static void adddb()
        {
            // File.AppendAllText(data,balnce2.ToString());
        }
        public static bool flagg;
        public static void addtodb(string data1)
        {

            File.AppendAllText(data, data1 + Environment.NewLine);

        }
        public static string loadbalnce;
        public static string getdataa;
        public static string dataa;
        public static string getdata()
        {
            string returnn;
            returnn = getdataa;
            return returnn;
        }
        public static bool readtext(string data2, string data4)
        {
            bool flag = false;
            // string data3;
            // StreamReader file = new StreamReader(data);
            //data3 = file.ReadToEnd();

            //int i = 0;

            string[] words = File.ReadAllLines(data);
            //  string[] words = data3.Split(':');
            // int size = words.Length-1 ;
            foreach (string word in words)
            {
                string[] line = word.Split(':');
                if ((line[2] == data2) && (line[3] == data4))
                {
                    flag = true;
                    getdataa = line[0];
                    dataa = line[2];
                    loadbalnce = line[4];

                    return flag;
                }



            }
            //for (int i = 0; i < words.Length - 1; i++)
            //{


            //      //System.Windows.Forms.MessageBox.Show("Test" + words[i+4]);
            //    if ((words[i + 2] == data2) && (words[i + 3] == data4))
            //    {
            //        flag = true;
            //        getdataa = words[i];
            //        // dataa = words[i + 2];
            //        loadbalnce = words[i + 4];

            //        break;



            //    }



            //        i++;



            //}

            //if (flag)
            //          {
            //    return true;

            //          }


            return false;

        }
        /*    public static bool readtext(string data2, string data4)
            {
                int i=0;
                bool flag = false ;
                StreamReader file = new StreamReader(data);
                string dat = file.ReadToEnd();
                string[] lines ;
                lines = dat.Split(':');


                while (lines[i]!= (lines.Length-1).ToString())
                {
                  //  i = lines.Length-1;
         xy:
                    System.Windows.Forms.MessageBox.Show("Test",lines[i+2]);
                    if (((lines[i + 2].Contains(data2)) && ((lines[i + 3].Contains(data4)))))
                    {

                        flag = true;
                        break;
                    }
                    // else  if 
                    //{
                        //flag = false;

                    else if (!(lines[i+2].Contains(data2) && lines[i+3].Contains(data4)))
                    {
                        flag = false;
                        if (i > lines.Length - 1)
                        {
                            break;
                        }
                        else
                        {
                            i++;
                            goto xy;
                        }
                        //if (i!=lines.Length-1)
                        //{
                        //    i++; 
                        //}
                        //break;  
                   }
                    else
                    {
                        break;
                    }

                   // break;
                   // break;
                    //break;
                    //}


                    //i += dat.Length - 1;  
                }
                if (flag==true)
                {
                    return flag;
                }

                return false;

            }*/


    }
}
