<%@ Page Language="C#" MasterPageFile="~/NhapHangSieuToc.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NHST.Default4" %>

<asp:Content runat="server" ContentPlaceHolderID="head"></asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <main id="main-wrap">
        <div class="sec panel-sec wow fadeIn" data-wow-duration=".5s" data-wow-delay="0s">
            <img src="/App_Themes/NHSToc/images/home-panel.png" alt="" class="bg">
            <div class="inner">
                <div class="caption">
                    <p class="captlv1 wow fadeInDown" data-wow-duration="1s" data-wow-delay=".5s">
                        <img src="/App_Themes/NHSToc/images/capt-txt.png" alt="">
                    </p>
                    <p style="color: #fff; padding-bottom: 20px; padding-top: 20px; font-size: 20px; font-weight: bold;">
                        <br />
                        <a href="https://play.google.com/store/apps/details?id=com.nhaphangNhaphangsieutoc" target="_blank" class="main-btn cus chrome-btn-1 btn-app cus">
                            <img src="/App_Themes/NHSToc/images/chplay.png" /></a>
                        <a href="https://apps.apple.com/app/id1544224524" target="_blank" class="main-btn cus coccoc-btn-1 btn-app cus" style="margin-left: -20px">
                            <img src="/App_Themes/NHSToc/images/apple.png" /></a>
                    </p>
                </div>
            </div>
            <div class="sec-decor" id="truck-decor">
                <img src="/App_Themes/NHSToc/images/truck.png" alt="" class="">
            </div>
        </div>
        <div class="sec about-sec">
            <div class="all">
                <div class="main">
                    <div class="sec-tt wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                        <h2 class="tt-txt">VỀ <span class="hl-txt">DỊCH VỤ</span></h2>
                        <p class="deco">
                            <img src="/App_Themes/NHSToc/images/title-deco.png" alt="">
                        </p>
                    </div>
                    <div class="sec-spec">
                        <p class="inner">Nhập Hàng Siêu Tốc là giải pháp nhập hàng tối ưu cho quý khách. Chúng tôi mang lại cho khách hàng nguồn hàng phong phú với mức giá cực rẻ.</p>
                    </div>
                    <ul class="service-ul">
                        <asp:Literal runat="server" ID="ltrService"></asp:Literal>
                    </ul>
                </div>
            </div>
        </div>
        <div class="sec register-step-sec">
            <div class="all">
                <div class="main">
                    <div class="sec-tt wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                        <h2 class="tt-txt">HƯỚNG DẪN <span class="hl-txt">ĐĂNG KÝ</span></h2>
                        <p class="deco">
                            <img src="/App_Themes/NHSToc/images/title-deco.png" alt="">
                        </p>
                    </div>
                    <div class="sec-spec">
                        <p class="inner">Nhập hàng kinh doanh dễ dàng chỉ với vài thao tác.</p>
                    </div>
                    <div class="steps register-steps wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                        <asp:Literal runat="server" ID="ltrStep1"></asp:Literal>
                    </div>
                </div>
            </div>
            <div class="step-inner wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                <div class="all">
                    <div class="main">
                        <div class="slider-wrap">
                            <div class="slider-cont" id="step_register_slider">
                                <asp:Literal runat="server" ID="ltrStep2"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="sec param-sec">
            <div class="all">
                <div class="main">
                    <ul class="param-ul">
                        <li class="wow fadeInLeft" data-wow-duration="1s" data-wow-delay="0s">
                            <div class="img">
                                <img src="/App_Themes/NHSToc/images/param-img-1.png" alt="">
                            </div>
                            <div class="info">
                                <div class="title"><strong>5</strong></div>
                                <p class="spec">Năm kinh nghiệm</p>
                            </div>
                        </li>
                        <li class="wow bounceIn" data-wow-duration="1s" data-wow-delay=".5s">
                            <div class="img">
                                <img src="/App_Themes/NHSToc/images/param-img-2.png" alt="">
                            </div>
                            <div class="info">
                                <div class="title"><strong>12,456</strong></div>
                                <p class="spec">Khách Hàng</p>
                            </div>
                        </li>
                        <li class="wow fadeInRight" data-wow-duration="1s" data-wow-delay="0s">
                            <div class="img">
                                <img src="/App_Themes/NHSToc/images/param-img-3.png" alt="">
                            </div>
                            <div class="info">
                                <div class="title"><strong>85,560</strong></div>
                                <p class="spec">Đơn hàng</p>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="sec testimonial-sec overflow-y-sec">
            <div class="all">
                <div class="main">
                    <div class="sec-tt wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                        <h2 class="tt-txt">QUYỀN LỢI <span class="hl-txt">KHÁCH HÀNG</span></h2>
                        <p class="deco">
                            <img src="/App_Themes/NHSToc/images/title-deco.png" alt="">
                        </p>
                    </div>
                    <div class="slider-wrap wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                        <div class="slider-cont">
                            <div class="table-wrap">
                                <div class="columns">
                                    <asp:Literal runat="server" ID="ltrBenefits"></asp:Literal>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="sec contact-sec overflow-y-sec">
            <div class="all">
                <div class="main">
                    <div class="sec-tt wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                        <h2 class="tt-txt">Thông tin <span class="hl-txt">liên hệ</span></h2>
                        <p class="deco">
                            <img src="/App_Themes/NHSToc/images/title-deco.png" alt="">
                        </p>
                    </div>
                    <ul class="activity-ul">
                        <li class="hvr-icon-push wow fadeInUp" data-wow-duration="1s" data-wow-delay="0s">
                            <asp:Literal runat="server" ID="ltrEmail"></asp:Literal>
                        </li>
                        <li class="hvr-icon-push wow fadeInUp" data-wow-duration="1s" data-wow-delay=".3s">
                            <asp:Literal runat="server" ID="ltrTimeWork"></asp:Literal>
                        </li>
                        <li class="hvr-icon-push wow fadeInUp" data-wow-duration="1s" data-wow-delay=".6s">
                            <asp:Literal runat="server" ID="ltrHotline"></asp:Literal>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="map-wrap">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1477.9318986181488!2d105.82722562653265!3d21.026490654613575!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135ab760be2c301%3A0xce354fbc6f41b0e6!2zMTYwIEjDoG8gTmFtLCBDaOG7oyBE4burYSwgxJDhu5FuZyDEkGEsIEjDoCBO4buZaSwgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1545360541952" width="100%" height="100%" frameborder="0" style="border: 0" allowfullscreen></iframe>
            </div>
        </div>
    </main>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.txtsearchfield').on("keypress", function (e) {
                if (e.keyCode == 13) {
                    searchProduct();
                }
            });
        });

        function keyclose_ms(e) {
            if (e.keyCode == 27) {
                close_popup_ms();
            }
        }

        function close_popup_ms() {
            $("#pupip_home").animate({ "opacity": 0 }, 400);
            $("#bg_popup_home").animate({ "opacity": 0 }, 400);
            setTimeout(function () {
                $("#pupip_home").remove();
                $(".zoomContainer").remove();
                $("#bg_popup_home").remove();
                $('body').css('overflow', 'auto').attr('onkeydown', '');
            }, 500);
        }

        function closeandnotshow() {
            $.ajax({
                type: "POST",
                url: "/Default.aspx/setNotshow",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    close_popup_ms();
                },
                error: function (xmlhttprequest, textstatus, errorthrow) {
                    alert('lỗi');
                }
            });

        }
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: "/Default.aspx/getPopup",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    if (msg.d != "null") {
                        var data = JSON.parse(msg.d);
                        var title = data.NotiTitle;
                        var content = data.NotiContent;
                        var email = data.NotiEmail;
                        var obj = $('form');
                        $(obj).css('overflow', 'hidden');
                        $(obj).attr('onkeydown', 'keyclose_ms(event)');
                        var bg = "<div id='bg_popup_home'></div>";
                        var fr = "<div id='pupip_home' class=\"columns-container1\">" +
                            "  <div class=\"center_column col-xs-12 col-sm-5\" id=\"popup_content_home\">";
                        fr += "<div class=\"popup_header\">";
                        fr += title;
                        fr += "<a style='cursor:pointer;right:5px;' onclick='close_popup_ms()' class='close_message'></a>";
                        fr += "</div>";
                        fr += "     <div class=\"changeavatar\">";
                        fr += "         <div class=\"content1 over-flow-auto\">";
                        fr += content;
                        fr += "         </div>";
                        fr += "         <div class=\"content2 ab-top\">";
                        fr += "<a href=\"javascript:;\" class=\"btn btn-close-full\" onclick='closeandnotshow()'>Đóng & không hiện thông báo</a>";
                        fr += "<a href=\"javascript:;\" class=\"btn btn-close\" onclick='close_popup_ms()'>Đóng</a>";
                        fr += "         </div>";
                        fr += "     </div>";
                        fr += "<div class=\"popup_footer\">";
                        fr += "<span class=\"float-right\">" + email + "</span>";
                        fr += "</div>";
                        fr += "   </div>";
                        fr += "</div>";
                        $(bg).appendTo($(obj)).show().animate({ "opacity": 0.7 }, 800);
                        $(fr).appendTo($(obj));
                        setTimeout(function () {
                            $('#pupip').show().animate({ "opacity": 1, "top": 20 + "%" }, 200);
                            $("#bg_popup").attr("onclick", "close_popup_ms()");
                        }, 1000);
                    }
                },
                error: function (xmlhttprequest, textstatus, errorthrow) {
                    alert('lỗi');
                }
            });
        });

        function searchCode() {
            var code = $("#txtMVD").val();
            if (isEmpty(code)) {
                alert('Vui lòng nhập mã vận đơn.');
            }
            else {
                $.ajax({
                    type: "POST",
                    url: "/Default.aspx/GetInfor",
                    data: "{ordecode:'" + code + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        if (msg.d != "null") {
                            //var data = JSON.parse(msg.d);
                            var title = "Thông tin mã vận đơn";
                            var content = msg.d;
                            var email = "";
                            var obj = $('form');
                            $(obj).css('overflow', 'hidden');
                            $(obj).attr('onkeydown', 'keyclose_ms(event)');
                            var bg = "<div id='bg_popup_home'></div>";
                            var fr = "<div id='pupip_home' class=\"columns-container1\">" +
                                "  <div class=\"center_column col-xs-12 col-sm-5\" id=\"popup_content_home\">";
                            fr += "<div class=\"popup_header\">";
                            fr += title;
                            fr += "<a style='cursor:pointer;right:5px;' onclick='close_popup_ms()' class='close_message'></a>";
                            fr += "</div>";
                            fr += "     <div class=\"changeavatar\">";
                            fr += "         <div class=\"content1\" style=\"width:75%;margin-left:11%\">";
                            fr += content;
                            fr += "         </div>";
                            fr += "         <div class=\"content2\">";
                            fr += "             <a href=\"javascript:;\" class=\"btn btn-close\" onclick='close_popup_ms()'>Đóng</a>";
                            fr += "         </div>";
                            fr += "     </div>";
                            fr += "<div class=\"popup_footer\">";
                            fr += "<span class=\"float-right\">" + email + "</span>";
                            fr += "</div>";
                            fr += "   </div>";
                            fr += "</div>";
                            $(bg).appendTo($(obj)).show().animate({ "opacity": 0.7 }, 800);
                            $(fr).appendTo($(obj));
                            setTimeout(function () {
                                $('#pupip').show().animate({ "opacity": 1, "top": 20 + "%" }, 200);
                                $("#bg_popup").attr("onclick", "close_popup_ms()");
                            }, 1000);
                        }
                    },
                    error: function (xmlhttprequest, textstatus, errorthrow) {
                        alert('lỗi');
                    }
                });
            }

        }
    </script>
    <style>
        #bg_popup_home {
            position: fixed;
            width: 100%;
            height: 100%;
            background-color: #333;
            opacity: 0.7;
            filter: alpha(opacity=70);
            left: 0px;
            top: 0px;
            z-index: 999999999;
            opacity: 0;
            filter: alpha(opacity=0);
        }

        #popup_ms_home {
            background: #fff;
            border-radius: 0px;
            box-shadow: 0px 2px 10px #fff;
            float: left;
            position: fixed;
            width: 735px;
            z-index: 10000;
            left: 50%;
            margin-left: -370px;
            top: 200px;
            opacity: 0;
            filter: alpha(opacity=0);
            height: 360px;
        }

            #popup_ms_home .popup_body {
                border-radius: 0px;
                float: left;
                position: relative;
                width: 735px;
            }

            #popup_ms_home .content {
                /*background-color: #487175;     border-radius: 10px;*/
                margin: 12px;
                padding: 15px;
                float: left;
            }

            #popup_ms_home .title_popup {
                /*background: url("../images/img_giaoduc1.png") no-repeat scroll -200px 0 rgba(0, 0, 0, 0);*/
                color: #ffffff;
                font-family: Arial;
                font-size: 24px;
                font-weight: bold;
                height: 35px;
                margin-left: 0;
                margin-top: -5px;
                padding-left: 40px;
                padding-top: 0;
                text-align: center;
            }

            #popup_ms_home .text_popup {
                color: #fff;
                font-size: 14px;
                margin-top: 20px;
                margin-bottom: 20px;
                line-height: 20px;
            }

                #popup_ms_home .text_popup a.quen_mk, #popup_ms_home .text_popup a.dangky {
                    color: #FFFFFF;
                    display: block;
                    float: left;
                    font-style: italic;
                    list-style: -moz-hangul outside none;
                    margin-bottom: 5px;
                    margin-left: 110px;
                    -webkit-transition-duration: 0.3s;
                    -moz-transition-duration: 0.3s;
                    transition-duration: 0.3s;
                }

                    #popup_ms_home .text_popup a.quen_mk:hover, #popup_ms_home .text_popup a.dangky:hover {
                        color: #8cd8fd;
                    }

            #popup_ms_home .close_popup {
                background: url("/App_Themes/Camthach/images/close_button.png") no-repeat scroll 0 0 rgba(0, 0, 0, 0);
                display: block;
                height: 28px;
                position: absolute;
                right: 0px;
                top: 5px;
                width: 26px;
                cursor: pointer;
                z-index: 10;
            }

        #popup_content_home {
            height: auto;
            position: fixed;
            background-color: #fff;
            top: 15%;
            z-index: 999999999;
            left: 25%;
            border-radius: 10px;
            -moz-border-radius: 10px;
            -webkit-border-radius: 10px;
            width: 50%;
            padding: 20px;
        }

        #popup_content_home {
            padding: 0;
        }

        .popup_header, .popup_footer {
            float: left;
            width: 100%;
            background: #e84545;
            padding: 10px;
            position: relative;
            color: #fff;
        }

        .popup_header {
            font-weight: bold;
            font-size: 16px;
            text-transform: uppercase;
        }

        .close_message {
            top: 10px;
        }

        .changeavatar {
            padding: 10px;
            margin: 5px 0;
            float: left;
            width: 100%;
        }

        .float-right {
            float: right;
        }

        .content1 {
            float: left;
            width: 100%;
        }

        .content2 {
            float: left;
            width: 100%;
            clear: both;
            margin-top: 10px;
        }

        .btn.btn-close {
            float: right;
            background: #175fcc;
            color: #fff;
            margin: 10px -5px;
            text-transform: none;
            padding: 10px 20px;
        }

            .btn.btn-close:hover {
                background: #95d3ef;
            }

        .btn.btn-close-full {
            float: right;
            background: #fed03d;
            color: #fff;
            margin: 10px 5px;
            text-transform: none;
            padding: 10px 20px;
        }

            .btn.btn-close-full:hover {
                background: #f8d486;
            }

        .ab-top {
            position: absolute;
            top: -20px;
            right: -5px;
        }

        .popup_header {
            padding: 9px;
        }

        @media screen and (max-width: 768px) {
            #popup_content_home {
                left: 10%;
                width: 80%;
            }

            .content1 {
                overflow: auto;
                height: 300px;
            }
        }

        .over-flow-auto {
            overflow: auto;
            height: 350px;
        }
        /* Let's get this party started */
        ::-webkit-scrollbar {
            width: 12px;
        }

        /* Track */
        ::-webkit-scrollbar-track {
            -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
            -webkit-border-radius: 10px;
            border-radius: 10px;
        }

        /* Handle */
        ::-webkit-scrollbar-thumb {
            -webkit-border-radius: 10px;
            border-radius: 10px;
            background: rgba(255,0,0,0.8);
            -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.5);
        }

            ::-webkit-scrollbar-thumb:window-inactive {
                background: rgba(255,0,0,0.4);
            }
    </style>
</asp:Content>
