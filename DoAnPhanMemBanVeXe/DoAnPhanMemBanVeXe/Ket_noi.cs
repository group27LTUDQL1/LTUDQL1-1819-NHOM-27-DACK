﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnPhanMemBanVeXe
{
    static class Ket_noi
    {
        #region "Hoàn thành"
        public static SqlConnection connect;

        public static void Tao_ket_noi()
        {
            if (connect == null)
            {
                string chuoi_ket_noi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBenXe;Integrated Security=True";
                connect = new SqlConnection(chuoi_ket_noi);
            }
        }

        public static DataTable Doc_bang(string lenh)
        {
            Tao_ket_noi();
            DataTable bang = new DataTable();
            SqlDataAdapter bo_doc_ghi = new SqlDataAdapter(lenh, connect);
            bo_doc_ghi.FillSchema(bang, SchemaType.Source);
            bo_doc_ghi.Fill(bang);
            return bang;
        }
        #endregion
    }
}
