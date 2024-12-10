using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the number of candidates :");
            //int c = Convert.ToInt32(Console.ReadLine());

            //Candidate[] candidates = new Candidate[c];
            //for (int i = 0; i < c; i++)
            //{
            //    candidates[i] = new Candidate();
            //    candidates[i].GetCandidateDetails();
            //}

            //for (int i = 0; i < c; i++)
            //{
            //    candidates[i].DisplayCandidateDetails();
            //}

            //Console.WriteLine("Enter the number of Staff Members :");
            //int s = Convert.ToInt32(Console.ReadLine());

            //Staff[] staff = new Staff[s];
            //for (int i = 0; i < s; i++)
            //{
            //    staff[i] = new Staff();
            //    staff[i].GetStaffDetails();
            //}

            //for (int i = 0; i < s; i++)
            //{
            //    if (staff[i].Design() == "hod")
            //    {
            //        {
            //            staff[i].DisplayStaffDetails();
            //        }

            //    }
            //}

            Console.WriteLine("Enter the number of Bank_Account Holders :");
            int b = Convert.ToInt32(Console.ReadLine());

            Bank_Account[] bank = new Bank_Account[b];
            for (int i = 0; i < b; i++)
            {
                bank[i] = new Bank_Account();
                bank[i].GetBankDetails();
            }

            for (int i = 0; i < b; i++)
            {
                bank[i].DisplayBankDetails();
            }

        }
    }
}
