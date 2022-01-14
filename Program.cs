using System.Collections.Generic;
using System;

namespace Day1_CS
{
    class Program
    {
        static List<Member> members = new List<Member>{
             new Member
            {
                FirstName = "Phuong",
                LastName = "Nguyen Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 22),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Nam",
                LastName = "Nguyen Thanh",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 20),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Son",
                LastName = "Do Hong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 11, 6),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Huy",
                LastName = "Nguyen Duc",
                Gender = "Male",
                DateOfBirth = new DateTime(1996, 1, 26),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Hoang",
                LastName = "Phuong Viet",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 2, 5),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Long",
                LastName = "Lai Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 5, 30),
                PhoneNumber = "",
                BirthPlace = "Bac Giang",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Thanh",
                LastName = "Tran Chi",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 9, 18),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
        };
        static void Main(string[] args)
        {
            //1. Return all Male Members
            var maleMembers = GetMaleMembers();
            PrintData(maleMembers);

            //2. Find oldest member
            // var oldestMembers = GetOldestMember();
            // PrintData(new List<Member> {oldestMembers});

            //3. Full Name Members
            // var fullnames = GetFullNames();
            // foreach (var fullname in fullnames)
            // {
            //     Console.WriteLine(fullname);
            // }

            // 4. List members by birth year
            // var results = SplitMembersByBirthYear();
            // Console.WriteLine("-----------Year is 2000-----------");
            // PrintData(results.Item1);
            // Console.WriteLine("-------Year Greater than 2000------");
            // PrintData(results.Item2);
            // Console.WriteLine("-------Year Less than 2000--------");
            // PrintData(results.Item3);

            // 5. Get members who was born in Ha Noi
            // var result = GetMembersByBirthPlace("Ha noi");
            // PrintData(result);
        }
        static void PrintData(List<Member> data)
        {
            var index = 0;
            foreach (var item in data)
            {
                ++index;
                Console.WriteLine($"{index}. {item.LastName} {item.FirstName} - {item.DateOfBirth.ToString("dd/MM/yyyy")} - [{item.Age}]");
            }
        }
        static List<Member> GetMaleMembers()
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                if (member.Gender == "Male")
                {
                    result.Add(member);
                }
            }
            return result;
        }
        static Member GetOldestMember(){
            var maxDays = members[0].TotalDays;
            var maxAgeIndex = 0;
            for(var i = 1; i < members.Count; i++ ){
                var member = members[i];
                if (member.TotalDays > maxDays)
                {
                    maxDays = member.TotalDays;
                    maxAgeIndex = i;
                }
            }
            return members[maxAgeIndex];
        }
        static List<string> GetFullNames(){
            var result = new List<string>();
            foreach(var member in members){
                 result.Add($"{member.LastName} {member.FirstName}");
            }
            return result;
        }
        static Tuple<List<Member>, List<Member>, List<Member>>  SplitMembersByBirthYear(){
            var listBirthYear = new List<Member>();
            var listBirthYearGreater =new List<Member>();
            var listBirthYearLess = new List<Member>();
            foreach (var member in members)
            {
                var birthYear = member.DateOfBirth.Year;
                switch (birthYear){
                    case 2000:
                        listBirthYear.Add(member);
                        break;
                    case > 2000:
                        listBirthYearGreater.Add(member);
                        break;
                    case < 2000:
                        listBirthYearLess.Add(member);
                        break;
                }
                return Tuple.Create(listBirthYear,listBirthYearGreater,listBirthYearLess);
            }
        }
        static List<Member> GetMembersByBirthPlace(string place){
            var result = new List<Member>();
            foreach (var member in members)
            {
                if(member.BirthPlace.Equals(place, StringComparison.CurrentCultureIgnoreCase)){
                    result.Add(member);
                }
            }
            return result;
        }
        
    }
    
}
