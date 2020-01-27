using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PL_M_TuitionFee
/// </summary>
public class PL_M_TuitionFee
{
    public PL_M_TuitionFee()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int sptype { get; set; }
    public int TableID { get; set; }
    public string ECODE { get; set; }
    public string EMP_NAME { get; set; }
    public string EmpType { get; set; }
    public string GPS_NPS { get; set; }
    public string fin_year { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
    public int TABLEID { get; set; }
    public string xml { get; set; }
    public string MSG { get; set; }
    public string freeze_flage { get; set; }
    public string refrence_no { get; set; }
    public string ref_status { get; set; }

}
public class PL_levelchild
{

    public string ChildName { get; set; }     
    public DateTime DOB { get; set; }
    public string Class { get; set; }
    public string SchoolName { get; set; }    
    public string Monthly_TuitionFee { get; set; }
    public decimal TuitionFee_Actually_Paid { get; set; }
    public decimal Amount_Reimbursement_Claimed { get; set; }
    


}