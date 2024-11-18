public class Helper
{
    public static String GetBasketHtml(Int32 BasketID, bool sendByManager, ref string strBasketUniqueID)
    {
        String strPartnerName = "";
        String strDeliveryAddress = "";
        Int32 iPrepayment = 0;
        Int32 iPrepaymentDone = 0;
        Int32 iDeliveryMethod = 0;
        Int32 iDisbursmentDays = 0;
        String strDeliveryDate = "";
        String strDisbursmentDate = "";


        String strBasketLines = "";

        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBajtel"].ConnectionString))
        {
            connection.Open();

            SqlCommand cmdBasket = new SqlCommand("SELECT * FROM vwBasket WHERE BasketID=@BasketID", connection);
            cmdBasket.Parameters.AddWithValue("@BasketID", BasketID);

            SqlDataReader readerBasket = cmdBasket.ExecuteReader();
            if (readerBasket.HasRows && readerBasket.Read())
            {
                strPartnerName = readerBasket["PartnerName"].ToString();
                strDeliveryAddress = readerBasket["DeliveryAddress"].ToString();
                strBasketUniqueID = Convert.ToInt32(readerBasket["BasketUniqueID"]).ToString("000000");
                iPrepayment = Convert.ToInt32(readerBasket["Prepayment"]);
                iPrepaymentDone = Convert.ToInt32(readerBasket["PrepaymentDone"]);
                iDeliveryMethod = Convert.ToInt32(readerBasket["DeliveryMethod"]);
                iDisbursmentDays = Convert.ToInt32(readerBasket["DisbursmentDays"]);
                if (iDisbursmentDays == -1)
                    iDisbursmentDays = 10;
                strDeliveryDate = readerBasket["DeliveryDate"].ToString();
                strDisbursmentDate = string.IsNullOrEmpty(readerBasket["DisbursementTerm"].ToString()) ? "" : Convert.ToDateTime(readerBasket["DisbursementTerm"]).ToShortDateString();
            }
            readerBasket.Close();

            SqlCommand cmdBasketLines = new SqlCommand("SELECT * FROM vwBasketLine WHERE BasketID = @BasketID AND BasketLineTypeID = 1", connection);
            cmdBasketLines.Parameters.AddWithValue("@BasketID", BasketID);

            SqlDataReader readerBasketLines = cmdBasketLines.ExecuteReader();
            if (readerBasketLines.HasRows)
            {
                strBasketLines += "<table style='font-family: Arial;font-size: 11px;' cellpadding='3' cellspacing='0' border='1'><tr><td>Code</td><td>Product</td><td>Unit</td><td>Price (EUR)</td><td>Amount</td><td>VAT</td><td>Total (EUR)</td></tr> ";
                while (readerBasketLines.Read())
                {
                    strBasketLines += String.Concat(
                        "<tr>",
                        "<td>", readerBasketLines["ProductCode"], "</td> ",
                        "<td>", readerBasketLines["ProductName"], "</td> ",
                        "<td>", readerBasketLines["ProductUnitName"], "</td> ",
                        "<td style='text-align:right'>", String.Format("{0:f2}", readerBasketLines["Price"]), "</td> ",
                        "<td>", String.Format("{0:f2}", readerBasketLines["Quantity"]), "</td> ",
                        "<td>", String.Format("{0:f2}", readerBasketLines["VatRate"]), "</td> ",
                        "<td style='text-align:right'>", String.Format("{0:f2}", readerBasketLines["AmountFinal"]), "</td> ",
                        "</tr>");
                }
                string strText1 = "";
                string strText2 = "";
                if (Helper.GetBasketLineTotals(BasketID, ref strText1, ref strText2))
                {
                    strBasketLines += String.Concat(
                        "<tr>",
                        "<td colspan='6'>", strText1, "</td> ",
                        "<td style='text-align:right'>", strText2, "</td> ",
                        "</tr>");
                }
                strBasketLines += "</table>";
            }
            readerBasketLines.Close();

            connection.Close();
        }

        string strBasketHtml = "";
        strBasketHtml = string.Concat(
        "<p>Dear Partner,</p>",

        "<p>You have received this email as a proof that you or a responsible manager at Bajtel.LV has placed an order for ",
        strPartnerName,
        sendByManager ? " or there was a change in your order status" : "",
        "</p>",

        "<p><b>Your unique order number: ", strBasketUniqueID, "</b></p>",

        "<p><b>Order details:</b></p>",
        "<div>Partner: ", strPartnerName, "</>",
        "<div>Delivery method: ",
        iDeliveryMethod == 1 ? "Pick up at DPD Paku Bode Uriekstes iela 8a, Rîga (10:00 – 18:00 working days). Please use your order number at pick up location at DPD." : "Delivery to \"" + strDeliveryAddress + "\"",
        "</div>",
        "<div>Payment terms: ",
        iPrepayment == 1 ? (iPrepaymentDone == 0 ? "Prepayment " : "Prepayment (PAID) ") : "Postpayment ",
        iDisbursmentDays.ToString(), " days</div>",
        "<div>Payment deadline: ", strDisbursmentDate, "</div>",

        "<p><b>Order status: ",
        iPrepayment == 1 && iPrepaymentDone == 0 ? "Awaiting prepayment" : "Processing",
        "</b></p>",
        "<p>As soon as you order is ready to be shipped or picked up you will receive an automatic email with final invoice. </p>",
        "<p><b>Order contents:</b></p>",
        strBasketLines);

        return strBasketHtml;
    }
    public static bool GetBasketLineTotals(Int32 BasketID, ref string strText1, ref string strText2)
    {
        return GetBasketLineTotalsEx(BasketID, "", ref strText1, ref strText2, 0);
    }
    public static bool GetBasketLineTotals(string UserName, ref string strText1, ref string strText2, int PartnerID)
    {
        return GetBasketLineTotalsEx(0, UserName, ref strText1, ref strText2, PartnerID);
    }
    public static bool GetBasketLineTotalsEx(Int32 BasketID, string UserName, ref string strText1, ref string strText2, int PartnerID)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBajtel"].ConnectionString))
        {
            connection.Open();
            SqlCommand cmd;
            if (BasketID == 0)
            {
                cmd = new SqlCommand("SELECT * FROM vwBasketLineTotal_V2 WHERE UserName = @UserName AND PartnerID = @PartnerID", connection);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@PartnerID", PartnerID);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM vwBasketLineTotal_V2 WHERE BasketID = @BasketID", connection);
                cmd.Parameters.AddWithValue("@BasketID", BasketID);
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                String strVatRate = "";
                if (reader["VatRate"].Equals(DBNull.Value))
                    strVatRate = "-";
                else
                {
                    Decimal dVatRate = Convert.ToDecimal(reader["VatRate"]);
                    strVatRate = dVatRate.ToString("g0");
                }
                Decimal dAmount = reader["TotalEUR"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["TotalEUR"]);
                Decimal dAmountWithVat = reader["TotalEUR_WithVAT"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["TotalEUR_WithVAT"]);
                Decimal dAmountVat = reader["VatRate"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["TotalEUR_VAT"]);

                if (strVatRate != "0")
                {
                    strText1 += "<div style='font-weight:normal;'>to be taxed with VAT " + strVatRate + "%</div>";
                    strText1 += "<div style='font-weight:normal;'>VAT " + strVatRate + "%</div>";

                    strText2 += "<div style='font-weight:normal;'>" + dAmount.ToString("f2") + "</div>";
                    strText2 += "<div style='font-weight:normal;'>" + dAmountVat.ToString("f2") + "</div>";
                }

                strText1 += "<div style='font-weight:normal;'>Total</div>";
                strText2 += "<div style='font-weight:normal;'>" + dAmountWithVat.ToString("f2") + "</div>";

            }
            connection.Close();
        }
        return true;
    }
}