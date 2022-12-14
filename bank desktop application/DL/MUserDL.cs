using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using bank_desktop_application.BL;

namespace bank_desktop_application.DL
{
    class MUserDL
    {
        public static string path = "C:\\Users\\Aftab\\Desktop\\bank desktop application\\bank desktop application\\bank desktop application\\bin\\Debug\\ACCOUNT_HOLDER.txt";
        public static string Musers_path = "C:\\Users\\Aftab\\Desktop\\bank desktop application\\bank desktop application\\bank desktop application\\bin\\Debug\\MUSERS.txt";
        private static List<MUsers> muser_list = new List<MUsers>();
        private static List<MUsers> current_user_list = new List<MUsers>();
        internal static List<MUsers> Muser_list { get => muser_list; set => muser_list = value; }
        internal static List<MUsers> Current_user_list { get => current_user_list; set => current_user_list = value; }

        public static void storeUserIntoFile(MUsers user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.Username + "," + user.Password + "," + user.Roll);
            file.Flush();
            file.Close();
        }
        public static void storeUserIntoFileAGAIN()
        {
            StreamWriter file = new StreamWriter(Musers_path);
            foreach(MUsers user in MUserDL.muser_list)
            file.WriteLine(user.Username + "," + user.Password + "," + user.Roll);
            file.Flush();
            file.Close();
        }
        public static string check_user(MUsers ans)
        {

            for (int x = 0; x < muser_list.Count; x++)
            {
                if (ans.Username == muser_list[x].Username && ans.Password == muser_list[x].Password && ans.Roll == muser_list[x].Roll)
                {
                    return  muser_list[x].Roll;
                }
            }
            return null;

        }
        public static void d()
        {

        }
        public static void load_users()
        {
            StreamReader account_read = new StreamReader(Musers_path);

            string record;
            string username;
            string password;
            string roll;
            while ((record = account_read.ReadLine()) != null)
            {


                username = PARSE_RECORD(record, 0);
                //PARSE_FUNCTION(ref record,accountant_name,father_name,cnic,source_income,ref count);
                password = PARSE_RECORD(record, 1);
                roll = PARSE_RECORD(record, 2);
                MUsers add = new MUsers(username, password, roll);
                Muser_list.Add(add);


            }

            account_read.Close();
        }     
        public static void load_accountant()
        {
            StreamReader account_read = new StreamReader(path);
            string record;

            string nationality;
            string address ;
            string source_income ;
            string cnic_no ;
            string father_name ;
            string accounter_name ;
            int ID1;
            while ((record = account_read.ReadLine()) != null)
            {


                accounter_name = PARSE_RECORD(record, 0);
                //PARSE_FUNCTION(ref record,accountant_name,father_name,cnic,source_income,ref count);
                father_name = PARSE_RECORD(record, 1);
                cnic_no = PARSE_RECORD(record, 2);
                source_income = PARSE_RECORD(record, 3);
                nationality = PARSE_RECORD(record, 4);
                address = PARSE_RECORD(record, 6);
                ID1 = int.Parse(PARSE_RECORD(record, 5));
               
                Account_holder A = new Account_holder(accounter_name, father_name, cnic_no, source_income, nationality, address, ID1);
            Acc_holder_DL.Accounts_list.Add(A);
 }

            account_read.Close();
        }

        static string PARSE_RECORD(string record, int field)
        {
            int comma = 0;
            string item = "";
            for (int a = 0; a < record.Length; a++)
            {
                if (record[a] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[a];
                }
            }
            return item;
        }

    }
}

