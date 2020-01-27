using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;
/// <summary>
/// Summary description for DL_M_TuitionFee
/// </summary>
public class DL_M_TuitionFee
{
    public DL_M_TuitionFee()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    MyConnection con = new MyConnection();
    public int Insert(PL_M_TuitionFee pl, string xmlDoc)
    {
        con.cmd.CommandText = "USP_M_TuitionFee";
        con.cmd.CommandType = CommandType.StoredProcedure;
        con.cmd.Parameters.AddWithValue("@sptype", pl.sptype);
        con.cmd.Parameters.AddWithValue("@ECODE", pl.ECODE);
        con.cmd.Parameters.AddWithValue("@EMP_NAME", pl.EMP_NAME);
        con.cmd.Parameters.AddWithValue("@EmpType", pl.EmpType);
        con.cmd.Parameters.AddWithValue("@fin_year", pl.fin_year);
        con.cmd.Parameters.AddWithValue("@GPS_NPS", pl.GPS_NPS);
        con.cmd.Parameters.AddWithValue("@TableID", pl.TableID);
        con.cmd.Parameters.AddWithValue("@freeze_flage", pl.freeze_flage);
        con.cmd.Parameters.AddWithValue("@refrence_no", pl.refrence_no);
        con.cmd.Parameters.AddWithValue("@CREATEDBY", pl.CreatedBy);
        con.cmd.Parameters.AddWithValue("@xmlDoc", xmlDoc);

        SqlParameter p2 = new SqlParameter("@P_MSG", SqlDbType.VarChar, 200);
        p2.Direction = ParameterDirection.Output;
        con.cmd.Parameters.Add(p2);
        try
        {
            con.Open();
            int RetValue = con.cmd.ExecuteNonQuery();
            pl.MSG = con.cmd.Parameters["@P_MSG"].Value.ToString();
            return RetValue;
        }
        catch (Exception ex)
        {
           // pl.MSG = con.cmd.Parameters["@P_MSG"].Value.ToString();
            con.Close();
            return 0;
        }
        finally
        {
            con.Close();
            con.cmd.Dispose();
        }

    }

    internal DataTable bindData(PL_M_TuitionFee pl)
    {
     
            con.cmd.CommandText = "USP_M_TuitionFee";
            con.cmd.CommandType = CommandType.StoredProcedure;
            con.cmd.Parameters.AddWithValue("@SpType", pl.sptype);
            con.cmd.Parameters.AddWithValue("@TableID", pl.TABLEID);
            SqlParameter p2 = new SqlParameter("@P_MSG", SqlDbType.VarChar, 350);
            p2.Direction = ParameterDirection.Output;
            con.cmd.Parameters.Add(p2);
            SqlDataAdapter da = new SqlDataAdapter(con.cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
       
    }
    public DataTable getData(PL_M_TuitionFee pl)
    {

        con.cmd.CommandText = "USP_M_TuitionFee";
        con.cmd.CommandType = CommandType.StoredProcedure;
        con.cmd.Parameters.AddWithValue("@SpType", pl.sptype);
        con.cmd.Parameters.AddWithValue("@TableID", pl.TABLEID);

        SqlParameter p2 = new SqlParameter("@P_MSG", SqlDbType.VarChar, 350);
        p2.Direction = ParameterDirection.Output;
        con.cmd.Parameters.Add(p2);
        SqlDataAdapter da = new SqlDataAdapter(con.cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;

    }
    public virtual int Delete(PL_M_TuitionFee pl)
    {
        con.cmd.CommandText = "USP_M_TuitionFee";
        con.cmd.CommandType = CommandType.StoredProcedure;
        con.cmd.Parameters.AddWithValue("@SpType", pl.sptype);
        con.cmd.Parameters.AddWithValue("@TableID", pl.TABLEID);

        SqlParameter p2 = new SqlParameter("@P_MSG", SqlDbType.VarChar, 2000);
        p2.Direction = ParameterDirection.Output;
        con.cmd.Parameters.Add(p2);
        System.Data.SqlTypes.SqlDateTime getDate;
        getDate = SqlDateTime.Null;

        try
        {
            con.Open();
            int RetValue = con.cmd.ExecuteNonQuery();
            con.Close();
            pl.MSG = con.cmd.Parameters["@P_MSG"].Value.ToString();
            return RetValue;
        }
        catch (Exception ex)
        {
            pl.MSG = ex.Message.ToString();
            return 0;
        }
        finally
        {
            if (con.Mycon.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.cmd.Dispose();
        }

    }

    public virtual int Freeze(PL_M_TuitionFee pl)
    {
        MyConnection Mycon = new MyConnection();
        Mycon.cmd.CommandText = "USP_M_TuitionFee";
        Mycon.cmd.CommandType = CommandType.StoredProcedure;
        Mycon.cmd.Parameters.AddWithValue("@sptype", pl.sptype);
        Mycon.cmd.Parameters.AddWithValue("@TABLEID", pl.TABLEID);
        Mycon.cmd.Parameters.AddWithValue("@refrence_no", pl.refrence_no);
        Mycon.cmd.Parameters.AddWithValue("@freeze_flage", pl.freeze_flage);
        Mycon.cmd.Parameters.AddWithValue("@ref_status", pl.ref_status);
        SqlParameter p2 = new SqlParameter("@P_MSG", SqlDbType.VarChar, 8000);
        p2.Direction = ParameterDirection.Output;
        Mycon.cmd.Parameters.Add(p2);

        try
        {
            Mycon.Open();
            int RetValue = Mycon.cmd.ExecuteNonQuery();
            pl.MSG = Mycon.cmd.Parameters["@P_MSG"].Value.ToString();
            return RetValue;
        }
        catch (Exception ex)
        {
            pl.MSG = ex.Message.ToString();
            return 0;
        }
        finally
        {
            if (Mycon.Mycon.State == ConnectionState.Open)
            {
                Mycon.Close();
            }
            Mycon.cmd.Dispose();
        }

    }
}