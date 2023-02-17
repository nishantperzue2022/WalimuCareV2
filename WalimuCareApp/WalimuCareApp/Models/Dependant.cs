﻿

using System;

namespace WalimuCareApp.Models
{
    public class Dependant
    {
        public string Id { get; set; }
        public string MemberNumber { get; set; }
        public string PrincipalNumber { get; set; }
        public string FirstName { get; set; }
        public object MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string Gender { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public object Relation { get; set; }
        public string PhoneNumber { get; set; }
        public string JobGroup { get; set; }
        public string Country { get; set; }
        public string Occupation { get; set; }
        public object Email { get; set; }
        public string FullAddress { get; set; }
        public string Pin { get; set; }
        public string EmployerRegistrationNumber { get; set; }
        public string NhifNumber { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string SuspensionRemarks { get; set; }
        public string DeleteRemarks { get; set; }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Subtract(DateOfBirth).Days;

                age = (age / 365);

                return age;

            }
        }

        public string StatusDescription
        {
            get
            {
                var status = Status;

                if (status == 0)
                {
                    var data = "Awaiting Approval";

                    return data;
                }
                if (status == 1)
                {
                    var data = "Active";

                    return data;
                }
                if (status == 2)
                {
                    var data = "Suspended";

                    return data;
                }
                var k = "Deleted";

                return k;
            }
        }

    }

}
