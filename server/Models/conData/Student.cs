using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaApp.Models.ConData
{
  [Table("Students", Schema = "dbo")]
  public partial class Student
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 StudentID
    {
      get;
      set;
    }
    public string SchoolAdmissionNumber
    {
      get;
      set;
    }
    public string Surname
    {
      get;
      set;
    }
    public string FirstName
    {
      get;
      set;
    }
    public string OtherNames
    {
      get;
      set;
    }
    public int GenderID
    {
      get;
      set;
    }
    public Gender Gender { get; set; }
    public int NationalityID
    {
      get;
      set;
    }
    public Country Country { get; set; }
    public string Username
    {
      get;
      set;
    }
    public string Password
    {
      get;
      set;
    }
    public string ConfirmPassword
    {
      get;
      set;
    }
    public string FatherSurname
    {
      get;
      set;
    }
    public string FatherFirstName
    {
      get;
      set;
    }
    public string FatherOtherNames
    {
      get;
      set;
    }
    public int? FatherNationalityID
    {
      get;
      set;
    }
    public Country Country1 { get; set; }
    public string FatherEmail
    {
      get;
      set;
    }
    public string FatherTelephone
    {
      get;
      set;
    }
    public string FatherProfession
    {
      get;
      set;
    }
    public string FatherOffice
    {
      get;
      set;
    }
    public string FatherResidentialAddress
    {
      get;
      set;
    }
    public string MotherSurname
    {
      get;
      set;
    }
    public string MotherFirstName
    {
      get;
      set;
    }
    public string MotherOtherNames
    {
      get;
      set;
    }
    public int? MotherNationalityID
    {
      get;
      set;
    }
    public Country Country2 { get; set; }
    public string MotherEmail
    {
      get;
      set;
    }
    public string MotherTelephone
    {
      get;
      set;
    }
    public string MotherProfession
    {
      get;
      set;
    }
    public string MotherOffice
    {
      get;
      set;
    }
    public string MotherResidentialAddress
    {
      get;
      set;
    }
    public string GuardianSurname
    {
      get;
      set;
    }
    public string GuardianFirstName
    {
      get;
      set;
    }
    public string GuardianOtherNames
    {
      get;
      set;
    }
    public int? GuardianNationalityID
    {
      get;
      set;
    }
    public Country Country3 { get; set; }
    public string GuardianEmail
    {
      get;
      set;
    }
    public string GuardianTelephone
    {
      get;
      set;
    }
    public string GuardianProfession
    {
      get;
      set;
    }
    public string GuardianOffice
    {
      get;
      set;
    }
    public string GuardianResidentialAddress
    {
      get;
      set;
    }
  }
}
