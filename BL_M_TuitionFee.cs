using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BL_M_TuitionFee
/// </summary>
public class BL_M_TuitionFee
{
    public BL_M_TuitionFee()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Insert(PL_M_TuitionFee pl, string xmlDoc)
    {
        DL_M_TuitionFee obj = new DL_M_TuitionFee();
        return obj.Insert(pl, xmlDoc);
    }

    public DataTable bindData(PL_M_TuitionFee pl)
    {
        DL_M_TuitionFee obj = new DL_M_TuitionFee();
        return obj.bindData(pl);
    }

    public DataTable getData(PL_M_TuitionFee pl)
    {
        DL_M_TuitionFee obj = new DL_M_TuitionFee();
        return obj.getData(pl);
    }
    public virtual int Delete(PL_M_TuitionFee pl)
    {
        DL_M_TuitionFee objDAL = new DL_M_TuitionFee();
        return objDAL.Delete(pl);
    }

    public virtual int Freeze(PL_M_TuitionFee pl)
    {
        DL_M_TuitionFee objDAL = new DL_M_TuitionFee();
        return objDAL.Freeze(pl);
    }
}