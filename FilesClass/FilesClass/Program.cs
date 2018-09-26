using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Manager!");
            Console.WriteLine("===================");

            start:
            Console.WriteLine("1) Create A Text File \n2) Create An Image File \n3) Create An Audio File \n4) Create A Video File");
            Console.WriteLine("===================");
            Console.Write("Enter your choice : ");
            string x = Console.ReadLine();
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("===================");



            if (x == "1")
            {
                text();
            }
            else if (x == "2")
            {
                image();
            }
            else if (x == "3")
            {
                audio();
            }
            else if (x == "4")
            {
                video();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Please Try Again");
                Console.WriteLine("===================");
                goto start;
            }
        }

        //Text Method
        public static void text()
        {
            Console.Write("Enter the text name : ");
            string n = Console.ReadLine();
            Console.Write("Enter the text size : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter text content : ");
            string c = Console.ReadLine();
            text t = new text(c, n, s);
            tstart:
            //Operations on File
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("What Do You Want To Do ?");
            Console.WriteLine("1) View Content \n2) View Full Name");
            Console.WriteLine("===================");
            Console.Write("Enter Your Choice : ");
            string temp = Console.ReadLine();

            if (temp == "1")
            {
                t.view();
            }
            else if (temp == "2")
            {
                t.details();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Try Again");
                goto tstart;
            }
        }

        //Image Method
        public static void image()
        {
            Console.Write("Enter the image name : ");
            string n = Console.ReadLine();
            Console.Write("Enter the image size : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter image look : ");
            string c = Console.ReadLine();
            image i = new image(c, n, s);

            istart:
            //Operations on File
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("What Do You Want To Do ?");
            Console.WriteLine("1) View Content \n2) View Full Name");
            Console.WriteLine("===================");
            Console.Write("Enter Your Choice : ");
            string temp = Console.ReadLine();

            if (temp == "1")
            {
                i.view();
            }
            else if (temp == "2")
            {
                i.details();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Try Again");
                goto istart;
            }

        }

        //Audio Method
        public static void audio()
        {
            Console.Write("Enter the file name : ");
            string n = Console.ReadLine();
            Console.Write("Enter the audio size : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter audio tune : ");
            string c = Console.ReadLine();
            audio a = new audio(n, c, s);

            astart:
            //Operations on File
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("What Do You Want To Do ?");
            Console.WriteLine("1) View Content \n2) View Full Name");
            Console.WriteLine("===================");
            Console.Write("Enter Your Choice : ");
            string temp = Console.ReadLine();

            if (temp == "1")
            {
                a.play();
            }
            else if (temp == "2")
            {
                a.details();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Try Again");
                goto astart;
            }
        }

        //Video Method
        public static void video()
        {
            Console.Write("Enter the video name : ");
            string n = Console.ReadLine();
            Console.Write("Enter the video size : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter video content : ");
            string c = Console.ReadLine();
            video v = new video(n, c, s);

            vstart:
            //Operations on File
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("What Do You Want To Do ?");
            Console.WriteLine("1) View Content \n2) View Full Name");
            Console.WriteLine("===================");
            Console.Write("Enter Your Choice : ");
            string temp = Console.ReadLine();

            if (temp == "1")
            {
                v.play();
            }
            else if (temp == "2")
            {
                v.details();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Try Again");
                goto vstart;
            }
        }
    }

    //Parent class
    abstract class file
    {
        public string name;
        public int size;
        public file(string n, int s)
        {
            this.name = n;
            this.size = s;
        }
        public file()
        {

        }
        public virtual void details()
        {
            Console.WriteLine("File Name : " + name);
            Console.WriteLine("File Size = " + size);
        }
    }

    //child class 1
    class text : file
    {
        string ext;
        string content;

        public text(string c, string n, int s)
        {
            this.ext = ".txt";
            this.content = c;
            name = n;
            size = s;
        }
        public void view()
        {
            Console.WriteLine(content);
        }
        public override void details()
        {
            string fname = name + ext;
            Console.WriteLine("File Name : " + fname);
            Console.WriteLine("File Size = " + size);
        }
    }

    //child class 2
    class image : file
    {
        string img;
        string ext;
        public image(string i, string n, int s)
        {
            this.img = i;
            this.ext = ".jpg";
            name = n;
            size = s;
        }
        public void view()
        {
            Console.WriteLine("This is an image of a : " + img);
        }
        public override void details()
        {
            string fname = name + ext;

            Console.WriteLine("File Name : " + fname);
            Console.WriteLine("File Size = " + size);
        }
    }

    //child class 3
    class audio : file
    {
        string ext;
        string tune;
        public audio(string n, string t, int s)
        {
            this.ext = ".mp3";
            this.tune = t;
            name = n;
            size = s;
        }
        public void play()
        {
            Console.WriteLine(tune);
        }
        public override void details()
        {
            string fname = name + ext;

            Console.WriteLine("File Name : " + fname);
            Console.WriteLine("File Size = " + size);
        }
    }

    //child class 4
    class video : file
    {
        string ext;
        string content;
        public video(string n, string c, int s)
        {
            name = n;
            content = c;
            ext = ".mp4";
            size = s;
        }
        public override void details()
        {
            string fname = name + ext;

            Console.WriteLine("File Name : " + fname);
            Console.WriteLine("File Size = " + size);
        }
        public void play()
        {
            Console.WriteLine(content);
        }
    }
}