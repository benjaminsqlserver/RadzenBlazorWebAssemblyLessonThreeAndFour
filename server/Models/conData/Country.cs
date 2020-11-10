using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaApp.Models.ConData
{
  [Table("Countries", Schema = "dbo")]
  public partial class Country
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CountryID
    {
      get;
      set;
    }

    public IEnumerable<Student> Students { get; set; }
    public IEnumerable<Student> Students1 { get; set; }
    public IEnumerable<Student> Students2 { get; set; }
    public IEnumerable<Student> Students3 { get; set; }
    public string CountryName
    {
      get;
      set;
    }
  }
}
