using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Poker_Game
{
    public class UserAccount
    {
        private string username;
        private string password;
        private string name;
        private int winscore;
        private int losescore;
        public bool invalidinput; //this variable helps verify if the user has entered a correct username and password
        public UserAccount()
        {
            username = "default";
            password = "default";
            name = "Player";
            winscore = 0;
            losescore = 0;
            invalidinput = false;
        }
        public UserAccount(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            winscore = 0;
            losescore = 0;
            invalidinput = false;
        }
        public UserAccount(UserAccount otheraccount)
        {
            username = otheraccount.username;
            password = otheraccount.password;
            name = otheraccount.name;
            winscore = otheraccount.winscore;
            losescore = otheraccount.losescore;
            invalidinput = false;
        }
        public void AddWin()
        {
            winscore += 1;
        }
        public void AddLose()
        {
            losescore += 1;
        }
        public int getWins()
        {
            return winscore;
        }
        public int getLoses()
        {
            return losescore;
        }
        public string getName()
        {
            return name;
        }
        public string getUserName()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void WriteToFile()
        {
            FileStream fs = new FileStream("UserAccounts\\" + username + ".bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("*UserAccount*");
            bw.Write(username);
            bw.Write(password);
            bw.Write(name);
            bw.Write(winscore);
            bw.Write(losescore);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        public void LoadFromFile(string username, string password) //used for login, to check if the usernames and passwords are valid.
        {
            if (File.Exists("UserAccounts\\" + username + ".bin"))
            {
                FileStream fs = new FileStream("UserAccounts\\" + username + ".bin", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                if (br.ReadString() != "*UserAccount*")
                {
                    fs.Close();
                    br.Close();
                }
                else
                {
                    long length = br.BaseStream.Length;
                    this.username = br.ReadString();
                    this.password = br.ReadString();
                    name = br.ReadString();
                    winscore = br.ReadInt32();
                    losescore = br.ReadInt32();
                    fs.Close();
                    br.Close();
                }
                if (this.username != username || this.password != password)
                {
                    invalidinput = true;
                }
                else
                {
                    invalidinput = false;
                }
            }
            else
            {
                invalidinput = true; //if the file cannot be found, user has entered incorrect information
            }
        }
        public void reLoadFromFile() //used to reload an account (not for login purposes)
        {
            FileStream fs = new FileStream("UserAccounts\\" + username + ".bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            if (br.ReadString() != "*UserAccount*")
            {
                fs.Close();
                br.Close();
            }
            else
            {
                long length = br.BaseStream.Length;
                this.username = br.ReadString();
                this.password = br.ReadString();
                name = br.ReadString();
                winscore = br.ReadInt32();
                losescore = br.ReadInt32();
                fs.Close();
                br.Close();
            }
        }
    }
}
