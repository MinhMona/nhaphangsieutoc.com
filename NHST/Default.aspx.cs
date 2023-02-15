using NHST.Bussiness;
using NHST.Controllers;
using Supremes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace NHST
{
    public partial class Default4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            var confi = ConfigurationController.GetByTop1();
            if (confi != null)
            {
                string email = confi.EmailContact;
                string hotline = confi.Hotline;
                string timework = confi.TimeWork;
                ltrEmail.Text += "<a class=\"img\" href=\"mailto:" + email + "\"><i class=\" fa fa-envelope\"></i></a>";
                ltrEmail.Text += "<a class=\"info\" href=\"mailto:" + email + "\">";
                ltrEmail.Text += "<div class=\"title\"><strong>Email Contact</strong></div>";
                ltrEmail.Text += "<p>" + email + "</p>";
                ltrEmail.Text += "</a>";

                ltrTimeWork.Text += "<a class=\"img\"><i class=\" fa fa-clock-o\"></i></a>";
                ltrTimeWork.Text += "<a class=\"info\">";
                ltrTimeWork.Text += "<div class=\"title\"><strong>Giờ hoạt động</strong></div>";
                ltrTimeWork.Text += "<p>" + timework + "</p>";
                ltrTimeWork.Text += "</a>";

                ltrHotline.Text += "<a class=\"img\" href=\"tel:" + hotline + "\"><i class=\" fa fa-phone\"></i></a>";
                ltrHotline.Text += "<a class=\"info\" href=\"tel:" + hotline + "\">";
                ltrHotline.Text += "<div class=\"title\"><strong>Hotline</strong></div>";
                ltrHotline.Text += "<p>" + hotline + "</p>";
                ltrHotline.Text += "</a>";
            }

            #region Lấy thông tin trang chủ
            var steps = StepController.GetAll("");
            if (steps.Count > 0)
            {
                int count = 1;
                foreach (var s in steps)
                {
                    string name = s.StepName;
                    string namenotdau = LeoUtils.ConvertToUnSign(name);

                    if (count == 1)
                    {
                        ltrStep1.Text += "<div class=\"step active current\" data-toggle=\"register-steps\">";
                    }
                    else
                    {
                        ltrStep1.Text += "<div class=\"step\" data-toggle=\"register-steps\">";
                    }

                    ltrStep1.Text += "<div class=\"step-img\">";
                    ltrStep1.Text += "<img src=\"" + s.Icon + "\" alt=\"\">";
                    ltrStep1.Text += "</div>";
                    ltrStep1.Text += "<h4 class=\"title\">" + s.StepName + "</h4>";
                    ltrStep1.Text += "</div>";


                    ltrStep2.Text += "<div class=\"slider-item\">";
                    ltrStep2.Text += "<div class=\"inner\">";
                    ltrStep2.Text += "<div class=\"img\"><img src=\"" + s.StepIMG + "\" alt=\"\"></div>";
                    ltrStep2.Text += "<div class=\"info\">";
                    ltrStep2.Text += "<div class=\"title\">" + name + "</div>";
                    ltrStep2.Text += "<p class=\"spec\">" + s.StepContent + "</p>";
                    //if (!string.IsNullOrEmpty(s.StepLink))
                    //    ltrStep2.Text += "<a class=\"main-btn alt\" href=\"" + s.StepLink + "\">Đăng ký</a>";
                    ltrStep2.Text += "</div>";
                    ltrStep2.Text += "</div>";
                    ltrStep2.Text += "</div>";
                    count++;
                }
            }

            var services = ServiceController.GetAll().OrderBy(x => x.Position).ToList();
            if (services.Count > 0)
            {
                foreach (var item in services)
                {
                    ltrService.Text += "<li>";
                    ltrService.Text += "<div class=\"img wow bounceIn\" data-wow-duration=\"1s\" data-wow-delay=\"0s\">";
                    ltrService.Text += "<img src=\"" + item.ServiceIMG + "\" alt=\"\"></div>";
                    ltrService.Text += "<div class=\"info wow fadeInUp\" data-wow-duration=\"1s\" data-wow-delay=\"0s\">";
                    ltrService.Text += "<div class=\"title\" style=\"font-weight: bold\">" + item.ServiceName + "</div>";
                    ltrService.Text += "<p class=\"spec\">" + item.ServiceContent + "</p>";
                    //if (!string.IsNullOrEmpty(item.ServiceLink))
                    //    ltrService.Text += "<a href=\"" + item.ServiceLink + "\" class=\"main-btn alt\">Xem chi tiết</a>";
                    ltrService.Text += "</div>";
                    ltrService.Text += "</li>";
                }
            }

            var ql = CustomerBenefitsController.GetAll("");
            if (ql.Count > 0)
            {
                foreach (var q in ql)
                {
                    ltrBenefits.Text += "<div class=\"colum\">";
                    ltrBenefits.Text += "<div class=\"content\">";
                    ltrBenefits.Text += "<div class=\"box-img\"><img src=\"" + q.Icon + "\" alt=\"\"></div>";
                    ltrBenefits.Text += "<div class=\"box-intro\">";
                    ltrBenefits.Text += "<h3 class=\"title-intro\"><a href=\"/\">" + q.CustomerBenefitName + "</a></h3>";
                    ltrBenefits.Text += "<p class=\"desc-intro\">" + q.CustomerBenefitDescription + "</p>";
                    if (!string.IsNullOrEmpty(q.CustomerBenefitLink))
                        ltrBenefits.Text += "<a href=\"" + q.CustomerBenefitLink + "\" class=\"btn btn-red\">Xem thêm</a>";
                    ltrBenefits.Text += "</div>";
                    ltrBenefits.Text += "</div>";
                    ltrBenefits.Text += "</div>";
                }
            }

            #endregion

            try
            {
                string weblink = "https://nhaphangsieutoc.com/";
                string url = HttpContext.Current.Request.Url.AbsoluteUri;

                HtmlHead objHeader = (HtmlHead)Page.Header;

                //we add meta description
                HtmlMeta objMetaFacebook = new HtmlMeta();

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "fb:app_id");
                objMetaFacebook.Content = "676758839172144";
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:url");
                objMetaFacebook.Content = url;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:type");
                objMetaFacebook.Content = "website";
                objHeader.Controls.Add(objMetaFacebook);


                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:title");
                objMetaFacebook.Content = confi.OGTitle;
                objHeader.Controls.Add(objMetaFacebook);


                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:description");
                objMetaFacebook.Content = confi.OGDescription;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:image");
                objMetaFacebook.Content = weblink + confi.OGImage;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:image:width");
                objMetaFacebook.Content = "200";
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:image:height");
                objMetaFacebook.Content = "500";
                objHeader.Controls.Add(objMetaFacebook);

                HtmlMeta meta = new HtmlMeta();
                meta = new HtmlMeta();
                meta.Attributes.Add("name", "description");
                meta.Content = confi.MetaDescription;

                objHeader.Controls.Add(meta);

                this.Title = confi.MetaTitle;
                //meta = new HtmlMeta();
                //meta.Attributes.Add("name", "title");
                //meta.Content = "Võ Minh Thiên Logistics";
                //objHeader.Controls.Add(meta);


                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:title");
                objMetaFacebook.Content = confi.OGTitle;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:title");
                objMetaFacebook.Content = confi.OGTwitterTitle;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:description");
                objMetaFacebook.Content = confi.OGTwitterDescription;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:image");
                objMetaFacebook.Content = weblink + confi.OGTwitterImage;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:image:width");
                objMetaFacebook.Content = "200";
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:image:height");
                objMetaFacebook.Content = "500";
                objHeader.Controls.Add(objMetaFacebook);

            }
            catch
            {

            }
        }

        [WebMethod]
        public static string getPopup()
        {
            if (HttpContext.Current.Session["notshowpopup"] == null)
            {
                var conf = ConfigurationController.GetByTop1();
                string popup = conf.NotiPopup;
                if (popup != "<p><br data-mce-bogus=\"1\"></p>")
                {
                    NotiInfo n = new NotiInfo();
                    n.NotiTitle = conf.NotiPopupTitle;
                    n.NotiEmail = conf.NotiPopupEmail;
                    n.NotiContent = conf.NotiPopup;
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    return serializer.Serialize(n);
                }
                else
                    return "null";
            }
            else
                return "null";

        }
        [WebMethod]
        public static void setNotshow()
        {
            HttpContext.Current.Session["notshowpopup"] = "1";
        }
        public class NotiInfo
        {
            public string NotiTitle { get; set; }
            public string NotiContent { get; set; }
            public string NotiEmail { get; set; }
        }
        [WebMethod]
        public static string getInfo(string ordecode)
        {
            string returnString = "";
            var smallpackage = SmallPackageController.GetByOrderTransactionCode(ordecode);
            if (smallpackage != null)
            {
                int mID = 0;
                int tID = 0;
                if (smallpackage.MainOrderID != null)
                {
                    if (smallpackage.MainOrderID > 0)
                    {
                        mID = Convert.ToInt32(smallpackage.MainOrderID);
                    }
                    else if (smallpackage.TransportationOrderID != null)
                    {
                        if (smallpackage.TransportationOrderID > 0)
                        {
                            tID = Convert.ToInt32(smallpackage.TransportationOrderID);
                        }
                    }
                }
                else if (smallpackage.TransportationOrderID != null)
                {
                    if (smallpackage.TransportationOrderID > 0)
                    {
                        tID = Convert.ToInt32(smallpackage.TransportationOrderID);
                    }
                }
                string ordertype = "Chưa xác định";
                if (tID > 0)
                {
                    ordertype = "Đơn hàng vận chuyển hộ";
                }
                else if (mID > 0)
                {
                    ordertype = "Đơn hàng mua hộ";
                }

                returnString += "<aside class=\"side trk-info fr\"><table>";
                returnString += "   <tbody>";
                returnString += "       <tr>";
                returnString += "           <th style=\"width:50%\">Mã vận đơn:</th>";
                returnString += "           <td class=\"m-color\">" + ordecode + "</td>";
                returnString += "       </tr>";
                returnString += "       <tr>";
                returnString += "           <th style=\"width:50%\">ID đơn hàng:</th>";
                if (mID > 0)
                    returnString += "           <td class=\"m-color\">" + mID + "</td>";
                else if (tID > 0)
                    returnString += "           <td class=\"m-color\">" + tID + "</td>";
                else
                    returnString += "           <td class=\"m-color\">Chưa xác định</td>";
                returnString += "       </tr>";
                returnString += "       <tr>";
                returnString += "           <th style=\"width:50%\">Loại đơn hàng:</th>";
                returnString += "           <td class=\"m-color\">" + ordertype + "</td>";
                returnString += "       </tr>";
                returnString += "   </tbody>";
                returnString += "</table></aside>";
                returnString += "<aside class=\"side trk-history fl\"><ul class=\"list\">";
                if (smallpackage.Status == 0)
                {
                    returnString += "<li class=\"clear\">";
                    returnString += "  Mã vận đơn đã bị hủy";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 1)
                {
                    returnString += "<li class=\"clear\">";
                    returnString += "  Mã vận đơn chưa về kho TQ";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 2)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 3)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInLasteWareHouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInLasteWareHouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho đích</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 4)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInLasteWareHouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInLasteWareHouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho đích</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateOutWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateOutWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã giao khách</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNOutWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                returnString += "</ul></aside>";
            }
            else
            {
                returnString += "Không tồn tại mã vận đơn trong hệ thống";
            }
            return returnString;
        }
    }
}