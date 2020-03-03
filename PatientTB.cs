using System;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
   public class PatientTB
   {
      [Key]
       public int PatrientID { get; set; }
public string PatientName { get; set; }
public DateTime DOB { get; set; }
public int Age { get; set; }
public string Address { get; set; }
public float Mobile { get; set; }
public DateTime CreateDate { get; set; }
public int CreatedBy { get; set; }
public DateTime ModifiedDate{ get; set; }
public int ModifiedBy { get; set; }

   } 
}